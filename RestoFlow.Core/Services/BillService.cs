using AutoMapper;

using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Bill;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Services
{
    public class BillService : IBillService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public BillService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public async Task<BillDTO> CreateBill(int tableId, ApplicationUser user)
        {
            var table = repository
                .All<Table>()
                .Include(t => t.OccupiedTables)
                .ThenInclude(o => o.Order)
                .ThenInclude(o => o.Product)
                .FirstOrDefault(t => t.Id == tableId);

            if (table == null)
            {
                return null;
            }

            var orders = table.OccupiedTables.Select(t => t.Order).ToList();
            decimal totalSum = orders.Sum(order => order.ProductQuantity * order.Product.Price);

            var bill = new Bill()
            {
                Table = table,
                TableId = tableId,
                UserId = user.Id,
                User = user,
                Orders = orders,
                Date = DateTime.UtcNow,
                TotalSum = totalSum
            };

            await repository.AddAsync(bill);
            table.OccupiedTables.Clear();
            await repository.SaveChangesAsync();
            return mapper.Map<BillDTO>(bill); ;

        }

    }
}
