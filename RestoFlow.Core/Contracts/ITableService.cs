using RestoFlow.Core.Models.Table;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Contracts
{
    public interface ITableService
    {
        Task<List<TableDTO>> GetTables();
        Task<TableDTO> GetTableById(int tableId);
        Task<TableDTO> CreateTable(TableCreateDTO tableCreateDto);
        Task<TableDTO> UpdateTable(int tableId, TableUpdateDTO tableUpdateDto);
        Task<TableDTO> DeleteTable(int tableId);
        Task<bool> AssignOrderToTable(int orderId, int tableId, ApplicationUser user);
        Task<List<OccupiedTableDTO>> GetOccupiedTables();
    }
}
