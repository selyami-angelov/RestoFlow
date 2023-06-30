using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Order;
using RestoFlow.Infrastructure.Data.Models;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly UserManager<ApplicationUser> userManager;

        public OrderController(IOrderService _orderService, UserManager<ApplicationUser> _userManager)
        {
            orderService = _orderService;
            userManager = _userManager;
        }

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="orderCreateDto">The order information for creation.</param>
        /// <returns>The created order.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDTO orderCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
         
            var currentUser = userManager.GetUserAsync(User).Result;
            var createdOrder = await orderService.CreateOrder(orderCreateDto, currentUser);
            return CreatedAtAction(nameof(GetOrderById), new { orderId = createdOrder.Id }, createdOrder);
        }

        /// <summary>
        /// Retrieves an order by its ID.
        /// </summary>
        /// <param name="orderId">The ID of the order to retrieve.</param>
        /// <returns>The order with the specified ID.</returns>
        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderById(int orderId)
        {
            var order = await orderService.GetOrderById(orderId);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>A list of orders.</returns>
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await orderService.GetOrders();
            return Ok(orders);
        }

        /// <summary>
        /// Retrieves orders associated with a user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>A list of orders associated with the user.</returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetOrdersByUserId(string userId)
        {
            var orders = await orderService.GetOrdersByUserId(userId);
            return Ok(orders);
        }


        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="orderId">The ID of the order to update.</param>
        /// <param name="orderUpdateDto">The updated order information.</param>
        /// <returns>The updated order.</returns>
        [HttpPut("{orderId}")]
        public async Task<IActionResult> UpdateOrder(int orderId, [FromBody] OrderUpdateDTO orderUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = userManager.GetUserAsync(User).Result;

            var updatedOrder = await orderService.UpdateOrder(orderId, user, orderUpdateDto);
            if (updatedOrder == null)
            {
                return NotFound();
            }

            return Ok(updatedOrder);
        }

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="orderId">The ID of the order to delete.</param>
        /// <returns>The deleted order.</returns>
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> DeleteOrder(int orderId)
        {
            var deletedOrder = await orderService.DeleteOrder(orderId);
            if (deletedOrder == null)
            {
                return NotFound();
            }

            return Ok(deletedOrder);
        }
    }
}
