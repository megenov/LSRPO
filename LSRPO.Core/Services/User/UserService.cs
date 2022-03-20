using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRPO.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly IApplicatioDbRepository repo;

        public UserService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<UserEditViewModel> GetUserForEdit(int id)
        {
            var user = await repo.GetByIdAsync<AUTH_USER>(id);

            return new UserEditViewModel { Id = user.Id, FullName = user.USR_FULLNAME };
        }

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            return await repo.All<AUTH_USER>().Select(s => new UserListViewModel { Id = s.Id, UserName = s.UserName, FullName = s.USR_FULLNAME }).ToListAsync();
        }

        public async Task<bool> UpdateUser(UserEditViewModel model)
        {
            bool result = false;

            var user = await repo.GetByIdAsync<AUTH_USER>(model.Id);

            if (user != null)
            {
                user.USR_FULLNAME = model.FullName;
                await repo.SaveChangesAsync();
                result = true;
            }

            return result;
        }
    }
}