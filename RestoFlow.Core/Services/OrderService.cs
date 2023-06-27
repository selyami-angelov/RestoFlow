﻿using AutoMapper;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Order;
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

        public async Task<OrderDTO> CreateOrder(OrderCreateDTO orderCreateDto)
        {
            var order = mapper.Map<Order>(orderCreateDto);
            order.CreatedDate = DateTime.UtcNow;
            order.IsServed = false;

            await repository.AddAsync<Order>(order);
            await repository.SaveChangesAsync();
            var createdOrder = mapper.Map<OrderDTO>(orderCreateDto);

            return mapper.Map<OrderDTO>(createdOrder);
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
            var orders = repository.All<Order>().Where(order => !order.isDeleted).ToList();
            return mapper.Map<List<OrderDTO>>(orders);
        }

        public async Task<List<OrderDTO>> GetOrdersByUserId(string userId)
        {
            var orders = repository.All<Order>().Where(order => order.CreatedById == userId);
            return orders.Select(order => mapper.Map<OrderDTO>(order)).ToList();
        }

        public async Task<OrderDTO> UpdateOrder(int orderId, ApplicationUser user, OrderUpdateDTO orderUpdateDto)
        {
            var existingOrder = await repository.GetByIdAsync<Order>(orderId);

            if (existingOrder == null || existingOrder.isDeleted)
            {
                return null;
            }

            // with auth user
            //existingOrder.ProductId = orderUpdateDto.ProductId;
            //existingOrder.Info = orderUpdateDto.Info;
            //existingOrder.EditedById = user.Id;
            //existingOrder.EditedBy = user;
            //existingOrder.IsServed = orderUpdateDto.IsServed;
            //existingOrder.EditedDate = DateTime.UtcNow;

            // test 
            existingOrder.ProductId = orderUpdateDto.ProductId;
            existingOrder.Info = orderUpdateDto.Info;
            existingOrder.EditedById = "b08ba7ee-0960-4656-baf4-980b1d6b88df";
            existingOrder.IsServed = orderUpdateDto.IsServed;
            existingOrder.EditedDate = DateTime.UtcNow;

            repository.Update<Order>(existingOrder);
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

            await repository.DeleteAsync<Order>(existingOrder);
            await repository.SaveChangesAsync();
            return mapper.Map<OrderDTO>(existingOrder);
        }
    }

}
