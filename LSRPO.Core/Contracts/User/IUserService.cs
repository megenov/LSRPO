using LSRPO.Core.Models.User;

namespace LSRPO.Core.Contracts.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserEditViewModel> GetUserForEdit(int id);

        Task<UserProfileViewModel> GetUserForProfileEdit(int id);

        Task<bool> UpdateUser(UserProfileViewModel model);

        //Task<bool> UpdateRoles(UserRolesViewModel model);
    }
}