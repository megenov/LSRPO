using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyStatus;
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
    public class NotifyStatusServiceTest
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
                .AddSingleton<INotifyStatusService, NotifyStatusService>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<IApplicatioDbRepository>();
            await SeedDbAsync(repo);
        }

        [Test]
        public async Task GetProcessAllSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            var model = new ProcessListAllViewModel { ProcessId = 1, GroupName = "Group1", UserName = "Пешо", PultName = "СТК", ProccesTypeName = "Тест 1", StartDate = "N/A", EndDate = "N/A", FlagName = "Тест", FlagId = 1 };

            var process = await service.GetProcessAll();

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
        public async Task GetProcessAllSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            var model = new ProcessListAllViewModel { ProcessId = 2, GroupName = null, UserName = null, PultName = null, ProccesTypeName = "N/A", StartDate = "N/A", EndDate = "N/A", FlagName = null, FlagId = 0 };
            var process = await service.GetProcessAll();

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
        public async Task GetProcessAllCountTest()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            var process = await service.GetProcessAll();

            Assert.AreEqual(process.Count(), 3);
        }

        [Test]
        public async Task GetProcessDetailsSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            var model = new ProcessDetailsViewModel 
            { 
                StatId = 1, 
                StatFlag = "Статус", 
                ObjectName = "Пешо", 
                Phone1 = "1234", 
                Phone1Flag = "Статус на телефон",
                Phone2 = "4321",
                Phone2Flag = "Статус на телефон",
                Phone3 = "5678",
                Phone3Flag = "Статус на телефон",
                Phone4 = "8765",
                Phone4Flag = "Статус на телефон",
                FinalFlag = "Крайно състояние"
            };

            var process = await service.GetProcessDetails(1);

            Assert.AreEqual(process.FirstOrDefault().StatId, model.StatId);
            Assert.AreEqual(process.FirstOrDefault().StatFlag, model.StatFlag);
            Assert.AreEqual(process.FirstOrDefault().ObjectName, model.ObjectName);
            Assert.AreEqual(process.FirstOrDefault().Phone1, model.Phone1);
            Assert.AreEqual(process.FirstOrDefault().Phone1Flag, model.Phone1Flag);
            Assert.AreEqual(process.FirstOrDefault().Phone2, model.Phone2);
            Assert.AreEqual(process.FirstOrDefault().Phone2Flag, model.Phone2Flag);
            Assert.AreEqual(process.FirstOrDefault().Phone3, model.Phone3);
            Assert.AreEqual(process.FirstOrDefault().Phone3Flag, model.Phone3Flag);
            Assert.AreEqual(process.FirstOrDefault().Phone4, model.Phone4);
            Assert.AreEqual(process.FirstOrDefault().Phone4Flag, model.Phone4Flag);
            Assert.AreEqual(process.FirstOrDefault().FinalFlag, model.FinalFlag);
            Assert.AreEqual(process.Count(), 1);
        }

        [Test]
        public async Task GetProcessDetailsNullTest()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            var process = await service.GetProcessDetails(2);

            Assert.AreEqual(process.Count(), 0);
        }

        [Test]
        public async Task GetProcessDetailsExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetProcessDetails(22), "Невалиден процес!");
        }

        [Test]
        public async Task GetProcessDetailsNoExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyStatusService>();

            Assert.DoesNotThrowAsync(async () => await service.GetProcessDetails(1));
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

            var phoneState = new NOT_STATUS_PHONE_STATE()
            {
                ST_ID = 1,
                ST_DESC = "Статус на телефон"
            };

            var finalState = new NOT_STATUS_STATE()
            {
                ST_ID = 1,
                ST_DESC = "Крайно състояние"
            };

            var statusState = new STATUS_STATE()
            {
                ST_ID = 1,
                ST_DESC = "Статус"
            };

            var obj = new NOTIFY_OBJECT()
            {
                NO_ID = 1,
                NO_NAME = "Пешо",
                NO_INT_PHONE = "1234",
                NP_MOB_PHONE = "4321",
                NP_EXT_PHONE2 = "5678",
                NP_EXT_PHONE1 = "8765",
                NO_TYPE = 2
            };

            var status1 = new NOT_STATUS()
            {
                STAT_ID = 1,
                NPR_ID = 1,
                STAT_FLAG = 1,
                NO_ID = 1,
                STAT_INT_PHONE = "1234",
                STAT_INT_FLAG = 1,
                STAT_MOB_PHONE = "4321",
                STAT_MOB_FLAG = 1,
                STAT_PHONE2 = "5678",
                STAT_PH2_FLAG = 1,
                STAT_PHONE1 = "8765",
                STAT_PH1_FLAG = 1,
                STAT_NOTIFICATION = 1
            };

            var status2 = new NOT_STATUS()
            {
                STAT_ID = 2
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
            await repo.AddAsync(phoneState);
            await repo.AddAsync(finalState);
            await repo.AddAsync(statusState);
            await repo.AddAsync(obj);
            await repo.AddAsync(status1);
            await repo.AddAsync(status2);
            await repo.SaveChangesAsync();
        }
    }
}