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

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            return await repo.All<AUTH_USER>().Select(s => new UserListViewModel { Id = s.Id, UserName = s.UserName, FullName = s.USR_FULLNAME }).ToListAsync();
        }
    }
}