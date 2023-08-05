using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.User;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper mapper;

        public UserService(UserManager<ApplicationUser> _userManager, IMapper _mapper)
        {
            userManager = _userManager;
            mapper = _mapper;
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var users = await userManager.Users.ToListAsync();
            var userDTOs = new List<UserDTO>();

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                var userDTO = mapper.Map<UserDTO>(user);
                userDTO.Roles = roles;
                userDTOs.Add(userDTO);
            }

            return userDTOs;
        }

        public async Task<bool> AssignRoleAsync(string userId, string role)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }

            var result = await userManager.AddToRoleAsync(user, role);
            return result.Succeeded;
        }

        public async Task<bool> RemoveRoleAsync(string userId, string role)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }

            var result = await userManager.RemoveFromRoleAsync(user, role);
            return result.Succeeded;
        }

    }
}
