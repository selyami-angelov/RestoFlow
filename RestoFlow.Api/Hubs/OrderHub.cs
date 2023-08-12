using Microsoft.AspNetCore.SignalR;

namespace RestoFlow.Api.Hubs
{
    public class OrderHub : Hub
    {
        public async Task NewOrderCreated(object newOrder)
        {
            await Clients.All.SendAsync("NewOrderCreated", newOrder);
        }

        public async Task OrderIsReady(object order)
        {
            await Clients.All.SendAsync("OrderIsReady", order);
        }
    }
}
