using LSRPO.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace LSRPO.Infrastructure.Data.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            InitialUsersSeed(services);

            return app;
        }

        private static void InitialUsersSeed(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<AUTH_USER>>();
            var roleManager = services.GetRequiredService<RoleManager<AUTH_ROLE>>();

            const string Administrator = nameof(Administrator);
            const string Operator = nameof(Operator);
            const string FullName = nameof(FullName);
            const string ImageUrl = nameof(ImageUrl);
            const string Password = "0000";

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(Administrator) || await roleManager.RoleExistsAsync(Operator) || userManager.Users.Any())
                    {
                        return;
                    }

                    var roleAdmin = new AUTH_ROLE { Name = Administrator };
                    var roleOperator = new AUTH_ROLE { Name = Operator };

                    await roleManager.CreateAsync(roleAdmin);
                    await roleManager.CreateAsync(roleOperator);

                    foreach (var adminUser in adminUsers)
                    {
                        await userManager.CreateAsync(adminUser, Password);
                        await userManager.AddToRoleAsync(adminUser, Administrator);
                        await userManager.AddClaimAsync(adminUser, new Claim(FullName, adminUser.USR_FULLNAME));
                        await userManager.AddClaimAsync(adminUser, new Claim(ImageUrl, adminUser.IMAGE_URL ?? "user.png"));
                    }

                    foreach (var operatorUser in operatorUsers)
                    {
                        await userManager.CreateAsync(operatorUser, Password);
                        await userManager.AddToRoleAsync(operatorUser, Operator);
                        await userManager.AddClaimAsync(operatorUser, new Claim(FullName, operatorUser.USR_FULLNAME));
                        await userManager.AddClaimAsync(operatorUser, new Claim(ImageUrl, operatorUser.IMAGE_URL ?? "user.png"));
                    }

                    foreach (var otherUser in otherUsers)
                    {
                        await userManager.CreateAsync(otherUser, Password);
                        await userManager.AddClaimAsync(otherUser, new Claim(FullName, otherUser.USR_FULLNAME));
                        await userManager.AddClaimAsync(otherUser, new Claim(ImageUrl, otherUser.IMAGE_URL ?? "user.png"));
                    }
                })
                .GetAwaiter()
                .GetResult();
        }

        private static List<AUTH_USER> adminUsers = new List<AUTH_USER>()
        {
            new AUTH_USER
            {
                UserName = "admin",
                Email = "admin@stk.local",
                USR_FULLNAME = "Администратор",
                USR_DESC = "Админ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "megenov",
                Email = "megenov@stk.local",
                USR_FULLNAME = "Мирослав Евгениев Генов",
                USR_DESC = "Инженер ЦКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "nviliev",
                Email = "nviliev@stk.local",
                USR_FULLNAME = "Никола Вилиев Христов",
                USR_DESC = "Експерт ТКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "elevgenieva",
                Email = "elevgenieva@stk.local",
                USR_FULLNAME = "Елица Любенова Евгениева",
                USR_DESC = "Р-л лаборатория ЦКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "yanyovski",
                Email = "yanyovski@stk.local",
                USR_FULLNAME = "Владислав Цветанов Яньовски",
                USR_DESC = "Инженер ЦКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "ivivanov",
                Email = "ivivanov@stk.local",
                USR_FULLNAME = "Иван Валентинов Иванов",
                USR_DESC = "Инженер ЦКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "ahangelova",
                Email = "ahangelova@stk.local",
                USR_FULLNAME = "Анита Христова Велкова",
                USR_DESC = "Инженер ЦКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "svdobrinova",
                Email = "svdobrinova@stk.local",
                USR_FULLNAME = "Соня Венециева Добринова",
                USR_DESC = "Р-л група ЕСТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "kbvelichkov",
                Email = "kbvelichkov@stk.local",
                USR_FULLNAME = "Красимир Борисов Величков",
                USR_DESC = "Р-л сектор ТКС",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "adzlatanov",
                Email = "adzlatanov@stk.local",
                USR_FULLNAME = "Александър Димитров Златанов",
                USR_DESC = "Р-л управление ИиКТ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            }
        };

        private static List<AUTH_USER> operatorUsers = new List<AUTH_USER>()
        {
            new AUTH_USER
            {
                UserName = "tsvasileva",
                Email = "tsvasileva@stk.local",
                USR_FULLNAME = "Татяна Светлозарова Василева",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "dtparvolova",
                Email = "dtparvolova@stk.local",
                USR_FULLNAME = "Деница Тодорова Балиева",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "didoychinov",
                Email = "didoychinov@stk.local",
                USR_FULLNAME = "Димитър Илиев Дойчинов",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "eibanucova",
                Email = "eibanucova@stk.local",
                USR_FULLNAME = "Елиза Илиянова Бануцова",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "iyilieva",
                Email = "iyilieva@stk.local",
                USR_FULLNAME = "Илиана Йорданова Илиева",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "tknaneva",
                Email = "tknaneva@stk.local",
                USR_FULLNAME = "Тодорка Колева Нанева",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            },

            new AUTH_USER
            {
                UserName = "cgdimitrova",
                Email = "cgdimitrova@stk.local",
                USR_FULLNAME = "Цветомира Георгиева Димитрова",
                USR_DESC = "Оператор СТК",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png"
            }
        };

        private static List<AUTH_USER> otherUsers = new List<AUTH_USER>()
        {
            new AUTH_USER
            {
                UserName = "vnprodanov",
                Email = "vnprodanov@stk.local",
                USR_FULLNAME = "Владимир Николов Проданов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 18, USR_PIN = "179528" }
            },

           new AUTH_USER
            {
                UserName = "gpkostov",
                Email = "gpkostov@stk.local",
                USR_FULLNAME = "Георги Петков Костов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 19,
                USR_PIN = "218479" }
            },

           new AUTH_USER
            {
                UserName = "isgenov",
                Email = "isgenov@stk.local",
                USR_FULLNAME = "Ивайло Спиридонов Генов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 20,
                USR_PIN = "759621" }
            },

           new AUTH_USER
            {
                UserName = "imivanov",
                Email = "imivanov@stk.local",
                USR_FULLNAME = "Иво Милчев Иванов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 21,
                USR_PIN = "150462" }
            },

           new AUTH_USER
            {
                UserName = "kfnikolov",
                Email = "kfnikolov@stk.local",
                USR_FULLNAME = "Калоян Филков Николов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 22,
                USR_PIN = "964801" }
            },

           new AUTH_USER
            {
                UserName = "kdkrumov",
                Email = "kdkrumov@stk.local",
                USR_FULLNAME = "Крум Димитров Крумов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 23,
                USR_PIN = "465237" }
            },

           new AUTH_USER
            {
                UserName = "nsiliev",
                Email = "nsiliev@stk.local",
                USR_FULLNAME = "Никифор Сашков Илиев",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 24,
                USR_PIN = "870165" }
            },

           new AUTH_USER
            {
                UserName = "yaiyordanov",
                Email = "yaiyordanov@stk.local",
                USR_FULLNAME = "Явор Иванов Йорданов",
                USR_DESC = "ГДАЕЦ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 25,
                USR_PIN = "968714" }
            },

           new AUTH_USER
            {
                UserName = "lgmladenov",
                Email = "lgmladenov@stk.local",
                USR_FULLNAME = "Лилиян Георгиев Младенов",
                USR_DESC = "ГТЕ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 26,
                USR_PIN = "935817" }
            },

           new AUTH_USER
            {
                UserName = "vsmiloshev",
                Email = "vsmiloshev@stk.local",
                USR_FULLNAME = "Валери Славчев Милошев",
                USR_DESC = "ГТЕ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 27,
                USR_PIN = "518263" }
            },

           new AUTH_USER
            {
                UserName = "evgalabov",
                Email = "evgalabov@stk.local",
                USR_FULLNAME = "Евгени Василев Гълъбов",
                USR_DESC = "Н-к о-л Инженеринг и анализи",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 28,
                USR_PIN = "924367" }
            },

           new AUTH_USER
            {
                UserName = "mekrastev",
                Email = "mekrastev@stk.local",
                USR_FULLNAME = "Милен Емилов Кръстев",
                USR_DESC = "Главен механик ИР",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 29,
                USR_PIN = "140359" }
            },

           new AUTH_USER
            {
                UserName = "ailashkov",
                Email = "ailashkov@stk.local",
                USR_FULLNAME = "Анатоли Иваилов Лашков",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 30,
                USR_PIN = "847563" }
            },

           new AUTH_USER
            {
                UserName = "bamedzhov",
                Email = "bamedzhov@stk.local",
                USR_FULLNAME = "Билян Асенов Меджов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 31,
                USR_PIN = "397418" }
            },

           new AUTH_USER
            {
                UserName = "bnnikolov",
                Email = "bnnikolov@stk.local",
                USR_FULLNAME = "Благой Николов Николов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 32,
                USR_PIN = "407659" }
            },

           new AUTH_USER
            {
                UserName = "btevstatiev",
                Email = "btevstatiev@stk.local",
                USR_FULLNAME = "Борис Тодоров Евстатиев",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 33,
                USR_PIN = "861230" }
            },

           new AUTH_USER
            {
                UserName = "boevgeniev",
                Email = "boevgeniev@stk.local",
                USR_FULLNAME = "Борислав Огнянов Евгениев",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 34,
                USR_PIN = "309842" }
            },

           new AUTH_USER
            {
                UserName = "igmladenov",
                Email = "igmladenov@stk.local",
                USR_FULLNAME = "Иван Георгиев Младенов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 35,
                USR_PIN = "519068" }
            },

           new AUTH_USER
            {
                UserName = "khnikolov",
                Email = "khnikolov@stk.local",
                USR_FULLNAME = "Красимир Христов Николов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 36,
                USR_PIN = "103698" }
            },

           new AUTH_USER
            {
                UserName = "mckostova",
                Email = "mckostova@stk.local",
                USR_FULLNAME = "Мая Цекова Костова",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 37,
                USR_PIN = "182704" }
            },

           new AUTH_USER
            {
                UserName = "mhhristov",
                Email = "mhhristov@stk.local",
                USR_FULLNAME = "Мирослав Христинов Христов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 38,
                USR_PIN = "218307" }
            },

           new AUTH_USER
            {
                UserName = "sasaykov",
                Email = "sasaykov@stk.local",
                USR_FULLNAME = "Светослав Атанасов Съйков",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 39,
                USR_PIN = "526480" }
            },

           new AUTH_USER
            {
                UserName = "svgoshev",
                Email = "svgoshev@stk.local",
                USR_FULLNAME = "Сергей Валериевич Гошев",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 40,
                USR_PIN = "803421" }
            },

           new AUTH_USER
            {
                UserName = "sgkalburov",
                Email = "sgkalburov@stk.local",
                USR_FULLNAME = "Станимир Георгиев Калбуров",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 41,
                USR_PIN = "450736" }
            },

           new AUTH_USER
            {
                UserName = "tpgrigorov",
                Email = "tpgrigorov@stk.local",
                USR_FULLNAME = "Тодор Петров Григоров",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 42,
                USR_PIN = "693241" }
            },

           new AUTH_USER
            {
                UserName = "tpopricov",
                Email = "tpopricov@stk.local",
                USR_FULLNAME = "Тодор Петров Оприцов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 43,
                USR_PIN = "610748" }
            },

           new AUTH_USER
            {
                UserName = "yueharlechanov",
                Email = "yueharlechanov@stk.local",
                USR_FULLNAME = "Юлиян Емилов Хърлечанов",
                USR_DESC = "ДАЕБ",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 44,
                USR_PIN = "280391" }
            },

           new AUTH_USER
            {
                UserName = "nhtomovski",
                Email = "nhtomovski@stk.local",
                USR_FULLNAME = "Николай Хараламбиев Томовски",
                USR_DESC = "Началник отдел Симулатор",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 45,
                USR_PIN = "683015" }
            },

           new AUTH_USER
            {
                UserName = "ikivanov",
                Email = "ikivanov@stk.local",
                USR_FULLNAME = "Иван Кирилов Иванов",
                USR_DESC = "РС СО",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 46,
                USR_PIN = "420968" }
            },

           new AUTH_USER
            {
                UserName = "spstankov",
                Email = "spstankov@stk.local",
                USR_FULLNAME = "Страхил Павлов Станков",
                USR_DESC = "Инструктор - оператор за ВВЕР 1000",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 47,
                USR_PIN = "578293" }
            },

           new AUTH_USER
            {
                UserName = "cpmiziya",
                Email = "cpmiziya@stk.local",
                USR_FULLNAME = "Цветан Петров Мизия",
                USR_DESC = "Община Мизия",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 48,
                USR_PIN = "823461" }
            },

           new AUTH_USER
            {
                UserName = "skmiziya",
                Email = "skmiziya@stk.local",
                USR_FULLNAME = "Стефан Каменовски Мизия",
                USR_DESC = "Община Мизия",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 49,
                USR_PIN = "206837" }
            },

           new AUTH_USER
            {
                UserName = "vbmiziya",
                Email = "vbmiziya@stk.local",
                USR_FULLNAME = "Валя Берчева Мизия",
                USR_DESC = "Община Мизия",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 50,
                USR_PIN = "456782" }
            },

           new AUTH_USER
            {
                UserName = "gkkozloduy",
                Email = "gkkozloduy@stk.local",
                USR_FULLNAME = "Георги Кирков Козлодуй",
                USR_DESC = "Община Козлодуй",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 51,
                USR_PIN = "745918" }
            },

           new AUTH_USER
            {
                UserName = "ivkozloduy",
                Email = "ivkozloduy@stk.local",
                USR_FULLNAME = "Иван Вачов Козлодуй",
                USR_DESC = "Община Козлодуй",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 52,
                USR_PIN = "384519" }
            },

           new AUTH_USER
            {
                UserName = "mnkozloduy",
                Email = "mnkozloduy@stk.local",
                USR_FULLNAME = "Маринела Николова Козлодуй",
                USR_DESC = "Община Козлодуй",
                USR_REG_DATE = DateTime.Now,
                IMAGE_URL = "user.png",
                NOT_USER_PIN = new NOT_USER_PIN() { USR_ID = 53,
                USR_PIN = "154627" }
            },
        };
    }
}