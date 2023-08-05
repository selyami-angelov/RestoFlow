using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost("{userId}/assign-role")]
        public async Task<IActionResult> AssignRole(string userId, [FromBody] string role)
        {
            var success = await userService.AssignRoleAsync(userId, role);
            if (success)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPost("{userId}/remove-role")]
        public async Task<IActionResult> RemoveRole(string userId, [FromBody] string role)
        {
            var success = await userService.RemoveRoleAsync(userId, role);
            if (success)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
