using RestoFlow.Core.Models.Order;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Contracts
{
    public interface IOrderService
    {
        Task<OrderDTO> CreateOrder(OrderCreateDTO orderCreateDto, ApplicationUser user);
        Task<OrderDTO> GetOrderById(int orderId);
        Task<List<OrderDTO>> GetOrders();
        Task<List<OrderDTO>> GetOrdersByUserId(string userId);
        Task<OrderDTO> UpdateOrder(int orderId, ApplicationUser user, OrderUpdateDTO orderUpdateDto);
        Task<OrderDTO> DeleteOrder(int orderId);
        Task<OrderDTO> MarkOrderAsReady(int orderId);
        Task<OrderDTO> MarkOrderAsServed(int orderId);
        Task<List<OrderDTO>> GetUserOrdersByTableId(string userId, int tableId);
    }
}
