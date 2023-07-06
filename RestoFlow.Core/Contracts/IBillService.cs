using RestoFlow.Core.Models.Bill;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Contracts
{
    public interface IBillService
    {
        Task<BillDTO> CreateBill(int tableId, ApplicationUser user);
        Task<List<BillDTO>> GetUserBillsByDate(DateOnly date, ApplicationUser user);
    }
}
