using RestoFlow.Core.Models.Order;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Contracts
{
    public interface IOrderService
    {
        Task<OrderDTO> CreateOrder(OrderCreateDTO orderCreateDto);
        Task<OrderDTO> GetOrderById(int orderId);
        Task<List<OrderDTO>> GetOrders();
        Task<List<OrderDTO>> GetOrdersByUserId(string userId);
        Task<OrderDTO> UpdateOrder(int orderId, ApplicationUser user, OrderUpdateDTO orderUpdateDto);
        Task<OrderDTO> DeleteOrder(int orderId);
    }
}
