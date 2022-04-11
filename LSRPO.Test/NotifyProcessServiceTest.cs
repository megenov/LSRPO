using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyProcess;
using LSRPO.Core.Services;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LSRPO.Test
{
    public class NotifyProcessServiceTest
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
                .AddSingleton<INotifyProcessService, NotifyProcessService>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<IApplicatioDbRepository>();
            await SeedDbAsync(repo);
        }

        [Test]
        public async Task GetProcessTypesSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new ProcessTypeListViewModel { Id = 1, Description = "Тест 1" };
            var types = await service.GetProcessTypes();

            Assert.AreEqual(types.FirstOrDefault(f => f.Id == 1).Id, model.Id);
            Assert.AreEqual(types.FirstOrDefault(f => f.Id == 1).Description, model.Description);
        }

        [Test]
        public async Task GetProcessTypesSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new ProcessTypeListViewModel { Id = 2, Description = "Тест 2" };
            var types = await service.GetProcessTypes();

            Assert.AreEqual(types.FirstOrDefault(f => f.Id == 2).Id, model.Id);
            Assert.AreEqual(types.FirstOrDefault(f => f.Id == 2).Description, model.Description);
        }

        [Test]
        public async Task GetProcessTypesCountTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var types = await service.GetProcessTypes();

            Assert.AreEqual(types.Count(), 3);
        }

        [Test]
        public async Task AddProcessTypeSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new AddProcessTypeViewModel { Description = "Тест 4" };
            (bool result, string error) = await service.AddProcessType(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var processTypes = await service.GetProcessTypes();
            Assert.AreEqual(processTypes.Count(), 4);
        }

        [Test]
        public async Task AddProcessTypeSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new AddProcessTypeViewModel { Description = "Тест 4" };
            (bool result, string error) = await service.AddProcessType(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var processTypes = await service.GetProcessTypes();
            Assert.AreEqual(processTypes.FirstOrDefault(f => f.Id == 4).Description, model.Description);
        }

        [Test]
        public async Task AddProcessTypeErrorTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            (bool result, string error) = await service.AddProcessType(null);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");

            var processTypes = await service.GetProcessTypes();
            Assert.AreEqual(processTypes.Count(), 3);
        }

        [Test]
        public async Task GetProcessTypeForEditSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var processType = new EditProcessTypeViewModel { ProcessTypeId = 1, Description = "Тест 1" };
            var model = await service.GetProcessTypeForEdit(1);

            Assert.AreEqual(processType.ProcessTypeId, model.ProcessTypeId);
            Assert.AreEqual(processType.Description, model.Description);
        }

        [Test]
        public async Task GetProcessTypeForEditExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetProcessTypeForEdit(11), "Невалиден тип процес!");
        }

        [Test]
        public async Task GetProcessTypeForEditNoExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            Assert.DoesNotThrowAsync(async () => await service.GetProcessTypeForEdit(3));
        }

        [Test]
        public async Task EditProcessTypeSameProcessTypeTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new EditProcessTypeViewModel { ProcessTypeId = 1, Description = "Тест 1" };
            (bool result, string error) = await service.EditProcessType(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма направени промени по този тип процес!");

            var processTypes = await service.GetProcessTypes();
            Assert.AreEqual(processTypes.FirstOrDefault(f => f.Id == 1).Description, model.Description);
        }

        [Test]
        public async Task EditProcessTypeSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new EditProcessTypeViewModel { ProcessTypeId = 1, Description = "Тест 11" };
            (bool result, string error) = await service.EditProcessType(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var processTypes = await service.GetProcessTypes();
            Assert.AreEqual(processTypes.FirstOrDefault(f => f.Id == 1).Description, model.Description);
        }

        [Test]
        public async Task EditProcessTypeErrorTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new EditProcessTypeViewModel { ProcessTypeId = 11, Description = "Тест 11" };
            (bool result, string error) = await service.EditProcessType(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task GetProcessSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new ProcessListViewModel { ProcessId = 1, GroupName = "Group1", UserName = "Пешо", PultName = "СТК", ProccesTypeName = "Тест 1", StartDate = "N/A", EndDate = "N/A", FlagName = "Тест", FlagId = 1 };

            var process = await service.GetProcess();

            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).ProcessId, model.ProcessId);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).GroupName, model.GroupName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).UserName, model.UserName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).PultName, model.PultName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).ProccesTypeName, model.ProccesTypeName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).StartDate, model.StartDate);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).EndDate, model.EndDate);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).FlagName, model.FlagName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 1).FlagId, model.FlagId);
        }

        [Test]
        public async Task GetProcessSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var model = new ProcessListViewModel { ProcessId = 2, GroupName = null, UserName = null, PultName = null, ProccesTypeName = "N/A", StartDate = "N/A", EndDate = "N/A", FlagName = null, FlagId = 0 };
            var process = await service.GetProcess();

            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).ProcessId, model.ProcessId);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).GroupName, model.GroupName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).UserName, model.UserName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).PultName, model.PultName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).ProccesTypeName, model.ProccesTypeName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).StartDate, model.StartDate);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).EndDate, model.EndDate);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).FlagName, model.FlagName);
            Assert.AreEqual(process.FirstOrDefault(f => f.ProcessId == 2).FlagId, model.FlagId);
        }

        [Test]
        public async Task GetProcessCountTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            var process = await service.GetProcess();

            Assert.AreEqual(process.Count(), 3);
        }

        [Test]
        public async Task EndProcessSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            (bool result, string error) = await service.EndProcess(3);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task EndProcessEndTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            (bool result, string error) = await service.EndProcess(1);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Процесът вече е приключил!");
        }

        [Test]
        public async Task EndProcessErrorTest()
        {
            var service = serviceProvider.GetService<INotifyProcessService>();

            (bool result, string error) = await service.EndProcess(11);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма такъв процес!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

        private async Task SeedDbAsync(IApplicatioDbRepository repo)
        {
            var type1 = new NPR_TYPE()
            {
                NTP_ID = 1,
                NTP_DESCRIPTION = "Тест 1"
            };

            var type2 = new NPR_TYPE()
            {
                NTP_ID = 2,
                NTP_DESCRIPTION = "Тест 2"
            };

            var type3 = new NPR_TYPE()
            {
                NTP_ID = 3,
                NTP_DESCRIPTION = "Тест 3"
            };

            var process1 = new NOT_PROCESS()
            {
                NPR_ID = 1,
                NPR_FLAG = "1",
                NG_ID = 1,
                USR_ID = 1,
                NTP_ID = 1,
                PULT_NUMBER = "8888"
            };

            var process2 = new NOT_PROCESS()
            {
                NPR_ID = 2,
                NPR_FLAG = "2",
                NG_ID = 2,
                USR_ID = 2,
                PULT_NUMBER = "888888"
            };

            var process3 = new NOT_PROCESS()
            {
                NPR_ID = 3,
                NPR_FLAG = "3",
                NG_ID = 3,
                USR_ID = 3,
                NTP_ID = 3,
                PULT_NUMBER = "88888888"
            };

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
                IMAGE_URL = "user.png"
            };

            var group = new NOTIFY_GROUP()
            {
                NG_ID = 1,
                NG_NAME = "Group1",
                NG_DESCRIPTION = "Група 1",
                NG_NUMBER = "8888",
                NG_MOD_FLAG = false
            };

            var pult = new NOT_PULT()
            {
                PULT_ID = 1,
                PULT_NAME = "СТК",
                PULT_DESCR = "СТК",
                PULT_NUMBER = "8888",
                PULT_IP = "8.8.8.8"
            };

            var flag = new NOT_PROCES_STATE()
            {
                ST_ID = 1,
                ST_DESC = "Тест"
            };

            await repo.AddAsync(type1);
            await repo.AddAsync(type2);
            await repo.AddAsync(type3);
            await repo.AddAsync(process1);
            await repo.AddAsync(process2);
            await repo.AddAsync(process3);
            await repo.AddAsync(user);
            await repo.AddAsync(group);
            await repo.AddAsync(pult);
            await repo.AddAsync(flag);
            await repo.SaveChangesAsync();
        }
    }
}