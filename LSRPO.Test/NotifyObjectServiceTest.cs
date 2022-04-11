using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyObject;
using LSRPO.Core.Services;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSRPO.Test
{
    public class NotifyObjectServiceTest
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
                .AddSingleton<INotifyObjectService, NotifyObjectService>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<IApplicatioDbRepository>();
            await SeedDbAsync(repo);
        }

        [Test]
        public async Task GetObjectsSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new NotifyObjectListViewModel { Id = 1, Name = "Пешо", Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", TypeDes = "Лице", TypeId = 2 };
            var objects = await service.GetObjects();

            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Id, model.Id);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Name, model.Name);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Phone1, model.Phone1);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Phone2, model.Phone2);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Phone3, model.Phone3);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Phone4, model.Phone4);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).TypeDes, model.TypeDes);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).TypeId, model.TypeId);
        }

        [Test]
        public async Task GetObjectsSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new NotifyObjectListViewModel { Id = 2, Name = "БПС", Phone1 = "8888", TypeDes = "Оповестителен пункт", TypeId = 1 };
            var objects = await service.GetObjects();

            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Id, model.Id);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Name, model.Name);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone1, model.Phone1);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone2, model.Phone2);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone3, model.Phone3);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone4, model.Phone4);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).TypeDes, model.TypeDes);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).TypeId, model.TypeId);
        }

        [Test]
        public async Task GetObjectsCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var objects = await service.GetObjects();

            Assert.AreEqual(objects.Count(), 2);
        }

        [Test]
        public async Task GetTypesSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new SelectListItem { Text = "Оповестителен пункт", Value = "1" };
            var types = await service.GetTypes();

            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "1").Text, model.Text);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "1").Value, model.Value);
        }

        [Test]
        public async Task GetTypesSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new SelectListItem { Text = "Лице", Value = "2" };
            var types = await service.GetTypes();

            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "2").Text, model.Text);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "2").Value, model.Value);
        }

        [Test]
        public async Task GetTypesCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var types = await service.GetTypes();

            Assert.AreEqual(types.Count(), 2);
        }

        [Test]
        public async Task GetOperatorTypesSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new SelectListItem { Text = "Лице", Value = "2" };
            var types = await service.GetOperatorTypes();

            Assert.AreEqual(types.FirstOrDefault().Text, model.Text);
            Assert.AreEqual(types.FirstOrDefault().Value, model.Value);
        }

        [Test]
        public async Task GetOperatorTypesCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var types = await service.GetOperatorTypes();

            Assert.AreEqual(types.Count(), 1);
        }

        [Test]
        public async Task AddObjectSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new AddObjectViewModel { Name = "Гошо", Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", TypeId = 2 };
            (bool result, string error) = await service.AddObject(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var obj = await service.GetObjects();
            Assert.AreEqual(obj.Count(), 3);
        }

        [Test]
        public async Task AddObjectSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new AddObjectViewModel { Name = "Гошо", Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", TypeId = 2 };
            (bool result, string error) = await service.AddObject(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var obj = await service.GetObjects();
            Assert.AreEqual(obj.FirstOrDefault(f => f.Id == 3).Name, model.Name);
            Assert.AreEqual(obj.FirstOrDefault(f => f.Id == 3).Phone1, model.Phone1);
            Assert.AreEqual(obj.FirstOrDefault(f => f.Id == 3).Phone2, model.Phone2);
            Assert.AreEqual(obj.FirstOrDefault(f => f.Id == 3).Phone3, model.Phone3);
            Assert.AreEqual(obj.FirstOrDefault(f => f.Id == 3).Phone4, model.Phone4);
            Assert.AreEqual(obj.FirstOrDefault(f => f.Id == 3).TypeId, model.TypeId);
        }

        [Test]
        public async Task AddObjectErrorTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            (bool result, string error) = await service.AddObject(null);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");

            var obj = await service.GetObjects();
            Assert.AreEqual(obj.Count(), 2);
        }

        [Test]
        public async Task GetObjectForEditSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var obj = new NotifyObjectListViewModel { Id = 1, Name = "Пешо", Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", TypeDes = "Лице", TypeId = 2 };
            var type1 = new SelectListItem { Text = "Лице", Value = "2", Selected = true };
            var type2 = new SelectListItem { Text = "Оповестителен пункт", Value = "1", Selected = false };
            (EditObjectViewModel notifyObject, IEnumerable<SelectListItem> types) = await service.GetObjectForEdit(1);

            Assert.AreEqual(notifyObject.ObjectId, obj.Id);
            Assert.AreEqual(notifyObject.Name, obj.Name);
            Assert.AreEqual(notifyObject.Phone1, obj.Phone1);
            Assert.AreEqual(notifyObject.Phone2, obj.Phone2);
            Assert.AreEqual(notifyObject.Phone3, obj.Phone3);
            Assert.AreEqual(notifyObject.Phone4, obj.Phone4);
            Assert.AreEqual(notifyObject.TypeId, obj.TypeId);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "1").Text, type2.Text);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "1").Value, type2.Value);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "1").Selected, type2.Selected);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "2").Text, type1.Text);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "2").Value, type1.Value);
            Assert.AreEqual(types.FirstOrDefault(f => f.Value == "2").Selected, type1.Selected);
        }

        [Test]
        public async Task GetObjectForEditExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetObjectForEdit(11), "Невалиден обект!");
        }

        [Test]
        public async Task GetObjectForEditNoExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            Assert.DoesNotThrowAsync(async () => await service.GetObjectForEdit(1));
        }

        [Test]
        public async Task EditObjectSameObjectTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditObjectViewModel { ObjectId = 1, Name = "Пешо", Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", TypeId = 2 };
            (bool result, string error) = await service.EditObject(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма направени промени по обекта!");

            var objects = await service.GetObjects();
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 1).Name, model.Name);
        }

        [Test]
        public async Task EditObjectSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditObjectViewModel { ObjectId = 2, Name = "Гошо", Phone1 = "123", Phone2 = "321", Phone3 = "456", Phone4 = "654", TypeId = 2 };
            (bool result, string error) = await service.EditObject(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var objects = await service.GetObjects();
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Name, model.Name);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone1, model.Phone1);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone2, model.Phone2);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone3, model.Phone3);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).Phone4, model.Phone4);
            Assert.AreEqual(objects.FirstOrDefault(f => f.Id == 2).TypeId, model.TypeId);
        }

        [Test]
        public async Task EditObjectErrorTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditObjectViewModel { ObjectId = 11, Name = "Пешо", Phone1 = "1234", Phone2 = "4321", Phone3 = "5678", Phone4 = "8765", TypeId = 2 };
            (bool result, string error) = await service.EditObject(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");
        }

        [Test]
        public async Task DeleteObjectSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            (bool result, string error) = await service.DeleteObject(1);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var objects = await service.GetObjects();
            Assert.AreEqual(objects.Count(), 1);
        }

        [Test]
        public async Task DeleteObjectUnknownObjectTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            (bool result, string error) = await service.DeleteObject(11);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма такъв обект!");

            var objects = await service.GetObjects();
            Assert.AreEqual(objects.Count(), 2);
        }

        [Test]
        public async Task GetPultsSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new PultsViewModel { Id = 1, Name = "СТК", Description = "СТК", Number = "8888", Ip = "8.8.8.8" };
            var pults = await service.GetPults();

            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Id, model.Id);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Name, model.Name);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Description, model.Description);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Number, model.Number);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Ip, model.Ip);
        }

        [Test]
        public async Task GetPultsCountSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var pults = await service.GetPults();

            Assert.AreEqual(pults.Count(), 1);
        }

        [Test]
        public async Task AddPultSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new AddPultViewModel { Name = "ЦУА", Description = "ЦУА", Number = "8888", Ip = "8.8.8.8" };
            (bool result, string error) = await service.AddPult(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.Count(), 2);
        }

        [Test]
        public async Task AddPultSuccess2Test()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new AddPultViewModel { Name = "ЦУА", Description = "ЦУА", Number = "8888", Ip = "8.8.8.8" };
            (bool result, string error) = await service.AddPult(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 2).Name, model.Name);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 2).Description, model.Description);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 2).Number, model.Number);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 2).Ip, model.Ip);
        }

        [Test]
        public async Task AddPultErrorTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            (bool result, string error) = await service.AddPult(null);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Възникна грешка!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.Count(), 1);
        }

        [Test]
        public async Task DeletePultSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            (bool result, string error) = await service.DeletePult(1);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.Count(), 0);
        }

        [Test]
        public async Task DeletePultUnknownPultTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            (bool result, string error) = await service.DeletePult(11);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма такъв пулт!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.Count(), 1);
        }

        [Test]
        public async Task GetPultForEditSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditPultViewModel { PultId = 1, Name = "СТК", Description = "СТК", Number = "8888", Ip = "8.8.8.8" };
            var pult = await service.GetPultForEdit(1);

            Assert.AreEqual(model.PultId, pult.PultId);
            Assert.AreEqual(model.Name, pult.Name);
            Assert.AreEqual(model.Description, pult.Description);
            Assert.AreEqual(model.Number, pult.Number);
            Assert.AreEqual(model.Ip, pult.Ip);
        }

        [Test]
        public async Task GetPultForEditExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetPultForEdit(11), "Невалиден пулт!");
        }

        [Test]
        public async Task GetPultForEditNoExceptionTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            Assert.DoesNotThrowAsync(async () => await service.GetPultForEdit(1));
        }

        [Test]
        public async Task EditPultSamePultTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditPultViewModel { PultId = 1, Name = "СТК", Description = "СТК", Number = "8888", Ip = "8.8.8.8" };
            (bool result, string error) = await service.EditPult(model);

            Assert.AreEqual(result, false);
            Assert.AreEqual(error, "Няма направени промени по пулта!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Name, model.Name);
        }

        [Test]
        public async Task EditPultSuccessTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditPultViewModel { PultId = 1, Name = "ЦУА", Description = "ЦУА", Number = "8888", Ip = "8.8.8.8" };
            (bool result, string error) = await service.EditPult(model);

            Assert.AreEqual(result, true);
            Assert.AreEqual(error, "Възникна грешка!");

            var pults = await service.GetPults();
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Name, model.Name);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Description, model.Description);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Number, model.Number);
            Assert.AreEqual(pults.FirstOrDefault(f => f.Id == 1).Ip, model.Ip);
        }

        [Test]
        public async Task EditPultErrorTest()
        {
            var service = serviceProvider.GetService<INotifyObjectService>();

            var model = new EditPultViewModel { PultId = 11, Name = "ЦУА", Description = "ЦУА", Number = "8888", Ip = "8.8.8.8" };
            (bool result, string error) = await service.EditPult(model);

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
            var obj1 = new NOTIFY_OBJECT()
            {
                NO_ID = 1,
                NO_NAME = "Пешо",
                NO_INT_PHONE = "1234",
                NP_MOB_PHONE = "4321",
                NP_EXT_PHONE2 = "5678",
                NP_EXT_PHONE1 = "8765",
                NO_TYPE = 2
            };

            var obj2 = new NOTIFY_OBJECT()
            {
                NO_ID = 2,
                NO_NAME = "БПС",
                NO_INT_PHONE = "8888",
                NO_TYPE = 1
            };

            var type1 = new NO_TYPE() { NO_TYPE_ID = 1, NO_TYPE_DESCRIPTION = "Оповестителен пункт" };
            var type2 = new NO_TYPE() { NO_TYPE_ID = 2, NO_TYPE_DESCRIPTION = "Лице" };

            var pult = new NOT_PULT() { PULT_ID = 1, PULT_NAME = "СТК", PULT_DESCR = "СТК", PULT_NUMBER = "8888", PULT_IP = "8.8.8.8" };

            await repo.AddAsync(obj1);
            await repo.AddAsync(obj2);
            await repo.AddAsync(type1);
            await repo.AddAsync(type2);
            await repo.AddAsync(pult);
            await repo.SaveChangesAsync();
        }
    }
}