using AutoMapper;

using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Order;
using RestoFlow.Core.Models.Product;
using RestoFlow.Infrastructure.Data.Models;



namespace RestoFlow.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public OrderService(IRepository _orderRepository, IMapper _mapper)
        {
            repository = _orderRepository;
            mapper = _mapper;
        }

        public async Task<OrderDTO> CreateOrder(OrderCreateDTO orderCreateDto, ApplicationUser user)
        {
            var order = mapper.Map<Order>(orderCreateDto);
            order.CreatedDate = DateTime.UtcNow;
            order.IsServed = false;
            order.IsReady = false;
            order.CreatedBy = user;
            order.CreatedById = user.Id;


            await repository.AddAsync<Order>(order);
            await repository.SaveChangesAsync();

            return mapper.Map<OrderDTO>(order);
        }

        public async Task<OrderDTO> GetOrderById(int orderId)
        {
            var order = await repository.GetByIdAsync<Order>(orderId);

            if (order == null || order.isDeleted)
            {
                return null;
            }

            return mapper.Map<OrderDTO>(order);
        }

        public async Task<List<OrderDTO>> GetOrders()
        {
            var orders = repository.All<Order>()
                .Include(o => o.CreatedBy)
                .Include(o => o.EditedBy)
                .Include(o => o.Product)
                .ThenInclude(p => p.Category)
                .Where(order => !order.isDeleted && !order.IsReady).ToList();

            var result = orders.Select(order => MapOrder(order)).ToList();


            return result;
        }

        public async Task<List<OrderDTO>> GetUserOrdersByTableId(string userId, int tableId)
        {
            var orders = repository.All<Order>()
                .Include(o => o.OccupiedTables)
                .Include(o => o.CreatedBy)
                .Include(o => o.EditedBy)
                .Where(o => o.OccupiedTables.Any(ot => ot.TableId == tableId) && o.CreatedBy.Id == userId && !o.isDeleted)
                .ToList();

            var result = orders.Select(order => MapOrder(order)).ToList();


            return result;
        }

        public async Task<List<OrderDTO>> GetOrdersByUserId(string userId)
        {
            var orders = repository.All<Order>()
                .Where(order => order.CreatedById == userId && !order.isDeleted && !order.IsServed)
                .Include(o => o.Product)
                    .ThenInclude(p => p.Category)
                .Include(o => o.OccupiedTables)
                  .ThenInclude(ot => ot.Table)
                .ToList();
            var result = orders.Select(order => MapOrder(order)).ToList();
            return result;
        }

        public async Task<OrderDTO> UpdateOrder(int orderId, ApplicationUser user, OrderUpdateDTO orderUpdateDto)
        {
            var existingOrder = await repository.GetByIdAsync<Order>(orderId);

            if (existingOrder == null || existingOrder.isDeleted)
            {
                return null;
            }

            existingOrder.ProductId = orderUpdateDto.ProductId;
            existingOrder.Info = orderUpdateDto.Info;
            existingOrder.EditedById = user.Id;
            existingOrder.EditedBy = user;
            existingOrder.IsServed = orderUpdateDto.IsServed;
            existingOrder.EditedDate = DateTime.UtcNow;

            repository.Update<Order>(existingOrder);
            await repository.SaveChangesAsync();
            return mapper.Map<OrderDTO>(existingOrder);
        }

        public async Task<OrderDTO> MarkOrderAsReady(int orderId)
        {
            var existingOrder = await repository.GetByIdAsync<Order>(orderId);

            if (existingOrder == null || existingOrder.isDeleted)
            {
                return null;
            }

            existingOrder.IsReady = true;
            await repository.SaveChangesAsync();
            return mapper.Map<OrderDTO>(existingOrder);
        }

        public async Task<OrderDTO> MarkOrderAsServed(int orderId)
        {
            var existingOrder = await repository.GetByIdAsync<Order>(orderId);

            if (existingOrder == null || existingOrder.isDeleted)
            {
                return null;
            }

            existingOrder.IsServed = true;
            await repository.SaveChangesAsync();
            return mapper.Map<OrderDTO>(existingOrder);
        }

        public async Task<OrderDTO> DeleteOrder(int orderId)
        {
            var existingOrder = await repository.GetByIdAsync<Order>(orderId);

            if (existingOrder == null || existingOrder.isDeleted)
            {
                return null;
            }


            existingOrder.isDeleted = true;
            await repository.SaveChangesAsync();
            return mapper.Map<OrderDTO>(existingOrder);
        }


        private OrderDTO MapOrder(Order order)
        {
            return new OrderDTO()
            {
                Id = order.Id,
                CreatedBy = $"{order.CreatedBy.FirstName} {order.CreatedBy.LastName}",
                CreatedById = order.CreatedById,
                CreatedDate = order.CreatedDate,
                EditedBy = order.EditedBy != null ? $"{order.EditedBy.FirstName} {order.EditedBy.LastName}" : null,
                EditedById = order.EditedById,
                EditedDate = order.EditedDate,
                Info = order.Info,
                TableNumber = order?.OccupiedTables?.First()?.Table?.TableNumber,
                ProductId = order.ProductId,
                Product = mapper.Map<ProductDTO>(order.Product),
                ProductQuantity = order.ProductQuantity,
                IsReady = order.IsReady,
                IsServed = order.IsServed,
            };
        }

    }

}
