using LSRPO.Core.Models.User;
using Microsoft.AspNetCore.Http;

namespace LSRPO.Core.Contracts.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserProfileViewModel> GetUserForProfileEdit(int id);

        Task<bool> UpdateUser(UserProfileViewModel model, IFormFile image);

        //Task<bool> UpdateRoles(UserRolesViewModel model);
    }
}