using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Table;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/tables")]
    public class TableController : ControllerBase
    {
        private readonly ITableService tableService;
        private readonly UserManager<ApplicationUser> userManager;

        public TableController(ITableService _tableService, UserManager<ApplicationUser> _userManager)
        {
            tableService = _tableService;
            userManager = _userManager;
        }

        /// <summary>
        /// Retrieves all tables.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetTables()
        {
            var tables = await tableService.GetTables();
            return Ok(tables);
        }

        /// <summary>
        /// Retrieves all occupied tables.
        /// </summary>
        [HttpGet]
        [Route("occupiedtables")]
        public async Task<IActionResult> GetOccupiedTables()
        {
            var tables = await tableService.GetOccupiedTables();
            return Ok(tables);

        }

        /// <summary>
        /// Retrieves a specific table by ID.
        /// </summary>
        /// <param name="tableId">The ID of the table to retrieve.</param>
        [HttpGet("{tableId}")]
        public async Task<IActionResult> GetTableById(int tableId)
        {
            var table = await tableService.GetTableById(tableId);
            if (table == null)
            {
                return NotFound();
            }

            return Ok(table);
        }

        /// <summary>
        /// Creates a new table.
        /// </summary>
        /// <param name="tableCreateDto">The data for creating the table.</param>
        [HttpPost]
        public async Task<IActionResult> CreateTable([FromBody] TableCreateDTO tableCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var createdTable = await tableService.CreateTable(tableCreateDto);
                return CreatedAtAction(nameof(GetTableById), new { tableId = createdTable.Id }, createdTable);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Updates a specific table.
        /// </summary>
        /// <param name="tableId">The ID of the table to update.</param>
        /// <param name="tableUpdateDto">The updated data for the table.</param>
        [HttpPut("{tableId}")]
        public async Task<IActionResult> UpdateTable(int tableId, [FromBody] TableUpdateDTO tableUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedTable = await tableService.UpdateTable(tableId, tableUpdateDto);
                if (updatedTable == null)
                {
                    return NotFound();
                }
                return Ok(updatedTable);

            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }

        }


        /// <summary>
        /// Deletes a specific table.
        /// </summary>
        /// <param name="tableId">The ID of the table to delete.</param>
        [HttpDelete("{tableId}")]
        public async Task<IActionResult> DeleteTable(int tableId)
        {
            var deletedTable = await tableService.DeleteTable(tableId);
            if (deletedTable == null)
            {
                return NotFound();
            }

            return Ok(deletedTable);
        }

        /// <summary>
        /// Assigns an order to a table.
        /// </summary>
        /// <param name="tableId">The ID of the table to assign the order to.</param>
        /// <param name="orderId">The ID of the order to assign.</param>
        [HttpPost("{tableId}/orders/{orderId}")]
        public async Task<IActionResult> AssignOrderToTable(int tableId, int orderId)
        {
            var currentUser = userManager.GetUserAsync(User).Result;
            var result = await tableService.AssignOrderToTable(orderId, tableId, currentUser);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }
    }

}
