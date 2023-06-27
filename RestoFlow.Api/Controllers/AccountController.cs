using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Models.User;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly ILogger<AccountController> logger;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RestoFlowDbContext context;
        private readonly TokenService tokenService;

        public AccountController(
            IMapper _mapper,
            ILogger<AccountController> _logger,
            UserManager<ApplicationUser> _userManager,
            RestoFlowDbContext _context,
            TokenService _tokenService)
        {
            this.userManager = _userManager;
            this.logger = _logger;
            this.mapper = _mapper;
            this.context = _context;
            this.tokenService = _tokenService;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO model)
        {
            logger.LogInformation($"Registration Attempt for {model.Email}");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            try
            {
                var role = context.Roles.FirstOrDefault(r => r.Id == 1);
                var user = mapper.Map<ApplicationUser>(model);
                user.Role = role;
                user.RoleId = role.Id;
                user.UserName = model.Email;

                var result = await userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }

                    return BadRequest(ModelState);
                }

                return Accepted();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Something Went Wrong in the {nameof(Register)}");
                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
                throw;
            }

        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthResponseDTO>> Login([FromBody] LoginDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var managedUser = await userManager.FindByEmailAsync(model.Email);
            if (managedUser == null)
            {
                return BadRequest("Bad credentials");
            }
            var isPasswordValid = await userManager.CheckPasswordAsync(managedUser, model.Password);
            if (!isPasswordValid)
            {
                return BadRequest("Bad credentials");
            }

            var userInDb = context.Users.FirstOrDefault(u => u.Email == model.Email);
            if (userInDb is null)
                return Unauthorized();
            var accessToken = tokenService.CreateToken(userInDb);
            await context.SaveChangesAsync();

            return Ok(new AuthResponseDTO
            {
                Username = userInDb.UserName,
                Email = userInDb.Email,
                Token = accessToken,
            });
        }

    }
}
