using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Core.Services.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace LSRPO.Test
{
    public class UserServiceTest
    {
        private ServiceProvider serviceProvider;
        private InMemoryDbContext dbContext;

        [SetUp]
        public async Task Setup()
        {
            dbContext = new InMemoryDbContext();
            var serviceCollection = new ServiceCollection();

            serviceProvider = serviceCollection
                .AddSingleton(sp => dbContext.CreateContext())
                .AddSingleton<IApplicatioDbRepository, ApplicatioDbRepository>()
                .AddSingleton<IUserService, UserService>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<IApplicatioDbRepository>();
            await SeedDbAsync(repo);
        }

        [Test]
        public async Task GetUserForProfileEditSuccessTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var userViewModel = new UserProfileViewModel { Id = 1, UserName = "pesho", FullName = "Пешо", Image = "user.png" };
            (var result, var model) = await service.GetUserForProfileEdit(1);

            Assert.AreEqual(userViewModel.Id, model.Id);
            Assert.AreEqual(userViewModel.UserName, model.UserName);
            Assert.AreEqual(userViewModel.FullName, model.FullName);
            Assert.AreEqual(userViewModel.Image, model.Image);
            Assert.AreEqual(userViewModel.Description, model.Description);
            Assert.AreEqual(result, true);
        }

        [Test]
        public async Task GetUserForProfileEditUnknownUserTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            (var result, var model) = await service.GetUserForProfileEdit(2);

            Assert.AreEqual(result, false);
        }

        [Test]
        public async Task GetUsersSuccessTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new UserListViewModel { Id = 1, UserName = "pesho", FullName = "Пешо", RegDate = "n/a" };
            var users = await service.GetUsers();

            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).Id, model.Id);
            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).UserName, model.UserName);
            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).FullName, model.FullName);
            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).RegDate, model.RegDate);
            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).Description, model.Description);
        }

        [Test]
        public async Task GetUsersCountSuccessTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var users = await service.GetUsers();

            Assert.AreEqual(users.Count(), 2);
        }

        [Test]
        public async Task UpdateNameNoChangesTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new UserProfileViewModel { Id = 1, UserName = "pesho", FullName = "Пешо", Image = "user.png" };

            (var result, var error) = await service.UpdateName(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, string.Empty);
        }

        [Test]
        public async Task UpdateNameUnknownUserTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new UserProfileViewModel { Id = 2, UserName = "pesho", FullName = "Пешо", Image = "user.png" };

            (var result, var error) = await service.UpdateName(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task UpdateNameChangeFullNameTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new UserProfileViewModel { Id = 1, UserName = "pesho", FullName = "Пешо Пешев", Image = "user.png" };

            (var result, var error) = await service.UpdateName(model);

            var users = await service.GetUsers();

            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).FullName, model.FullName);
            Assert.AreEqual(result, true);
            Assert.AreEqual(error, string.Empty);
        }

        [Test]
        public async Task UpdateNameChangeDescriptionTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new UserProfileViewModel { Id = 1, UserName = "pesho", FullName = "Пешо", Image = "user.png", Description = "Пешака" };

            (var result, var error) = await service.UpdateName(model);

            var users = await service.GetUsers();

            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).Description, model.Description);
            Assert.AreEqual(result, true);
            Assert.AreEqual(error, string.Empty);
        }

        [Test]
        public async Task UpdateNameChangeFullNameAndDescriptionTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new UserProfileViewModel { Id = 1, UserName = "pesho", FullName = "Пешо Пешев", Image = "user.png", Description = "Пешака" };

            (var result, var error) = await service.UpdateName(model);

            var users = await service.GetUsers();

            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).FullName, model.FullName);
            Assert.AreEqual(users.FirstOrDefault(f => f.Id == 1).Description, model.Description);
            Assert.AreEqual(result, true);
            Assert.AreEqual(error, string.Empty);
        }

        [Test]
        public async Task GetPinCodesSuccessTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new PinCodesViewModel { Id = 1, UserName = "pesho", FullName = "Пешо", PinId = 1, PinCode = "181488" };
            var pinCodes = await service.GetPinCodes();

            Assert.AreEqual(pinCodes.FirstOrDefault(f => f.Id == 1).Id, model.Id);
            Assert.AreEqual(pinCodes.FirstOrDefault(f => f.Id == 1).UserName, model.UserName);
            Assert.AreEqual(pinCodes.FirstOrDefault(f => f.Id == 1).FullName, model.FullName);
            Assert.AreEqual(pinCodes.FirstOrDefault(f => f.Id == 1).Description, model.Description);
            Assert.AreEqual(pinCodes.FirstOrDefault(f => f.Id == 1).PinId, model.PinId);
            Assert.AreEqual(pinCodes.FirstOrDefault(f => f.Id == 1).PinCode, model.PinCode);
        }

        [Test]
        public async Task GetPinCodesCountSuccessTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var pinCodes = await service.GetPinCodes();

            Assert.AreEqual(pinCodes.Count(), 2);
        }

        [Test]
        public async Task GetPinCodeExsistPinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var pinViewModel = new ChangePinViewModel { PinCode = "181488", UserId = 1, UserName = "Пешо" };
            var model = await service.GetPinCode(1);

            Assert.AreEqual(pinViewModel.UserId, model.UserId);
            Assert.AreEqual(pinViewModel.UserName, model.UserName);
            Assert.AreEqual(pinViewModel.PinCode, model.PinCode);
        }

        [Test]
        public async Task GetPinCodeNoExsistPinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var pinViewModel = new ChangePinViewModel { UserId = 1, UserName = "Пешо" };
            await service.DeletePinCode(1);
            var model = await service.GetPinCode(1);

            Assert.AreEqual(pinViewModel.UserId, model.UserId);
            Assert.AreEqual(pinViewModel.UserName, model.UserName);
            Assert.AreEqual(pinViewModel.PinCode, model.PinCode);
        }

        [Test]
        public async Task GetPinCodeNoExsistPin2Test()
        {
            var service = serviceProvider.GetService<IUserService>();

            var pinViewModel = new ChangePinViewModel { UserId = 111, UserName = "Пешо" };
            var model = await service.GetPinCode(111);

            Assert.AreEqual(pinViewModel.UserId, model.UserId);
            Assert.AreEqual(pinViewModel.UserName, model.UserName);
            Assert.AreEqual(pinViewModel.PinCode, model.PinCode);
        }

        [Test]
        public async Task GetPinCodeExceptionTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetPinCode(2), "Невалиден потребител!");
        }

        [Test]
        public async Task GetPinCodeNoExceptionTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            Assert.DoesNotThrowAsync(async () => await service.GetPinCode(1));
        }

        [Test]
        public async Task ChangePinUnknownUserTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new ChangePinViewModel { UserId = 11, PinCode = "181488", UserName = "Пешо" };

            (var result, var error) = await service.ChangePin(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task ChangePinSamePinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new ChangePinViewModel { UserId = 1, PinCode = "181488", UserName = "Пешо" };

            (var result, var error) = await service.ChangePin(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "ПИН кода е същият като предишният!");
        }

        [Test]
        public async Task ChangePinExistPinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new ChangePinViewModel { UserId = 111, PinCode = "181488", UserName = "Пешо" };

            (var result, var error) = await service.ChangePin(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Този ПИН код вече се използва!");
        }

        [Test]
        public async Task ChangePinUserHasPinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new ChangePinViewModel { UserId = 1, PinCode = "888888", UserName = "Пешо" };

            (var result, var error) = await service.ChangePin(model);

            var pinCode = await service.GetPinCode(1);

            Assert.AreEqual(pinCode.PinCode, model.PinCode);
            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task ChangePinUserHasNoPinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var model = new ChangePinViewModel { UserId = 111, PinCode = "888888", UserName = "Пешо" };

            (var result, var error) = await service.ChangePin(model);

            var pinCode = await service.GetPinCode(111);

            Assert.AreEqual(pinCode.PinCode, model.PinCode);
            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task DeletePinCodeUnknownPinTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            (var result, var error) = await service.DeletePinCode(0);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Този потребител няма ПИН код!");
        }

        [Test]
        public async Task DeletePinCodeSuccessTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            (var result, var error) = await service.DeletePinCode(1);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, string.Empty);
        }

        [Test]
        public async Task HasPinCodeTrueTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var result = await service.HasPinCode(1);

            Assert.AreEqual(result, true);
        }

        [Test]
        public async Task HasPinCodeFalseTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            var result = await service.HasPinCode(11);

            Assert.AreEqual(result, false);
        }

        [Test]
        public async Task HasPinCodeFalse2Test()
        {
            var service = serviceProvider.GetService<IUserService>();

            var result = await service.HasPinCode(111);

            Assert.AreEqual(result, false);
        }

        [Test]
        public async Task HasGroupFalseTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            (var result, var groups) = await service.HasGroup(11);

            Assert.AreEqual(result, false);
            Assert.AreEqual(groups.Count, 0);
        }

        [Test]
        public async Task HasGroupFalse2Test()
        {
            var service = serviceProvider.GetService<IUserService>();

            (var result, var groups) = await service.HasGroup(111);

            Assert.AreEqual(result, false);
            Assert.AreEqual(groups.Count, 0);
        }

        [Test]
        public async Task HasGroupTrueTest()
        {
            var service = serviceProvider.GetService<IUserService>();

            (var result, var groups) = await service.HasGroup(1);

            Assert.AreEqual(result, true);
            Assert.AreEqual(groups.Count, 2);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

        private async Task SeedDbAsync(IApplicatioDbRepository repo)
        {
            var group1 = new NOTIFY_GROUP() { NG_ID = 1, NG_NAME = "Група 1" };
            var group2 = new NOTIFY_GROUP() { NG_ID = 2, NG_NAME = "Група 2" };

            var user = new AUTH_USER()
            {
                Id = 1,
                USR_FULLNAME = "Пешо",
                UserName = "pesho",
                NormalizedUserName = "PESHO",
                Email = "pesho",
                NormalizedEmail = "PESHO",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEB+kJxgq69VqXpbAKwZD8xoSZ5wZheDa2CF0KEqva9IZXW7Hpb1j2VtjQ3esqqab9w==",
                SecurityStamp = "ILLGIHW4Y2BJUNCTWYZREKYPRV7L3XAC",
                ConcurrencyStamp = "928cd815-7d07-48e8-b1e2-55c9d619905e",
                LockoutEnabled = false,
                PhoneNumberConfirmed = false,
                PhoneNumber = "1234",
                AccessFailedCount = 0,
                TwoFactorEnabled = false,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { NOT_USR_ID = 1, USR_PIN = "181488", USR_ID = 1 },
                NG_USRS = new List<NG_USR>() { new NG_USR() { NG_ID = 1, USR_ID = 1 }, new NG_USR() { NG_ID = 2, USR_ID = 1 }}
            };

            var user2 = new AUTH_USER()
            {
                Id = 111,
                USR_FULLNAME = "Пешо",
                UserName = "pesho2",
                NormalizedUserName = "PESHO2",
                Email = "pesho2",
                NormalizedEmail = "PESHO2",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEB+kJxgq69VqXpbAKwZD8xoSZ5wZheDa2CF0KEqva9IZXW7Hpb1j2VtjQ3esqqab9w==",
                SecurityStamp = "ILLGIHW4Y2BJUNCTWYZREKYPRV7L3XAC",
                ConcurrencyStamp = "928cd815-7d07-48e8-b1e2-55c9d619905e",
                LockoutEnabled = false,
                PhoneNumberConfirmed = false,
                PhoneNumber = "1234",
                AccessFailedCount = 0,
                TwoFactorEnabled = false,
                IMAGE_URL = "user.png"
            };

            await repo.AddAsync(group1);
            await repo.AddAsync(group2);
            await repo.AddAsync(user);
            await repo.AddAsync(user2);
            await repo.SaveChangesAsync();
        }
    }
}