﻿using AutoMapper;

using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Order;
using RestoFlow.Core.Models.Product;
using RestoFlow.Core.Models.Table;
using RestoFlow.Core.Models.User;
using RestoFlow.Infrastructure.Data.Models;

using static RestoFlow.Infrastructure.Constants.Table;

namespace RestoFlow.Core.Services
{
    public class TableService : ITableService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public TableService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public async Task<List<TableDTO>> GetTables()
        {
            var tables = repository.All<Table>().ToList();
            return mapper.Map<List<TableDTO>>(tables);
        }

        public async Task<List<TableDTO>> GetTablesByUserId(string userId)
        {
            var tables = repository.All<Table>()
                .Include(t => t.OccupiedTables)
                .Where(t => t.OccupiedTables.Any(oc => oc.UserId == userId))
                .ToList();
            return mapper.Map<List<TableDTO>>(tables);
        }

        public async Task<TableDTO> GetTableById(int tableId)
        {
            var table = await repository.GetByIdAsync<Table>(tableId);

            if (table == null)
            {
                return null;
            }

            return mapper.Map<TableDTO>(table);
        }

        public async Task<TableDTO> ReleaseTable(int tableId)
        {
            var table = repository.All<Table>()
                .Include(t => t.OccupiedTables)
                .FirstOrDefault(t => t.Id == tableId);

            if (table == null)
            {
                return null;
            }

            table.OccupiedTables.Clear();
            repository.Update<Table>(table);
            await repository.SaveChangesAsync();
            return mapper.Map<TableDTO>(table);
        }


        public async Task<TableDTO> CreateTable(TableCreateDTO tableCreateDto)
        {
            var existingTable = repository.All<Table>().FirstOrDefault(t => t.TableNumber == tableCreateDto.TableNumber);
            if (existingTable != null)
            {
                throw new ApplicationException(TableExistsErrorMessage);
            }

            var table = mapper.Map<Table>(tableCreateDto);
            await repository.AddAsync<Table>(table);
            await repository.SaveChangesAsync();
            return mapper.Map<TableDTO>(table);
        }

        public async Task<TableDTO> UpdateTable(int tableId, TableUpdateDTO tableUpdateDto)
        {
            var existingTable = await repository.GetByIdAsync<Table>(tableId);

            if (existingTable == null)
            {
                return null;
            }

            var existingTableByNumber = repository.All<Table>().FirstOrDefault(t => t.TableNumber == tableUpdateDto.TableNumber);
            if (existingTableByNumber != null)
            {
                throw new ApplicationException(TableExistsErrorMessage);
            }

            existingTable.TableNumber = tableUpdateDto.TableNumber;
            existingTable.Seats = tableUpdateDto.Seats;
            repository.Update<Table>(existingTable);
            await repository.SaveChangesAsync();
            return mapper.Map<TableDTO>(existingTable);
        }

        public async Task<TableDTO> DeleteTable(int tableId)
        {
            var existingTable = await repository.GetByIdAsync<Table>(tableId);

            if (existingTable == null)
            {
                return null;
            }

            await repository.DeleteAsync<Table>(tableId);
            await repository.SaveChangesAsync();
            return mapper.Map<TableDTO>(existingTable);
        }

        public async Task<bool> AssignOrderToTable(int orderId, int tableId, ApplicationUser user)
        {
            var order = await repository.GetByIdAsync<Order>(orderId);
            var table = await repository.GetByIdAsync<Table>(tableId);

            if (order == null || table == null)
            {
                return false;
            }

            var occupiedTable = new OccupiedTable
            {
                Order = order,
                Table = table,
                User = user
            };

            await repository.AddAsync<OccupiedTable>(occupiedTable);
            await repository.SaveChangesAsync();
            return true;
        }

        public async Task<List<OccupiedTableDTO>> GetOccupiedTables()
        {
            var tables = await repository.All<Table>()
            .Include(t => t.OccupiedTables)
                .ThenInclude(ot => ot.User)
            .Include(t => t.OccupiedTables)
                 .ThenInclude(ot => ot.Order)
                 .ThenInclude(o => o.Product)
            .Where(t => t.OccupiedTables.Any())
            .ToListAsync();

            var occupiedTables = new List<OccupiedTableDTO>();

            foreach (var table in tables)
            {
                var occupiedTable = new OccupiedTableDTO();
                occupiedTable.Table = mapper.Map<TableDTO>(table);
                occupiedTable.User = mapper.Map<UserDTO>(table.OccupiedTables[0].User);
                occupiedTable.Orders = mapper.Map<List<OrderDTO>>(table.OccupiedTables.Select(ot => ot.Order));
                occupiedTables.Add(occupiedTable);
            }

            return occupiedTables;
        }
    }
}
