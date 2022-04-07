using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Core.Services.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LSRPO.Test
{
    public class Tests
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
            var userViewModel = new UserProfileViewModel { Id = 1, UserName = "pesho", FullName = "Пешо", Image = "user.png" };

            var service = serviceProvider.GetService<IUserService>();

            var asd = await service.GetUserForProfileEdit(1);

            Assert.That(asd.UserName, Is.EqualTo(userViewModel.UserName));
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

        private async Task SeedDbAsync(IApplicatioDbRepository repo)
        {
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

            await repo.AddAsync(user);
            await repo.SaveChangesAsync();
        }
    }
}