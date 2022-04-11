using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyGroup;
using LSRPO.Core.Services;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSRPO.Test
{
    public class NotifyGroupServiceTest
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
                .AddSingleton<INotifyGroupService, NotifyGroupService>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<IApplicatioDbRepository>();
            await SeedDbAsync(repo);
        }

        [Test]
        public async Task GetGroupsSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new NotifyGroupListViewModel { Id = 1, Name = "Group1", Description = "Група 1", Number = "8888", DateOfChange = "n/a", Flag = false };
            var groups = await service.GetGroups();

            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 1).Id, model.Id);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 1).Name, model.Name);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 1).Description, model.Description);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 1).Number, model.Number);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 1).DateOfChange, model.DateOfChange);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 1).Flag, model.Flag);
        }

        [Test]
        public async Task GetGroupsSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new NotifyGroupListViewModel { Id = 2, Name = "Group2", Description = "Група 2", Number = "8888", DateOfChange = "n/a", Flag = true };
            var groups = await service.GetGroups();

            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Id, model.Id);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Name, model.Name);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Description, model.Description);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Number, model.Number);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).DateOfChange, model.DateOfChange);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Flag, model.Flag);
        }

        [Test]
        public async Task GetGroupsCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var groups = await service.GetGroups();

            Assert.AreEqual(groups.Count(), 3);
        }

        [Test]
        public async Task GetGroupForEditSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var group = new EditGroupViewModel { GroupId = 2, Name = "Group2", Description = "Група 2", Number = "8888", Flag = true };
            var model = await service.GetGroupForEdit(2);

            Assert.AreEqual(group.GroupId, model.GroupId);
            Assert.AreEqual(group.Name, model.Name);
            Assert.AreEqual(group.Description, model.Description);
            Assert.AreEqual(group.Number, model.Number);
            Assert.AreEqual(group.Flag, model.Flag);
        }

        [Test]
        public async Task GetGroupForEditExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetGroupForEdit(22), "Невалидна група!");
        }

        [Test]
        public async Task GetGroupForEditNoExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            Assert.DoesNotThrowAsync(async () => await service.GetGroupForEdit(2));
        }

        [Test]
        public async Task EditGroupSameGroupTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupViewModel { GroupId = 2, Name = "Group2", Description = "Група 2", Number = "8888", Flag = true };
            (bool result, string error) = await service.EditGroup(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма направени промени по групата!");

            var groups = await service.GetGroups();
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Name, model.Name);
        }

        [Test]
        public async Task EditGroupSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupViewModel { GroupId = 2, Name = "Group22", Description = "Група 22", Number = "888888", Flag = true };
            (bool result, string error) = await service.EditGroup(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var groups = await service.GetGroups();
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Name, model.Name);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Description, model.Description);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Number, model.Number);
            Assert.AreEqual(groups.FirstOrDefault(f => f.Id == 2).Flag, model.Flag);
        }

        [Test]
        public async Task EditGroupErrorTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupViewModel { GroupId = 22, Name = "Group2", Description = "Група 2", Number = "8888", Flag = true };
            (bool result, string error) = await service.EditGroup(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task GetGroupNameSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var name = "Група 2";
            var groupName = await service.GetGroupName(2);

            Assert.AreEqual(groupName, name);
        }

        [Test]
        public async Task GetGroupNameExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetGroupName(22), "Няма група с Id 22!");
        }

        [Test]
        public async Task GetGroupNameNoExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            Assert.DoesNotThrowAsync(async () => await service.GetGroupName(2));
        }

        [Test]
        public async Task GetGroupFlagSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var flag = true;
            var groupFlag = await service.GetGroupFlag(2);

            Assert.AreEqual(groupFlag, flag);
        }

        [Test]
        public async Task GetGroupFlagNullTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            bool? flag = null;
            var groupFlag = await service.GetGroupFlag(22);

            Assert.AreEqual(groupFlag, flag);
        }

        [Test]
        public async Task GetObjectsSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 1, ObjectId = 1, ObjectName = "Пешо", ObjectType = 2, Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", IsSelected = true };
            var objects = await service.GetObjects(1);

            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).ObjectId, model.ObjectId);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).GroupId, model.GroupId);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).ObjectName, model.ObjectName);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).ObjectType, model.ObjectType);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).Phone1, model.Phone1);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).Phone2, model.Phone2);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).Phone3, model.Phone3);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).Phone4, model.Phone4);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 1).IsSelected, model.IsSelected);
        }

        [Test]
        public async Task GetObjectsSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 1, ObjectId = 2, ObjectName = "БПС", ObjectType = 1, Phone1 = "8888", IsSelected = false };
            var objects = await service.GetObjects(1);

            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 2).ObjectId, model.ObjectId);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 2).GroupId, model.GroupId);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 2).ObjectName, model.ObjectName);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 2).ObjectType, model.ObjectType);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 2).Phone1, model.Phone1);
            Assert.AreEqual(objects.FirstOrDefault(f => f.ObjectId == 2).IsSelected, model.IsSelected);
        }

        [Test]
        public async Task GetObjectsCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var objects = await service.GetObjects(1);
            Assert.AreEqual(objects.Count(), 2);

            var objects2 = await service.GetObjects(2);
            Assert.AreEqual(objects2.Count(), 2);
        }

        [Test]
        public async Task EditGroupObjectsSameObjectsTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 1, ObjectIds = new List<int>() { 1 } };
            (bool result, string error) = await service.EditGroupObjects(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Обектите в Група 1 са същите като предишните!");

            var objects = await service.GetObjects(1);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 1);
        }

        [Test]
        public async Task EditGroupObjects1Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 1, ObjectIds = new List<int>() };
            (bool result, string error) = await service.EditGroupObjects(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var objects = await service.GetObjects(1);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task EditGroupObjects2Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 3, ObjectIds = new List<int>() };
            (bool result, string error) = await service.EditGroupObjects(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма редактирани обекти в Група 3!");

            var objects = await service.GetObjects(3);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task EditGroupObjects3Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 3, ObjectIds = new List<int>() { 1, 2 } };
            (bool result, string error) = await service.EditGroupObjects(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var objects = await service.GetObjects(3);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 2);
        }

        [Test]
        public async Task EditGroupObjects4Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 1, ObjectIds = new List<int>() { 1, 2 } };
            (bool result, string error) = await service.EditGroupObjects(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var objects = await service.GetObjects(1);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 2);
        }

        [Test]
        public async Task EditGroupObjectsErrorTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupObjectsViewModel { GroupId = 11, ObjectIds = new List<int>() { 1, 2 } };
            (bool result, string error) = await service.EditGroupObjects(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task ClearGroupObjectsSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            (bool result, string error) = await service.ClearGroupObjects(1);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var objects = await service.GetObjects(1);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task ClearGroupObjectsNoObjectsTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            (bool result, string error) = await service.ClearGroupObjects(3);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма обекти в Група 3!");

            var objects = await service.GetObjects(3);
            Assert.AreEqual(objects.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task ClearGroupObjectsErrorTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            (bool result, string error) = await service.ClearGroupObjects(11);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task GetUsersSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 1, UserId = 1, UserName = "pesho", FullName = "Пешо", UserDescription = "Пешака", IsSelected = true };
            var users = await service.GetUsers(1);

            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 1).GroupId, model.GroupId);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 1).UserId, model.UserId);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 1).UserName, model.UserName);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 1).FullName, model.FullName);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 1).UserDescription, model.UserDescription);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 1).IsSelected, model.IsSelected);
        }

        [Test]
        public async Task GetUsersSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 1, UserId = 2, UserName = "pesho2", FullName = "Пешо", IsSelected = false };
            var users = await service.GetUsers(1);

            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 2).GroupId, model.GroupId);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 2).UserId, model.UserId);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 2).UserName, model.UserName);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 2).FullName, model.FullName);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 2).UserDescription, model.UserDescription);
            Assert.AreEqual(users.FirstOrDefault(f => f.UserId == 2).IsSelected, model.IsSelected);
        }

        [Test]
        public async Task GetUsersCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var users = await service.GetUsers(1);
            Assert.AreEqual(users.Count(), 2);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 1);

            var users2 = await service.GetUsers(2);
            Assert.AreEqual(users2.Count(), 2);
            Assert.AreEqual(users2.Where(w => w.IsSelected == true).Count(), 1);

            var users3 = await service.GetUsers(3);
            Assert.AreEqual(users3.Count(), 2);
            Assert.AreEqual(users3.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task EditGroupUsersSameUsersTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 1, UserIds = new List<int>() { 1 } };
            (bool result, string error) = await service.EditGroupUsers(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Потребителите в Група 1 са същите като предишните!");

            var users = await service.GetUsers(1);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 1);
        }

        [Test]
        public async Task EditGroupUsers1Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 1, UserIds = new List<int>() };
            (bool result, string error) = await service.EditGroupUsers(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var users = await service.GetUsers(1);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task EditGroupUsers2Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 3, UserIds = new List<int>() };
            (bool result, string error) = await service.EditGroupUsers(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма редактирани потребители в Група 3!");

            var users = await service.GetUsers(3);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task EditGroupUsers3Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 3, UserIds = new List<int>() { 1, 2 } };
            (bool result, string error) = await service.EditGroupUsers(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var users = await service.GetUsers(3);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 2);
        }

        [Test]
        public async Task EditGroupUsers4Test()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 1, UserIds = new List<int>() { 1, 2 } };
            (bool result, string error) = await service.EditGroupUsers(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var users = await service.GetUsers(1);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 2);
        }

        [Test]
        public async Task EditGroupUsersErrorTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            var model = new EditGroupUsersViewModel { GroupId = 11, UserIds = new List<int>() { 1, 2 } };
            (bool result, string error) = await service.EditGroupUsers(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task ClearGroupUsersSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            (bool result, string error) = await service.ClearGroupUsers(1);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var users = await service.GetUsers(1);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task ClearGroupUsersNoUsersTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            (bool result, string error) = await service.ClearGroupUsers(3);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма потребители в Група 3!");

            var users = await service.GetUsers(3);
            Assert.AreEqual(users.Where(w => w.IsSelected == true).Count(), 0);
        }

        [Test]
        public async Task ClearGroupUsersErrorTest()
        {
            var service = serviceProvider.GetService<INotifyGroupService>();

            (bool result, string error) = await service.ClearGroupUsers(11);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

        private async Task SeedDbAsync(IApplicatioDbRepository repo)
        {
            var group1 = new NOTIFY_GROUP()
            {
                NG_ID = 1,
                NG_NAME = "Group1",
                NG_DESCRIPTION = "Група 1",
                NG_NUMBER = "8888",
                NG_MOD_FLAG = false
            };

            var group2 = new NOTIFY_GROUP()
            {
                NG_ID = 2,
                NG_NAME = "Group2",
                NG_DESCRIPTION = "Група 2",
                NG_NUMBER = "8888",
                NG_MOD_FLAG = true
            };

            var group3 = new NOTIFY_GROUP()
            {
                NG_ID = 3,
                NG_NAME = "Group3",
                NG_DESCRIPTION = "Група 3",
                NG_NUMBER = "8888",
                NG_MOD_FLAG = true
            };

            var obj1 = new NOTIFY_OBJECT()
            {
                NO_ID = 1,
                NO_NAME = "Пешо",
                NO_INT_PHONE = "1234",
                NP_MOB_PHONE = "4321",
                NP_EXT_PHONE2 = "5678",
                NP_EXT_PHONE1 = "8765",
                NO_TYPE = 2,
                NG_NPS = new List<NG_NP>() { new NG_NP() { NGNP_ID = 1, NG_ID = 1, NO_ID = 1 }, new NG_NP() { NGNP_ID = 2, NG_ID = 2, NO_ID = 1 } }
            };

            var obj2 = new NOTIFY_OBJECT()
            {
                NO_ID = 2,
                NO_NAME = "БПС",
                NO_INT_PHONE = "8888",
                NO_TYPE = 1
            };

            var user1 = new AUTH_USER()
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
                USR_DESC = "Пешака",
                NG_USRS = new List<NG_USR>() { new NG_USR() { NG_ID = 1, USR_ID = 1 }, new NG_USR() { NG_ID = 2, USR_ID = 1 } }
            };

            var user2 = new AUTH_USER()
            {
                Id = 2,
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
            await repo.AddAsync(group3);
            await repo.AddAsync(obj1);
            await repo.AddAsync(obj2);
            await repo.AddAsync(user1);
            await repo.AddAsync(user2);
            await repo.SaveChangesAsync();
        }
    }
}