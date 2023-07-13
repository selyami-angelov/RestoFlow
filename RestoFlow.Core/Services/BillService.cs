using AutoMapper;

using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Bill;
using RestoFlow.Core.Models.User;
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

        public async Task<List<BillDTO>> GetUserBillsByDate(DateOnly date, ApplicationUser user)
        {
            var bills = await repository.All<Bill>()
                .Where(b => b.Date.Year == date.Year &&
                b.Date.Month == date.Month &&
                b.Date.Day == date.Day && b.UserId == user.Id)
                .Include(b => b.Table)
                .Include(b => b.Orders)
                     .ThenInclude(o => o.Product)
                .ToListAsync();


            return bills.Select(b =>
            {
                var result = mapper.Map<BillDTO>(b);
                result.TableNumber = b.Table.TableNumber;
                return result;

            }).ToList();
        }

        public async Task<List<BillDTO>> GetAllBillsByDate(DateOnly date)
        {
            var bills = await repository.All<Bill>()
                .Where(b => b.Date.Year == date.Year &&
                b.Date.Month == date.Month &&
                b.Date.Day == date.Day)
                .Include(b => b.Table)
                .Include(b => b.User)
                .Include(b => b.Orders)
                     .ThenInclude(o => o.Product)
                .ToListAsync();


            var mappedBills = bills.Select(b =>
            {
                var result = mapper.Map<BillDTO>(b);
                result.TableNumber = b.Table.TableNumber;
                result.User = $"{b.User.FirstName} {b.User.LastName}";
                return result;

            }).ToList();

            return mappedBills;
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
