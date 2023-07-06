using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;
using RestoFlow.Infrastructure.Data.Models;

using static RestoFlow.Infrastructure.Constants;

namespace RestoFlow.Api.Controllers
{
    [Route("api/bill")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService billService;
        private readonly UserManager<ApplicationUser> userManager;

        public BillController(IBillService _billService, UserManager<ApplicationUser> _userManager)
        {
            billService = _billService;
            userManager = _userManager;
        }

        
        [HttpGet("create/{tableId}")]
        public async Task<IActionResult> CreateBill(int tableId)
        {
            var currentUser = userManager.GetUserAsync(User).Result;
            var bill = await billService.CreateBill(tableId, currentUser);
            return CreatedAtAction(nameof(CreateBill), new { billId = bill.Id }, bill);
        }

        [HttpGet("{date}")]
        public async Task<IActionResult> GetUserBillsByDate(string date)
        {
            var currentUser = userManager.GetUserAsync(User).Result;
            DateTime dateTime = DateTime.ParseExact(date, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", null);
            DateOnly dateOnly = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);

            var bills = await billService.GetUserBillsByDate(dateOnly, currentUser);
            return Ok(bills);
        }
    }
}
