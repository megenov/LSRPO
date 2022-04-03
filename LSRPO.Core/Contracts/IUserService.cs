using LSRPO.Core.Models.User;
using Microsoft.AspNetCore.Http;

namespace LSRPO.Core.Contracts.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserProfileViewModel> GetUserForProfileEdit(int id);

        Task<(bool result, bool nameEdit, bool imageEdit)> UpdateUser(UserProfileViewModel model, IFormFile image);

        Task<IEnumerable<PinCodesViewModel>> GetPinCodes();

        Task<ChangePinViewModel> GetPinCode(int id);

        Task<(bool result, string error)> ChangePin(ChangePinViewModel model);

        Task<(bool result, string error)> DeletePinCode(int pinId);

        //Task<bool> DeleteUserPin(int id);

        Task<bool> HasPinCode(int id);

        Task<(bool result, List<string>)> HasGroup(int id);
    }
}