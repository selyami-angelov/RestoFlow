using RestoFlow.Core.Models.User;

namespace RestoFlow.Core.Contracts
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<bool> AssignRoleAsync(string userId, string role);
        Task<bool> RemoveRoleAsync(string userId, string role);
    }
}
