﻿using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace LSRPO.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly IApplicatioDbRepository repo;
        private readonly IWebHostEnvironment webHostEnvironment;

        public UserService(IApplicatioDbRepository repo, IWebHostEnvironment webHostEnvironment)
        {
            this.repo = repo;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<UserProfileViewModel> GetUserForProfileEdit(int id)
        {
            var user = await repo.GetByIdAsync<AUTH_USER>(id);

            return new UserProfileViewModel { Id = user.Id, UserName = user.UserName, FullName = user.USR_FULLNAME, Image = user.IMAGE_URL };
        }

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            return await repo.All<AUTH_USER>().Select(s => new UserListViewModel { Id = s.Id, UserName = s.UserName, FullName = s.USR_FULLNAME }).ToListAsync();
        }

        public async Task<(bool result, bool nameEdit, bool imageEdit)> UpdateUser(UserProfileViewModel model, IFormFile image)
        {
            bool result = false;
            bool nameEdit = false;
            bool imageEdit = false;
            var user = await repo.GetByIdAsync<AUTH_USER>(model.Id);

            if (image != null)
            {
                string detailPath = Path.Combine(@"\img", image.FileName);
                using (var stream = new FileStream(webHostEnvironment.WebRootPath + detailPath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                if (user != null)
                {
                    if (user.USR_FULLNAME != model.FullName)
                    {
                        user.USR_FULLNAME = model.FullName;
                        nameEdit = true;
                    }

                    user.IMAGE_URL = image.FileName;
                    await repo.SaveChangesAsync();
                    result = true;
                    imageEdit = true;
                }
            }

            else if (user != null)
            {
                if (user.USR_FULLNAME != model.FullName)
                {
                    user.USR_FULLNAME = model.FullName;
                    await repo.SaveChangesAsync();
                    nameEdit = true;
                }
                result = true;
            }

            return (result, nameEdit, imageEdit);
        }
    }
}