using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LSRPO.Infrastructure.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NOTIFY_GROUPS",
                columns: new[] { "NG_ID", "NG_DESCRIPTION", "NG_MOD_FLAG", "NG_NAME", "NG_NUMBER", "NG_REG_DATE" },
                values: new object[,]
                {
                    { 1, "Площадка ", false, "Зона АЕЦ", "8811", null },
                    { 2, "Площадка АЕЦ + 12км. зона", false, "12км.  АЕЦ", "8812", null },
                    { 3, "Група 3", false, "Group3", "8813", null },
                    { 4, "Група 4", false, "Group4", "8814", null },
                    { 5, "Група 5", false, "Group5", "8815", null },
                    { 6, "Група 6", false, "Group6", "8816", null },
                    { 7, "Група 7", false, "Group7", "8817", null },
                    { 8, "гр. Козлодуй", false, "Group8", "8818", null },
                    { 9, "гр. Козлодуй + общ. Козлодуй", false, "Group9", "8819", null },
                    { 10, "Група 10", false, "Group10", "8820", null },
                    { 11, "Група 11", false, "Group11", "8821", null },
                    { 12, "Група 12", false, "Group12", "8822", null },
                    { 13, "Група 13", false, "Group13", "8823", null },
                    { 14, "Сигнал 2", false, "Group14", "8824", null },
                    { 15, "Група 15", false, "Group15", "8825", null },
                    { 16, "Група 16", false, "Group16", "8826", null },
                    { 17, "Група 17", false, "Group17", "8827", null },
                    { 18, "Група 18", false, "Group18", "8828", null },
                    { 19, "Група 19", false, "Group19", "8829", null },
                    { 20, "Група Дежурни по АП", true, "Group20", "8830", null },
                    { 21, "Група Резервен ав. екип", true, "Group21", "8831", null },
                    { 22, "Група 22", true, "Group22", "8832", null },
                    { 23, "Група СТМ", true, "Group23", "8833", null },
                    { 24, "Група СанДружина", true, "Group24", "8834", null },
                    { 25, "Група 25", true, "Group25", "8835", null },
                    { 26, "Група 26", true, "Group26", "8836", null },
                    { 27, "Група 27", true, "Group27", "8837", null },
                    { 28, "Група 28", true, "Group28", "8838", null },
                    { 29, "Група 29", true, "Group29", "8839", null },
                    { 30, "TECT", false, "Group30", "8840", null },
                    { 31, "Група 31", false, "Group31", "8841", null },
                    { 32, "Група 32", false, "Group32", "8842", null },
                    { 33, "Група 33", false, "Group33", "8843", null },
                    { 34, "Група 34", false, "Group34", "8844", null },
                    { 35, "гр. Мизия", false, "Group35", "8845", null },
                    { 36, "гр. Мизия + общ. Мизия", false, "Group36", "8846", null },
                    { 37, "Група 37", false, "Group37", "8847", null },
                    { 38, "Група 12 км зона", false, "Group38", "8848", null },
                    { 39, "Група Площадка АЕЦ", false, "Group39", "8849", null },
                    { 40, "Група АЕЦ + 12км зона", false, "Group40", "8850", null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 1, "8001", "СТОЛОВА - ЕП 1", (byte)1, null, null, null, null, null },
                    { 2, "8002", "СБК 2", (byte)1, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 3, "8003", "ИНВЕСТИЦИИ 3", (byte)1, null, null, null, null, null },
                    { 4, "8004", "КПП3", (byte)1, null, null, null, null, null },
                    { 5, "8005", "ОРУ", (byte)1, null, null, null, null, null },
                    { 6, "8006", "ЦПС3", (byte)1, null, null, null, null, null },
                    { 7, "8007", "СГРАДА РОС", (byte)1, null, null, null, null, null },
                    { 8, "8008", "ЦАС", (byte)1, null, null, null, null, null },
                    { 9, "8009", "ЦЕХ РАО", (byte)1, null, null, null, null, null },
                    { 10, "8010", "БПС", (byte)1, null, null, null, null, null },
                    { 11, null, "КПП ХЪРЛЕЦ", (byte)1, null, null, null, null, null },
                    { 12, "8012", "С. ХЪРЛЕЦ", (byte)1, null, null, null, null, null },
                    { 13, "8013", "ГР. МИЗИЯ", (byte)1, null, null, null, null, null },
                    { 14, "8014", "С. СОФРОНИЕВО", (byte)1, null, null, null, null, null },
                    { 15, "8015", "С. БУТАН", (byte)1, null, null, null, null, null },
                    { 16, null, "КУЛА БТК", (byte)1, null, null, null, null, null },
                    { 17, "8017", "С. ВОЙВОДОВО", (byte)1, null, null, null, null, null },
                    { 18, "8018", "С. ГЛОЖЕНЕ", (byte)1, null, null, null, null, null },
                    { 19, "8019", "С. САРАЕВО", (byte)1, null, null, null, null, null },
                    { 20, null, "ОБЩЕЖИТИЕ АЕЦ", (byte)1, null, null, null, null, null },
                    { 21, "8021", "КМЕТСТВО ГР.КОЗЛОДУЙ", (byte)1, null, null, null, null, null },
                    { 22, "8022", "У-ЩЕ В. ЛЕВСКИ", (byte)1, null, null, null, null, null },
                    { 23, "8023", "У-ЩЕ ХР. БОТЕВ", (byte)1, null, null, null, null, null },
                    { 24, "8024", "ПГЯЕ", (byte)1, null, null, null, null, null },
                    { 25, null, "ЦУА", (byte)1, null, null, null, null, null },
                    { 26, "8041", "СИМУЛАТОР", (byte)1, null, null, null, null, null },
                    { 27, "2110", "ОПЕРАТОР СТК", (byte)2, "4461", null, "6207", null, null },
                    { 28, "8061", "РАДИОУРЕДБА", (byte)1, null, null, null, null, null },
                    { 29, null, "КП БЩУ 5", (byte)1, null, null, null, null, null },
                    { 30, null, "КП ГДАЕЦ", (byte)1, null, null, null, null, null },
                    { 31, "00898602524", "АНТОН НАЙДЕНОВ АНТОВ", (byte)2, null, "2335", "00879148126", null, null },
                    { 32, "00888099299", "ВЛАДИМИР ИЛИЕВ ДИМОВ", (byte)2, null, "3151", null, null, null },
                    { 33, "00893574037", "СТАНИСЛАВ ДИМОВ ХРИСТАКИЕВ", (byte)2, null, "6549", null, null, null },
                    { 34, "00886400606", "МАРИНА СЕРГЕЕВНА ХАДЖИЕВА", (byte)2, null, "2045", null, null, null },
                    { 35, "00887805845", "ВАЛЕНТИН ЦВЕТАНОВ ПАНЬОВСКИ", (byte)2, null, "3664", null, null, null },
                    { 36, "00889366881", "НИКОЛАЙ ГЕОРГИЕВ ПЕНЕВ", (byte)2, null, "6412", null, null, null },
                    { 37, "00885046435", "ЖИВКА ПЕТРОВА КОЖУХАРОВА", (byte)2, null, "3915", null, null, null },
                    { 39, "00888692211", "ДИАНА ЕНЧЕВА ЕДРЕВА", (byte)2, null, "3759", null, null, null },
                    { 40, "00888453055", "ВАЛЕРИ МОНОВ ПЕТРОВ", (byte)2, null, "3800", null, null, null },
                    { 42, "00877566608", "РОСЕН АСЕНОВ КАЗАКОВ", (byte)2, null, "2741", null, null, null },
                    { 43, "00888945210", "ИВАН ДОШЕВ КАРААБОВ", (byte)2, null, "3058", null, null, null },
                    { 44, "00888907571", "МАРИЯ ИГОРЕВНА ВЕЛИЧКОВА", (byte)2, null, "6137", null, null, null },
                    { 47, "00888429133", "РУСИЯН ХЕРНАНИ ЦИБРАНСКИ", (byte)2, null, "2796", "00878201076", null, null },
                    { 48, "00877660912", "ЦВЕТАНКА ДИМИТРОВА КАПКОВА", (byte)2, null, "2198", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 49, "00897698897", "КРАСИМИР МИТКОВ КАМЕНОВ", (byte)2, null, "3775", "00878591131", null, null },
                    { 50, "00885112599", "КАЛИН АЛЕКСАНДРОВ СТОЯНОВ", (byte)2, null, "3630", null, null, null },
                    { 51, "00889521241", "МИЛЕНА ЙОРДАНОВА НОВАК", (byte)2, null, "6452", null, null, null },
                    { 52, "00879503101", "КРАСИМИР БОРИСОВ ВЕЛИЧКОВ", (byte)2, null, "4224", "00899003962", null, null },
                    { 53, "00879979668", "РУМЕН ЦВЕТАНОВ ЦОНЕВ", (byte)2, null, "2517", "00888461727", null, null },
                    { 54, "00888766419", "ЗДРАВКО ВАСИЛЕВ ЦВЕТАНОВ", (byte)2, null, "6233", null, null, null },
                    { 56, "00889808380", "ГАЛИН МАРИНОВ ПРОДАНОВ", (byte)2, null, "2741", null, null, null },
                    { 59, "00887957359", "МИРОСЛАВ АНГЕЛОВ КАШЕВ", (byte)2, null, "3935", null, null, null },
                    { 60, "00887409601", "ЕВГЕНИ МИЛАНОВ ДОНЧЕВ", (byte)2, "6884", "3261", null, null, null },
                    { 61, "00899938492", "ГЕОРГИ ДИМИТРОВ МИХАЙЛОВ", (byte)2, "6075", "3175", "00889500402", null, null },
                    { 62, "00887739927", "ИВО ВЕЛИЧКОВ НАЕВ", (byte)2, "6617", "2557", "00889500386", null, null },
                    { 63, "00885741737", "РОСЛАВА СВИЛЕНОВА ТОНЧЕВА", (byte)2, null, "4176", null, null, null },
                    { 64, "00879503102", "ВЕСЕЛИН ЙОРДАНОВ АНГЕЛОВ", (byte)2, null, "2517", null, null, null },
                    { 65, "00888314376", "АСЕН ГЕОРГИЕВ АЛЕКСАНДРОВ", (byte)2, null, "3535", null, null, null },
                    { 66, "00899126522", "ЛЮБОМИР АЛЕКСАНДРОВ ПОПОВ", (byte)2, null, "2198", null, null, null },
                    { 67, "00878203040", "АЛЕКСАНДЪР ДИМИТРОВ ЗЛАТАНОВ", (byte)2, null, "3500", null, null, null },
                    { 68, "00887835850", "ИРЕНА КРУМОВА ХРИСТОВА", (byte)2, null, "2198", null, null, null },
                    { 69, "00886445984", "ВИОЛИНА ВАЛЕНТИНОВА СЕМКОВА-ПЕШУНОВА", (byte)2, null, "6443", null, null, null },
                    { 70, "00886684645", "ПЕТЯ СВЕТОЗАРОВА ДИМИТРОВА", (byte)2, null, "2198", null, null, null },
                    { 71, "00884143567", "МИРОСЛАВА ПЕТРОВА РУСИНОВА", (byte)2, null, "3278", null, null, null },
                    { 72, "00888199168", "ЕНЬО ВАСИЛЕВ БРАТОВАНОВ", (byte)2, null, "6143", null, null, null },
                    { 73, "00878833323", "ДИЛЯНА ПАВЛОВА ЗВЕЗДАРСКА", (byte)2, null, "2091", null, null, null },
                    { 74, "00888128495", "МАЯ БЛАГОЕВА ГЕОРГИЕВА", (byte)2, null, "2091", null, null, null },
                    { 75, "00887097808", "АСПАРУХ ИВАНОВ ПЪРВАНОВ", (byte)2, null, "3786", "00879911646", null, null },
                    { 77, "00893003533", "ЗДРАВКО ЕНЧЕВ ЯНКОВ", (byte)2, null, "3019", null, null, null },
                    { 78, "00888145115", "ПЕТЪР ДИМИТРОВ МИТОВ", (byte)2, null, "2866", null, null, null },
                    { 79, "00879121674", "НИКОЛА ВИЛИЕВ ХРИСТОВ", (byte)2, null, "3333", null, null, null },
                    { 80, "00888315516", "МАРИЯ ПЕКОВА СТОЙЧЕВА", (byte)2, null, "2273", null, null, null },
                    { 81, "00886193720", "ГЕОРГИ АТАНАСОВ ДРАГАНОВ", (byte)2, null, "2741", null, null, null },
                    { 82, "00879503111", "ЕЛИЦА ЛЮБЕНОВА ЕВГЕНИЕВА", (byte)2, null, "3636", null, null, null },
                    { 83, "00879486451", "АЛЕКСАНДЪР НИКОЛАЕВ РУПЧАНСКИ", (byte)2, null, "2091", null, null, null },
                    { 84, "00885670726", "КАТЯ  ВАЛЕНТИНОВА  ТОНЧЕВА", (byte)2, null, "2485", null, null, null },
                    { 85, "00887330889", "АЛЕКСАНДЪР ДИМИТРОВ ТОМОВ", (byte)2, "3385", "2550", null, null, null },
                    { 86, "00898334993", "НИКОЛАЙ ВАСИЛЕВ ИВАНОВ", (byte)2, "3385", "2550", null, null, null },
                    { 87, "00879996699", "АЛЕКСАНДЪР НИКОЛОВ", (byte)2, null, "6333", null, null, null },
                    { 88, "00878940955", "АНЕЛИ МИТКОВ ЦОЛОВ", (byte)2, null, "6223", "00877355938", null, null },
                    { 89, "00887578778", "МИГЛЕНА ЦВЕТАНОВА ИВАНОВА", (byte)2, null, "2061", null, null, null },
                    { 90, "00885670726", "КАТЯ ВАЛЕНТИНОВА ТОНЧЕВА - СД", (byte)2, null, "2485", null, null, null },
                    { 91, "00889990041", "ЕМИЛИЯ  ВАСИЛЕВА ВЛАДИМИРОВА - СД", (byte)2, null, "3390", null, null, null },
                    { 92, "00899860573", "ТАТЯНА МИХАЙЛОВНА МАНЕВА - СД", (byte)2, null, "3499", null, null, null },
                    { 93, "00888863004", "АННА СТОЯНОВА ЙОРДАНОВА - СД", (byte)2, null, "085010", null, null, null },
                    { 94, "00889363889", "НАДЯ ПЕТРОВА АНГЕЛОВА - СД", (byte)2, null, "3095", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 95, "00887116370", "ВЕНИСЛАВА ИВАНОВА ВАСИЛЕВА - СД", (byte)2, null, "2052", null, null, null },
                    { 96, "00888388890", "ПЕТЯ БОРИСОВА ЦЕКОВА - СД", (byte)2, null, "2008", null, null, null },
                    { 97, "00885367131", "ГЕОРГИ БЛАГОЕВ ГЕОРГИЕВ", (byte)2, null, "3034", null, null, null },
                    { 98, "00877443001", "МЕЛИНА ТОНИЕВА ТОМОВА", (byte)2, null, "3278", null, null, null },
                    { 99, "00886312403", "ГРЕТА РУСИНОВА НЕДЕЛЧЕВА", (byte)2, null, "3278", null, null, null },
                    { 101, "00888797467", "МАРГАРИТА КАЧОВА КАМЕНОВА", (byte)2, null, "3534", null, null, null },
                    { 102, "00887714464", "ВАЛЕНТИНА ЦВЕТАНОВА ЛАЗАРОВА", (byte)2, null, "3537", null, null, null },
                    { 103, "00878202366", "КРАСИМИРА ТОДОРОВА КУЗМАНОВА", (byte)2, null, "4265", null, null, null },
                    { 105, "00888822933", "СТЕФКА ГЕОРГИЕВА ВАКЛИНОВА", (byte)2, "6903", "3170", "00889500372", null, null },
                    { 106, "00884323423", "МИХАИЛ ГЕННАДИЕВИЧ АБРАМОВ", (byte)2, null, "3471", null, null, null },
                    { 107, "00885040374", "ЯСЕН САВЕВ БОНЕВ", (byte)2, null, "3208", null, null, null },
                    { 108, "00899551134", "ПЕТЪР ДРАГАНОВ ДЖОРОВ", (byte)2, null, "3427", null, null, null },
                    { 110, "00878232475", "ИЛИН ТОДОРОВ ДИМИТРОВ", (byte)2, null, "2860", null, null, null },
                    { 111, "00878823728", "ЗОЯ ХРИСТОВА ИВАНОВА", (byte)2, null, "3441", null, null, null },
                    { 112, "00885512291", "БОРИСЛАВ КИРИЛОВ БОГОЕВ", (byte)2, null, "3396", null, null, null },
                    { 113, "00886560869", "ДАНИЕЛ СТЕФАНОВ ХРИСТОВ", (byte)2, "3033", "3275", null, null, null },
                    { 114, "00899137319", "ДАНИЕЛА ПЕНЧЕВА КАЛЧЕВА - СД", (byte)2, null, "2043", null, null, null },
                    { 115, "00896039903", "ГЕРГАНА РОМАНОВА ГЕОРГИЕВА", (byte)2, null, "4016", null, null, null },
                    { 116, "00889287480", "ПЕТЯ ИВАНОВА БАШЛИЕВА", (byte)2, null, "4034", "00879845446", null, null },
                    { 117, null, "КП СТК", (byte)1, null, null, null, null, null },
                    { 118, null, "КП БЩУ 6", (byte)1, null, null, null, null, null },
                    { 119, null, "КП ЦУА", (byte)1, null, null, null, null, null },
                    { 120, "00888232636", "ЦВЕТОМИР ХРИСТОВ ГАНЧЕВ", (byte)2, null, "6040", null, null, null },
                    { 121, "00878682250", "ИВАЙЛО ЗВЕЗДОМИРОВ ПЕТКОВ", (byte)2, null, "3625", null, null, null },
                    { 122, "00889505056", "МИРОСЛАВ ТОШКОВ САРАЧИНОВ", (byte)2, null, "4552", null, null, null },
                    { 123, "00888767042", "ИВАЙЛО ВЕЛИЧКОВ БУКОЕВ", (byte)2, null, "4138", null, null, null },
                    { 124, "00879690288", "АНТОАНЕТА ТОДОРОВА МАНОВА", (byte)2, null, "4118", null, null, null },
                    { 125, "00885001420", "ЛОРА ХРИСТОВА ГЕОРГИЕВА - СД", (byte)2, null, "4017", null, null, null },
                    { 126, "00879690288", "АНТОАНЕТА ТОДОРОВА МАНОВА - СД", (byte)2, null, "4118", null, null, null },
                    { 127, "00886520030", "ВЕРА ГЕОРГИЕВА МАРИНОВА - СД", (byte)2, null, "3365", null, null, null },
                    { 128, "00885459310", "ДАНИЕЛА ПЕТРОВА ГЕНЧЕВА - СД", (byte)2, null, "3479", null, null, null },
                    { 129, "00888210400", "ПЕТКО БОРИСОВ АНГЕЛОВ", (byte)2, null, "3256", null, null, null },
                    { 131, "00877190471", "МАРГАРИТА ГЕОРГИЕВА ГЕРГОВА", (byte)2, null, "3278", null, null, null },
                    { 133, "00885252896", "ДИНЧО РУМЕНОВ СТЕФАНОВ", (byte)2, null, "4217", null, null, null },
                    { 134, "00888288860", "ЛЮБЕН ЦВЕТАНОВ ТАШЕВ", (byte)2, null, "3108", null, null, null },
                    { 135, null, "КП СИМУЛАТОР", (byte)1, null, null, null, null, null },
                    { 138, "00886910263", "ИВАН ВАЛЕНТИНОВ ИВАНОВ", (byte)2, null, "3909", null, null, null },
                    { 140, "00888986200", "СТАНИСЛАВ ПЕТЕВ ЛАЗАРОВ", (byte)2, null, "5746", null, null, null },
                    { 141, "00899679036", "ИВАЙЛО ТРАЯНОВ НИНОВ", (byte)2, null, "3639", null, null, null },
                    { 142, "00879698852", "МИРОСЛАВ НИКОЛАЕВ РУПЧАНСКИ", (byte)2, "5760", "5758", null, null, null },
                    { 143, "00887402894", "КИРИЛ ЦВЕТАНОВ МАРИНОВ", (byte)2, null, "2147", null, null, null },
                    { 144, "00886089871", "ЕМИЛ ВАСИЛЕВ ГЕОРГИЕВ", (byte)2, null, "4552", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 145, "00886838687", "АНГЕЛ ПЕТРОВ ЯНЧЕВ", (byte)2, null, "3612", null, null, null },
                    { 146, "00878963540", "ДИМИТРИНКА РОЗЕНОВА КАРАПЕТКОВА", (byte)2, null, "2273", null, null, null },
                    { 147, "00888061525", "АЛЕКСАНДЪР ВАЛЕНТИНОВ СТОЙКОВ", (byte)2, null, "3938", null, null, null },
                    { 148, "00889915644", "КРЪСТЬО ИВАНОВ МАРИНОВ", (byte)2, null, "3646", null, null, null },
                    { 149, "00887098075", "ВЕНЕЛИН ЦВЕТАНОВ ОВЧАРОВ", (byte)2, null, "4380", null, null, null },
                    { 151, "00887846287", "ЕМИЛ ИЛИЕВ НИНОВ", (byte)2, null, "4380", null, null, null },
                    { 152, "00886446019", "ЛЮБИМА ИЛИЯНОВА ЯРОСЛАВОВА", (byte)2, null, "2273", null, null, null },
                    { 153, "00889910671", "ИЛИЯН САШКОВ АЛЕКСАНДРОВ", (byte)2, null, "3621", null, null, null },
                    { 155, null, "PRIZM", (byte)1, null, null, null, null, null },
                    { 156, "00888010909", "ТОДОР АТАНАСОВ ДЪЛБОКОВ", (byte)2, null, "3386", null, null, null },
                    { 157, "00887099748", "ПЛАМЕН КИРИЛОВ ПЕТКОВ", (byte)2, "6954", "2224", null, null, null },
                    { 159, "00888918096", "ГАЛИНА ЙОРДАНОВА КОСТАДИНОВА", (byte)2, "6996", "6513", null, null, null },
                    { 160, "00885274046", "МИЛЕН КИРИЛОВ МЛАДЕНОВ", (byte)2, null, "3067", null, null, null },
                    { 161, "00886608486", "ЦЕЦКА ПЕТКОВА МИЛАНОВА", (byte)2, null, "3256", null, null, null },
                    { 162, "00879651507", "БОРИСЛАВ ЦВЕТАНОВ ДОБРИНОВ", (byte)2, "3033", "3441", null, null, null },
                    { 164, "00885587378", "ОГНЯН ВЛАДИМИРОВ ТРИЧКОВ", (byte)2, null, "6508", null, null, null },
                    { 165, "00877900427", "АНИТА ХРИСТОВА ВЕЛКОВА", (byte)2, null, "3631", null, null, null },
                    { 168, "00888366460", "ГАБРИЕЛА ВАЛЕРИЕВА ЦВЕТАНОВА", (byte)2, null, "2533", null, null, null },
                    { 171, "00888649715", "ИВАЙЛО ПЛАМЕНОВ БИНЧЕВ", (byte)2, "6904", "6528", null, null, null },
                    { 172, "00889750006", "ВИОЛЕТА ИГНАТОВА ВЛАШКА - СД", (byte)2, null, "4354", null, null, null },
                    { 173, "00888366460", "ГАБРИЕЛА ВАЛЕРИЕВА ЦВЕТАНОВА - СД", (byte)2, null, "2533", null, null, null },
                    { 174, "00889396357", "ИЛИАНА ЦЕНОВА СЛАВЧЕВА - СД", (byte)2, null, "2008", null, null, null },
                    { 175, "00878663653", "КАТЯ ВЕЛИЗАРОВА МЕТОДИЕВА - СД", (byte)2, null, "4417", null, null, null },
                    { 176, "00898757306", "МАРГАРИТА СПАСОВА ПАСКАЛЕВА - СД", (byte)2, null, "3076", null, null, null },
                    { 177, "00889573384", "МАРИАНА РОСЕНОВА МАРИНОВА - СД", (byte)2, null, "6378", null, null, null },
                    { 178, "00878685084", "СОНЯ ДИМИТРОВА АБРАШЕВА-ПАТРОЕВА - СД", (byte)2, null, "3576", null, null, null },
                    { 180, null, "КП МИЗИЯ", (byte)1, null, null, null, null, null },
                    { 181, null, "КП КОЗЛОДУЙ", (byte)1, null, null, null, null, null },
                    { 182, "00886046497", "РАДОСЛАВ ВАЛЕНТИНОВ ГЕОРГИЕВ", (byte)2, null, "3646", null, null, null },
                    { 186, "00878541341", "ЦВЕТОМИР ВЕНЕЛИНОВ НЕНОВ", (byte)2, null, "3427", null, null, null },
                    { 187, "00893441707", "МАРГАРИТА БОРИСЛАВОВА ГОЛЕМАНОВА", (byte)2, null, "5719", null, null, null },
                    { 188, "00885531302", "ПЕТЪР ПЛАМЕНОВ БЕЧЕВ", (byte)2, null, "4517", null, null, null },
                    { 189, "00878181488", "МИРОСЛАВ ЕВГЕНИЕВ ГЕНОВ", (byte)2, null, "3603", "00878404108", null, null },
                    { 190, "00887804642", "БОЯН ВЕЛИЧКОВ МАРИНОВ", (byte)2, null, "3656", "00889230309", null, null },
                    { 191, "00888235969", "МИРОСЛАВ ЦВЕТАНОВ МАРИНОВ", (byte)2, "6910", "2270", null, null, null },
                    { 192, "00889520156", "СВЕТЛАНА ДИМИТРОВА КИТАНОВА", (byte)2, null, "3208", null, null, null },
                    { 193, "00888009843", "ИВАН ИВАНОВ КОЛАРОВ", (byte)2, "4518", "6618", null, null, null },
                    { 194, null, "СТМ - РОСЕН БЕЛЧЕВ", (byte)2, null, null, "00888909458", null, null },
                    { 195, null, "СТМ - ПЕТЯ СТОЯНОВСКА", (byte)2, null, null, "00888922298", null, null },
                    { 196, null, "СТМ - БОРИСЛАВ ХАЙТОВ", (byte)2, null, null, "00887425207", null, null },
                    { 197, null, "СТМ - ИВО ПОПОВ", (byte)2, null, null, "00894687168", null, null },
                    { 198, null, "СТМ - МАЛИНА ИВАНОВА", (byte)2, null, null, "00884539714", null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 199, null, "СТМ - ТЕТЯНА ЮРЕВИЧ", (byte)2, null, null, "00887764840", null, null },
                    { 200, null, "СТМ - БОЙКА ОВЕДЕНСКА", (byte)2, null, "00888256291", "00888414341", null, null },
                    { 201, null, "СТМ - ДАНИЕЛА МЕТОДИЕВА", (byte)2, null, null, "00887741099", null, null },
                    { 202, null, "СТМ - БОРЯНА СТОЙНОВСКА", (byte)2, null, null, "00887508153", null, null },
                    { 203, null, "СТМ - ВИОЛИН КРУШОВЕНСКИ", (byte)2, null, null, "00889966908", null, null },
                    { 204, null, "СТМ - ЕВГЕНИЯ ГЕТОВА", (byte)2, null, null, "00887233355", null, null },
                    { 205, null, "СТМ - СИМЕОНКА СИМЕОНОВА", (byte)2, null, null, "00887700424", null, null },
                    { 206, null, "СТМ - ГЕОРГИ ВОДЕНИЧАРСКИ", (byte)2, null, null, "00886857890", null, null },
                    { 207, null, "СТМ - ЕМИЛИЯ ЛЕБЕДОВА", (byte)2, null, null, "00885444631", null, null },
                    { 208, null, "СТМ - НЕВЕНА СТОЯНОВА", (byte)2, null, null, "00886890242", null, null },
                    { 209, null, "СТМ - ПЕТЯ ГАНЕВА", (byte)2, null, null, "00887686586", null, null },
                    { 210, null, "СТМ - КАТЯ РИБАРСКА", (byte)2, null, null, "00886529350", null, null },
                    { 211, null, "СТМ - МАЯ ПЕТКОВА", (byte)2, null, null, "00886004200", null, null },
                    { 212, null, "СТМ - ПЕТЯ ЦЕНКОВА", (byte)2, null, null, "00889720667", null, null },
                    { 213, null, "СТМ - МИГЛЕНА АНГЕЛОВА-ВАСИЛЕВА", (byte)2, null, null, "00885194934", null, null },
                    { 214, null, "СТМ - НАТАЛИЯ СТАНЧЕВА", (byte)2, null, null, "00888775518", null, null },
                    { 215, null, "СТМ - ДАНИЕЛА ХРИСТОВА", (byte)2, null, null, "00887608088", null, null },
                    { 216, null, "СТМ - НЕЛИ ЦВЕТКОВА", (byte)2, null, null, "00894708525", null, null },
                    { 217, null, "СТМ - МИЛЕНА ДИМИТРОВА", (byte)2, null, null, "00884223295", null, null },
                    { 218, null, "СТМ - ВЕНЕТА БАНУЦОВА", (byte)2, null, null, "00887164892", null, null },
                    { 219, null, "СТМ - АНДРЕЙ ТАБАКОВ", (byte)2, null, null, "00888829826", null, null },
                    { 220, null, "СТМ - КРАСИМИР ПАЧЕВ", (byte)2, null, null, "00889714121", null, null },
                    { 221, null, "СТМ - ЕВГЕНИ АВРАМОВ", (byte)2, null, null, "00888897638", null, null },
                    { 222, null, "СТМ - СЛАВЕЙ ИЛИЕВ", (byte)2, null, null, "00885934554", null, null },
                    { 223, null, "СТМ - МИХАИЛ ЦЕНОВ", (byte)2, null, null, "00888308382", null, null },
                    { 224, null, "СТМ - ВЛАДИМИР ВЕЛИКОВ", (byte)2, null, null, "00886588849", null, null },
                    { 225, null, "СТМ - ЕМИЛ КОПРАЛЕВ", (byte)2, null, null, "00885206356", null, null },
                    { 226, null, "СТМ - ИРЕНА ЦЕНОВА", (byte)2, null, null, "00878625466", null, null },
                    { 227, null, "СТМ - ПЛАМЕН ПЪРВАНОВ", (byte)2, null, null, "00888435455", null, null },
                    { 228, null, "СТМ - ИВАЛИНА ЦВЕТКОВА", (byte)2, null, null, "00885400784", null, null },
                    { 229, null, "СТМ - КОНСТАНТИН ГМИТРИЧОВ", (byte)2, null, null, "00888047837", null, null },
                    { 230, null, "СТМ - ВЕНЦИСЛАВ ИВАНОВ", (byte)2, null, null, "00876287114", null, null },
                    { 231, null, "СТМ - СВЕТЛА КИРОВА", (byte)2, null, null, "00879804847", null, null },
                    { 232, null, "СТМ - АНЕТА МЕТОДИЕВА", (byte)2, null, null, "00885248776", null, null },
                    { 233, null, "СТМ - ЛИДИЯ СЛАВЧЕВА", (byte)2, null, null, "00886853182", null, null },
                    { 234, null, "СТМ - МАРИЕЛА ЗАХАРИЕВА", (byte)2, null, null, "00889572051", null, null },
                    { 235, null, "СТМ - НИНА МИРЧЕВА", (byte)2, null, null, "00886434476", null, null },
                    { 236, "00883352573", "АЛЕКСАНДЪР ПАВЛОВ АВРАМОВ", (byte)2, null, "2452", null, null, null },
                    { 237, "00878899077", "ПЕТКО АНГЕЛОВ ПЕТКОВ", (byte)2, "6958", "3558", null, null, null },
                    { 238, "00898582580", "ЦВЕТАН ГЕОРГИЕВ ЦАЛОВ", (byte)2, null, "2566", "00879913971", null, null },
                    { 239, "00885565285", "СТЕФАН ИВАНОВ СТЕФАНОВ", (byte)2, null, "2566", null, null, null },
                    { 240, "00886841924", "АНГЕЛ ИЛИЕВ ЧАРАПАНСКИ", (byte)2, null, "2056", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 241, "00877359977", "МАРИЯН МИНКОВ ПАРАСКЕВОВ", (byte)2, null, "2056", null, null, null },
                    { 242, "00899935434", "МАРТИН ИВАЙЛОВ АЛЕКСАНДРОВ", (byte)2, null, "2056", null, null, null },
                    { 243, "00878311227", "ВЕНЦИСЛАВ ЙОРДАНОВ КАЛУШЕВ", (byte)2, null, "5707", null, null, null },
                    { 244, "00896828187", "ВИКТОР КУНЧЕВ НИКОЛОВ", (byte)2, null, "2566", null, null, null },
                    { 245, "00878760081", "ИВАЙЛО АСЕНОВ ИВАНОВ", (byte)2, null, "2566", null, null, null },
                    { 246, "00885568711", "ХРИСТО ДИМИТРОВ ХРИСТОВ", (byte)2, null, "2056", null, null, null },
                    { 247, "00876302410", "ДИМИТЪР ИВАНОВ ДИМИТРОВ", (byte)2, null, "3177", "00879979658", null, null },
                    { 248, "00886430992", "МАРТИН ХРИСТОВ МАРИНОВ", (byte)2, null, "2056", null, null, null },
                    { 249, "00876308281", "СТОЯН НИКОЛОВ ВИТАНОВ", (byte)2, null, "3662", null, null, null },
                    { 250, "00885043460", "ВАЛЕРИ ИВАНЧЕВ ИВАНОВ", (byte)2, null, "6330", null, null, null },
                    { 251, "00878241007", "ЛЪЧЕЗАР ЕНЧЕВ АНГЕЛОВ", (byte)2, null, "2864", "00888220225", null, null },
                    { 252, "00886393227", "ВЕСЕЛИН СТЕФАНОВ МАРКОВ", (byte)2, null, "2692", null, null, null },
                    { 253, "00886480105", "ЧАВДАР ПЕТРОВ СТЪНГАЧЕВ", (byte)2, null, "2692", "00878756314", null, null },
                    { 254, "00889226311", "ЛИЛЯНА БОРИСЛАВОВА ДИМИТРОВА", (byte)2, null, "2692", "00878756301", null, null },
                    { 255, "00886290508", "БОЯН ВЕСЕЛИНОВ БАНКОВ", (byte)2, null, "3003", null, null, null },
                    { 257, "00888905357", "ЕВГЕНИЙ ВАСИЛЕВ БОГОЕВ", (byte)2, null, "2772", null, null, null },
                    { 258, "00887715578", "КАТРИН ГЕОРГИЕВА ВЛАДОВА", (byte)2, null, "3256", null, null, null },
                    { 259, "00888154322", "ВАЛЕРИ ВАНЬОВ ЕФТИМОВ", (byte)2, null, "2566", null, null, null },
                    { 261, "00886849108", "ТЕМЕНУЖКА ВЕСЕЛИНОВА СТОЯНОВА", (byte)2, null, "3441", null, null, null },
                    { 262, "00877280108", "ВАСИЛ ИВАНОВ МИЛЕВ", (byte)2, null, "3441", null, null, null },
                    { 264, "00889377589", "ИЛИЯН ГЕОРГИЕВ ТОМОВ", (byte)2, null, "3560", null, null, null },
                    { 266, "00876051094", "ВАЛЕРИ ВАСИЛЕВ ТОДОРОВ", (byte)2, null, "2869", null, null, null },
                    { 267, "00898328465", "БИАНКА СТОЯНОВА КАЛЧЕВА", (byte)2, null, "2100", null, null, null },
                    { 268, "00879006619", "ЙОРДАНКА ВАЛЕРИЕВА СТОЙНЕВА", (byte)2, "2550", "3385", null, null, null },
                    { 269, "00889920256", "ТОДОР СВЕТОСЛАВОВ ТОДОРОВ", (byte)2, null, "3256", null, null, null },
                    { 270, "00878232474", "ДИМИТЪР ТОДОРОВ ДИМИТРОВ", (byte)2, null, "2513", null, null, null },
                    { 271, "00886293826", "ИРЕНА ПЛАМЕНОВА НИКОЛОВА - МИТОВА", (byte)2, null, "3394", null, null, null },
                    { 272, "00889990041", "ЕМИЛИЯ ВАСИЛЕВА ВЛАДИМИРОВА", (byte)2, "2477", "2945", null, null, null },
                    { 273, "00884767604", "АТАНАС ДИМИТРОВ ИВАНОВ", (byte)2, null, "3595", null, null, null },
                    { 275, "00898610157", "АЛЕКСАНДЪР ЙОРДАНОВ НИКОЛОВ", (byte)2, null, "2174", null, null, null },
                    { 277, "00889500387", "ПЕТЬО ГЕНОВ ПЕНЕВ", (byte)2, "6872", "3612", null, null, null },
                    { 278, "00885708595", "ЦВЕТОСЛАВ ГЕОРГИЕВ ХРИСТОВ", (byte)2, null, "2704", "00879911645", null, null },
                    { 279, "00888879494", "ДАНАИЛ ЛЮДМИЛОВ ДИКОВ", (byte)2, "2566", "2056", null, null, null },
                    { 280, "00899446859", "НИКОЛАЙ ИВАНОВ НИКОЛОВ", (byte)2, null, "3591", null, null, null },
                    { 281, "00896416306", "БОРИС ВОЛОДИЕВ ЦЕНОВ", (byte)2, null, "2056", null, null, null },
                    { 282, "00889802168", "ИЛКО ЛЪЧЕЗАРОВ НАЙДЕНОВ", (byte)2, null, "4179", null, null, null },
                    { 283, "00889500370", "ТАНКА ИВАНОВА БОЕВА", (byte)2, null, "2224", null, null, null },
                    { 289, "00899876638", "ЛЮБОМИР ПЕТРОВ КАНДОВ", (byte)2, null, "6152", null, null, null },
                    { 291, "00888606103", "ВЕСЕЛИНА ГЕОРГИЕВА ДИМИТРОВА", (byte)2, null, "6514", null, null, null },
                    { 292, "00888062471", "БИЛЯНА ДИМИТРОВА СПАСОВА", (byte)2, null, "2248", null, null, null },
                    { 293, "00888433742", "ПЛАМЕН ЕМИЛОВ ГОРАНОВ", (byte)2, "3385", "2550", null, null, null },
                    { 294, "00889788164", "ИВАЙЛО ЕВСТАТИЕВ КРАЛЧЕВ", (byte)2, "6250", "3205", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 295, "00888011288", "НИКОЛАЙ СТЕФАНОВ ПЕТРОВ", (byte)2, "6685", "3559", null, null, null },
                    { 296, "00889224450", "ГЕОРГИ АТАНАСОВ МИХАЙЛОВ", (byte)2, null, "2065", null, null, null },
                    { 297, "00888865095", "РАИСА КИРИЛОВА ПОПОВА - БОРИСОВА", (byte)2, null, "3115", null, null, null },
                    { 298, "00888297373", "ДИМИТЪР АСПАРУХОВ ДИМИТРОВ", (byte)2, null, "3140", null, null, null },
                    { 299, "00898769921", "ИВАЙЛО ВЛАДКОВ ПЕТКОВ", (byte)2, null, "2974", null, null, null },
                    { 300, "00879441761", "МАРТИН ПЛАМЕНОВ СТОЯНОВ", (byte)2, null, "2456", null, null, null },
                    { 301, "00878630215", "НЕЛИ СИМЕОНОВА ИВАНОВА", (byte)2, null, "2502", null, null, null },
                    { 302, "00879363800", "НИКОЛАЙ КОНСТАНТИНОВ ДОБРЕВ", (byte)2, null, "3935", null, null, null },
                    { 303, "00878367065", "МИРОСЛАВ МЛАДЕНОВ ЦАНКОВ", (byte)2, null, "2866", null, null, null },
                    { 304, "00877992404", "ЦВЕТЕЛИН ИВОВ ДИМИТРОВ", (byte)2, null, "3529", null, null, null },
                    { 305, "00879188767", "ИВАЛИНА РУМЕНОВА ДРАГАНИНСКА", (byte)2, "6476", "3441", null, null, null },
                    { 306, "00889136326", "ВЛАДИМИР ЙОТОВ ЙОТОВ", (byte)2, null, "2091", null, null, null },
                    { 307, "00898608274", "ТРЕНДАФИЛ ДИМИТРОВ ПЕТРИНОВ", (byte)2, null, "2091", "00877155688", null, null },
                    { 308, "00899146206", "РОСЕН ТРИФОНОВ ГЕОРГИЕВ", (byte)2, null, "2273", null, null, null },
                    { 309, "00895734403", "ДАНИЕЛА ЙОСИФОВА МИТКОВА", (byte)2, null, "3389", null, null, null },
                    { 310, "00890420850", "ЯВОР МАРИНОВ СТОЕВ", (byte)2, null, "2771", null, null, null },
                    { 311, "00889377536", "МЛАДЕН ЙОРДАНОВ НИКОЛОВ", (byte)2, null, "3724", null, null, null },
                    { 312, "00887727485", "ВЕЛИЗАР НИКОЛОВ МЕТОДИЕВ", (byte)2, null, "2504", null, null, null },
                    { 313, "00886334450", "АНЖЕЛА ЦВЕТАНОВА ОРЛОВА", (byte)2, null, "3557", null, null, null },
                    { 314, "00889416927", "ВАЛЕНТИН СТЕФАНОВ СЕРАФИМОВ", (byte)2, null, "2181", null, null, null },
                    { 315, "00887623548", "КАЛИН КОНСТАНТИНОВ СЕРАФИМОВ", (byte)2, null, "5741", null, null, null },
                    { 316, "00899301767", "МИТКО СТОЯНОВ КАЦАРОВ", (byte)2, null, "2864", null, null, null },
                    { 317, "00898447301", "ГЕОРГИ ЙОРДАНОВ ЙОРДАНОВ", (byte)2, null, "2566", "00878756311", null, null },
                    { 318, "00889114298", "ЕМИЛ ЦВЕТАНОВ МЛАДЕНОВ", (byte)2, null, "2056", null, null, null },
                    { 319, "00893522409", "САШКО ЛЪЧЕЗАРОВ ИЛИЕВ", (byte)2, "3662", "2056", null, null, null },
                    { 320, "00878386391", "ИРЕНА ГЕОРГИЕВА ИВАНОВА", (byte)2, null, "2091", null, null, null },
                    { 321, "00877363404", "ЕМИЛ ВАСИЛЕВ ВАСИЛЕВ", (byte)2, null, "2056", null, null, null },
                    { 322, "00895870989", "ХРИСТО ГЕОРГИЕВ ХРИСТОВ", (byte)2, null, "2299", "00879979497", null, null },
                    { 324, "00887606505", "ИВАЙЛО АТАНАСОВ ХРИСТОВ", (byte)2, null, "6541", null, null, null },
                    { 325, "00888228616", "ЕМИЛ ЙОРДАНОВ ШЕРБАНОВ", (byte)2, "6930", "2230", "00889500383", null, null },
                    { 326, "00886838099", "СИМО АНДРЕЕВ СИМЕОНОВ", (byte)2, "4255", "3255", null, null, null },
                    { 327, "00898467220", "ПЛАМЕН ТРИФОНОВ ПЕТРОВ", (byte)2, null, "3436", null, null, null },
                    { 328, "00887424678", "ДИМИТЪР БОРИСОВ ГЕОРГИЕВ", (byte)2, null, "2741", null, null, null },
                    { 329, "00888388890", "ПЕТЯ БОРИСОВА ЦЕКОВА", (byte)2, null, "2008", null, null, null },
                    { 330, "00882286575", "ТАНЯ ИВАНОВА АТАНАСОВА", (byte)2, null, "6698", null, null, null },
                    { 331, "00886891950", "ЕМИЛ НИКОЛОВ ЦАКЕВ", (byte)2, "2566", "2692", null, null, null },
                    { 332, "00893528562", "ЕМИЛ ИВАНОВ МАРИНОВ", (byte)2, null, "2566", null, null, null },
                    { 333, null, "СТМ - НИКОЛИНА ХРИСТОВА", (byte)2, null, null, "00888853285", null, null },
                    { 334, null, "СТМ - МАЯ ЯНКОВА ЖИВКОВА", (byte)2, null, null, "00878613856", null, null },
                    { 335, null, "СТМ - БОЙКО ТОДОРОВ НИКОЛОВ", (byte)2, null, null, "00895742789", null, null },
                    { 336, null, "СТМ - ЙОАНА РАДОСЛАВОВА", (byte)2, null, null, "00889982945", null, null },
                    { 337, null, "СТМ - ЛОРА ПЕТЬОВА БРЕЗОЙКОВА", (byte)2, null, null, "00885156964", null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 338, null, "СТМ - НАНСИ СТЕФЧОВА СИМЕОНОВА", (byte)2, null, null, "00894822544", null, null },
                    { 341, "00888317277", "ЦВЕТАН РАДОСЛАВОВ НИКОЛОВ", (byte)2, "6987", "3181", "00878612331", null, null },
                    { 342, "00898986188", "ИВО АЛЕКСИЕВ МЕТОДИЕВ", (byte)2, "6497", "3445", null, null, null },
                    { 343, "00889396357", "ИЛИАНА ЦЕНОВА СЛАВЧЕВА", (byte)2, null, "2008", null, null, null },
                    { 344, "00877345522", "ПАВЕЛ ИВАНОВ МИЛЕТИЕВ", (byte)2, null, "5759", null, null, null },
                    { 345, "00879438877", "БОРЯНА СТЕФАНОВА НАЙДЕНОВА", (byte)2, null, "2894", "00878756306", null, null },
                    { 346, "00886014822", "НИКОЛАЙ ДИМИТРОВ ПАУНОВ", (byte)2, null, "2566", "00878756307", null, null },
                    { 347, "00878807791", "ПЛАМЕН ДИМИТРОВ НЕХРИЗОВ", (byte)2, null, "2056", null, null, null },
                    { 348, "00884722073", "КОСТАДИНКА ЕВСТАТИЕВА ПРУНЕЧЕВА", (byte)2, null, "2530", null, null, null },
                    { 350, "00898715060", "ДАНАИЛ ВАСИЛЕВ ХРИСТОВ", (byte)2, null, "2045", null, null, null },
                    { 351, "00887514107", "МАРИН НИКОЛАЕВ СТОЯНОВ", (byte)2, "3385", "2550", null, null, null },
                    { 352, "00888540457", "МАКСИМ ХРИСТОВ ИВАНОВ", (byte)2, "6473", "3714", null, null, null },
                    { 353, "00895669310", "ВАЛЕНТИН ВАСИЛЕВ СТЕФАНОВ", (byte)2, null, "4186", null, null, null },
                    { 354, "00896746844", "АНЕЛИЯ БОРИСЛАВОВА МАРТИНОВА", (byte)2, null, "3436", "00878272705", null, null },
                    { 355, "00884395482", "ТЕОДОСИ ЦВЕТАНОВ ТОДОРОВ", (byte)2, null, "2741", null, null, null },
                    { 356, "00889160639", "ДЕТЕЛИН СЛАВЧЕВ ОПРИЦОВ", (byte)2, null, "3256", null, null, null },
                    { 357, "00889502708", "КАТЯ СИМЕОНОВА БАЛИЕВА", (byte)2, null, "6443", null, null, null },
                    { 358, "00888655124", "СЛАВКА ПЕТРОВА ИВАНОВА-МАРИНОВА", (byte)2, null, "2768", null, null, null },
                    { 359, "00898610157", "АЛЕКСАНДЪР ЙОРДАНОВ ДИМИТРОВ", (byte)2, null, "2864", null, null, null },
                    { 360, "00878949087", "МИРОСЛАВ ВЪРБАНОВ ХРИСТОВ", (byte)2, null, "2056", null, null, null },
                    { 361, "00886430411", "ГЕОРГИ ТОДОРОВ ЦОЛОВ", (byte)2, "6988", "4246", "00877745279", null, null },
                    { 362, "00885252477", "КРАСИМИР НАСКОВ ОРМАНОВ", (byte)2, null, "3411", null, null, null },
                    { 363, "00877741600", "МИРОСЛАВ ЦВЕТАНОВ ЦЕНОВ", (byte)2, null, "3812", null, null, null },
                    { 364, "00878677729", "АЛЕКСАНДЪР ХРИСТОВ СТОЯНОВ", (byte)2, null, "2510", null, null, null },
                    { 365, "00878765430", "СОНЯ ДИМИТРОВА АБРАШЕВА", (byte)2, null, "3576", null, null, null },
                    { 366, "00886887612", "ИВАЙЛО БОРИСОВ ИВАНОВ", (byte)2, null, "2056", null, null, null },
                    { 367, "00887257974", "РАДОСЛАВ НИКОЛОВ ГЕТОВ", (byte)2, null, "2566", null, null, null },
                    { 368, "00884565333", "КАТЯ ПЕПИЕВА КРЪСТЕВА", (byte)2, null, "3516", null, null, null },
                    { 369, "00888010022", "НИКОЛАЙ ВЕНЕЛИНОВ КОЛЕВ", (byte)2, null, "2866", null, null, null },
                    { 370, "00879011879", "РАДОСЛАВА ДИМИТРОВА ЕВТИМОВА", (byte)2, null, "2831", null, null, null },
                    { 371, "00888863004", "АННА СТОЯНОВА ЙОРДАНОВА", (byte)2, null, "085010", null, null, null },
                    { 372, "00888201754", "ПАВЕЛ ВЕНЦИСЛАВОВ РАДУЛОВ", (byte)2, "6882", "2436", null, null, null },
                    { 373, "00899720158", "ЛЮБОМИР СТОЯНОВ ШЕХТОВ", (byte)2, null, "3760", null, null, null },
                    { 374, "00899359444", "БОЯН БОЙЧЕВ ДИМИТРОВ", (byte)2, null, "2178", "00889500409", null, null },
                    { 375, "00886617876", "НАТАЛИЯ ИГНАТОВА ПЕТРОВА", (byte)2, null, "2198", null, null, null },
                    { 376, "00888011886", "ЯНИСЛАВ ВАЛЕНТИНОВ ЦУРОВ", (byte)2, null, "2044", null, null, null },
                    { 377, "00893020062", "КРЪСТЬО ВЕНКОВ РУЙНОВ", (byte)2, null, "2566", null, null, null },
                    { 378, "00889067874", "ЕЛЕНА АНТОНЧОВА АТАНАСОВА", (byte)2, "2550", "3385", null, null, null },
                    { 379, "00878555377", "БОЙКО ЦВЕТАНОВ ЛИКУРИЕВ", (byte)2, "6964", "3060", null, null, null },
                    { 380, "00884766360", "ИВАН КОЧЕВ НЕЧКОВ", (byte)2, "4380", "2051", null, null, null },
                    { 381, "00883307493", "МИТКО АНТОНОВ МИЛЬОВСКИ", (byte)2, null, "2198", null, null, null },
                    { 382, "00888779843", "СТАНИСЛАВ КОЛЕВ СЪМЕНОВ", (byte)2, null, "3256", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 384, "00889363889", "НАДЯ ПЕТРОВА АНГЕЛОВА", (byte)2, null, "3095", null, null, null },
                    { 386, "00884161676", "ПЛАМЕН ГЕОРГИЕВ МАРГОЕВСКИ", (byte)2, "6880", "3560", null, null, null },
                    { 387, "00888489962", "ИВАН ГЕОРГИЕВ ВАСИЛЕВ", (byte)2, null, "3626", null, null, null },
                    { 388, "00888998686", "ВАЛЕНТИН ГЕОРГИЕВ  АВРАМОВ", (byte)2, null, "2091", null, null, null },
                    { 389, "00888253249", "ДИМИТЪР ЛЪЧЕЗАРОВ ЛАЗАРОВ", (byte)2, "2550", "3385", null, null, null },
                    { 390, "00894030302", "ДЕСИСЛАВА СТОЯНОВА ЗАНЕВА", (byte)2, null, "2036", null, null, null },
                    { 391, "00887178680", "ОЛГА НИКОЛАЕВНА МАРИНОВА", (byte)2, null, "2821", "00889709670", null, null },
                    { 392, "00878756315", "СТАНИСЛАВ МИХАЙЛОВ ЙОРДАНОВ", (byte)2, null, "2566", null, null, null },
                    { 393, "00878580042", "СЛАВЯН ПЕТРОВ ЛАЧЕВ", (byte)2, null, "2453", null, null, null },
                    { 394, "00884318456", "СРЕБРИН ТОШКОВ КОЛЕВ", (byte)2, null, "2248", null, null, null },
                    { 395, "00886852443", "ПЛАМЕН СИМЕОНОВ ТОШЕВ", (byte)2, null, "3256", null, null, null },
                    { 396, "00888137985", "ТИХОМИР АНГЕЛОВ ТРИФОНОВ", (byte)2, null, "5764", null, null, null },
                    { 397, "00895707853", "СВЕТЛОМИР ЕМАНУИЛОВ МИТКОВ", (byte)2, null, "2098", "00879979663", null, null },
                    { 398, "00889750006", "ВИОЛЕТА ИГНАТОВА ВЛАШКА", (byte)2, null, "4354", null, null, null },
                    { 399, "00886150206", "МИГЛЕНА ПЛАМЕНОВА ВЪРБАНОВА", (byte)2, null, "3935", null, null, null },
                    { 400, "00887628607", "РУМЕН ХРИСТОВ НЕДЯЛКОВ", (byte)2, "6498", "6638", null, null, null },
                    { 401, "00878456695", "БИСЕР ИВАНОВ БОРИСОВ", (byte)2, "6294", "3731", null, null, null },
                    { 402, "00885133165", "АНАТОЛИ ПЕТРОВ ИЛИЕВ", (byte)2, null, "2566", null, null, null },
                    { 403, "00885166888", "ИРИНА ВИЛИЯНОВА ИВАНОВА", (byte)2, "3385", "2550", null, null, null },
                    { 404, "00896859941", "ПЛАМЕН ЦЕНОВ ПЕТКОВ", (byte)2, "6963", "3342", null, null, null },
                    { 405, "00886838684", "АНТОН ЦАНКОВ ЦАРЯНСКИ", (byte)2, "4208", "6624", null, null, null },
                    { 407, "00878930117", "ВЛАДИСЛАВ ЦВЕТАНОВ ЯНЬОВСКИ", (byte)2, null, "3633", null, null, null },
                    { 408, "00877348884", "РУМЕН ЦЕНКОВ ДРАГАНОВ", (byte)2, null, "3494", null, null, null },
                    { 409, "00899688175", "НАТАЛИЯ НИКОЛАЕВА НИКОЛОВА", (byte)2, null, "3436", null, null, null },
                    { 410, "00889188997", "РУМЕН ДЕКОВ КОШУТАНСКИ", (byte)2, null, "3635", null, null, null },
                    { 411, "00896315325", "ВАЛЕРИ ЙОНЧЕВ ГЕОРГИЕВ", (byte)2, null, null, "2056", null, null },
                    { 412, "00888882674", "АНГЕЛ АЛЕКСАНДРОВ ЗАХАРИЕВ", (byte)2, "3445", "3024", null, null, null },
                    { 414, "00899580635", "ПЛАМЕН ПЕТРОВ ПАРАСКЕВОВ", (byte)2, null, "3529", null, null, null },
                    { 415, "00888196437", "ДЕСИСЛАВА СИМЕОНОВА ЦОЛОВА", (byte)2, null, "2831", null, null, null },
                    { 416, "00889741056", "ЕЛЕОНОРА КРУМОВА ПЕТКОВА", (byte)2, null, "2026", null, null, null },
                    { 417, "00878756313", "СТОЯН ЙОРДАНОВ ПЕТРОВ", (byte)2, null, "2692", null, null, null },
                    { 418, "00888397879", "ДИАНА ИВАНОВА КАШЕВА", (byte)2, null, "2667", null, null, null },
                    { 419, "00887593459", "РОСЕН ЛЮБЕНОВ ЛАЗАРОВ", (byte)2, null, "2566", null, null, null },
                    { 420, "8062", "РАДИОУРЕДБА НЦУА", (byte)1, null, null, null, null, null },
                    { 421, null, "КП НЦУА", (byte)1, null, null, null, null, null },
                    { 422, "00886890937", "ИВАН ПЕТРОВ ИВАНОВ", (byte)2, null, "3612", null, null, null },
                    { 423, "00885228996", "СОНЯ ИЛМАНОВА МОШОЛОВА", (byte)2, null, "3590", null, null, null },
                    { 424, "00887739653", "ГАЛЯ ЦВЕТАНОВА ЧЕРГАНСКА", (byte)2, "3389", "2269", null, null, null },
                    { 425, "00877341122", "МИРОСЛАВ КРУМОВ ВЪЛЧЕВ", (byte)2, null, "2337", null, null, null },
                    { 426, "00887595810", "СЕРЬОЖА ИВАНОВ ПУНГОВ", (byte)2, null, "2056", "00878637300", null, null },
                    { 427, "00889004024", "ТИХОМИР ИВОВ ПЕТРОВ", (byte)2, null, "3560", null, null, null },
                    { 428, "00878350007", "НЕЛИ ТАНЕВА КОСТОВА", (byte)2, null, "3529", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 430, "00884493539", "ОГНЯН ПЛАМЕНОВ СТЕФАНОВ", (byte)2, null, "3806", null, null, null },
                    { 431, "00888203841", "МИРОСЛАВ ГЕОРГИЕВ ГЕОРГИЕВ", (byte)2, null, "2566", null, null, null },
                    { 432, "00888887163", "СТИЛЯН КРАСИМИРОВ ПАСКОВ", (byte)2, null, "4280", null, null, null },
                    { 434, "00878680200", "АЛЕКСАНДЪР ЕМИЛОВ ДИМИТРОВ", (byte)2, null, "4244", null, null, null },
                    { 435, "00885716671", "ЛЮБОМИРА АНГЕЛОВА ТРИФОНОВА", (byte)2, null, "3436", null, null, null },
                    { 436, "8051", "STK TESTOBJECT", (byte)1, null, null, null, null, null },
                    { 437, "00899110633", "КРАСИМИР СТЕФАНОВ КРЪСТЕВ", (byte)2, null, "2056", null, null, null },
                    { 438, "00888219372", "НИКОЛАЙ БОРИСОВ ГЕРЧЕВ", (byte)2, null, "3328", null, null, null },
                    { 440, "00887510020", "ГАБРИЕЛ БОРИСЛАВОВ СТАМЕНОВ", (byte)2, null, "6252", null, null, null },
                    { 443, "00889210224", "ДАРИНА ХРИСТОВА ДИМИТРОВА", (byte)2, null, "4554", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "NOT_POSITIONS",
                columns: new[] { "POSITION_ID", "POSITION_DESCR", "POSITION_NAME" },
                values: new object[,]
                {
                    { 1, "Ръководител на аварийните работи", "ГР1" },
                    { 2, "Заместник ръководител на аварийните работи", "ГР2" },
                    { 3, "Ръководител Група за анализи и прогнози", "ГР3" },
                    { 4, "Ръководител Радиационен контрол", "ГР4" },
                    { 5, "Ръководител Спасителни служби", "ГР5" },
                    { 6, "Ръководител Служби за поддръжка", "ГР6" },
                    { 7, "Главен секретар", "ГР7" },
                    { 8, "Технически секретар", "ГР8" },
                    { 9, "Специалист Анализ и оценка", "ГАП1" },
                    { 10, "Специалист Реакторно физични разчети", "ГАП2" },
                    { 11, "Специалист Контролиращ физик", "ГАП3" },
                    { 12, "Специалист Електрооборудване", "ГАП4" },
                    { 13, "Специалист СКУ", "ГАП5" },
                    { 14, "Специалист Реакторно оборудване", "ГАП6" },
                    { 15, "Специалист Турбинно оборудване", "ГАП7" },
                    { 16, "Специалист СКиХТС", "ГАП8" },
                    { 17, "Специалист Химия", "ГАП9" },
                    { 18, "Специалист Радиохимия", "ГАП10" },
                    { 19, "Специалист ХОГ", "ГАП11" },
                    { 20, "Специалист ОРУ", "ГАП12" },
                    { 21, "Специалист Прогнози на рад. последствия", "РК1" },
                    { 22, "Специалист АИСВРК и СММ", "РК2" },
                    { 23, "Дозиметрист Мониторинг на площадката", "РК3" },
                    { 24, "Спациалист Радиационен мониторинг на ЗНЗМ", "РК4" },
                    { 25, "Дозиметрист Мониторинг на площадката", "РК5" },
                    { 26, "Специалист Радиационен мониторинг на ОС", "РК6" },
                    { 27, "Специалист Анализ на проби от ОС", "РК7" },
                    { 28, "Дозиметрист ТЛД", "РК8" },
                    { 29, "Дозиметрист ИДК", "РК9" },
                    { 30, "Специалист Цифрови комуникационни с-ми", "Г-ЦУА1" },
                    { 31, "Оператор СТК", "Г-ЦУА2" },
                    { 32, "Оператор Радиокомуникационни с-ми", "Г-ЦУА3" }
                });

            migrationBuilder.InsertData(
                table: "NOT_POSITIONS",
                columns: new[] { "POSITION_ID", "POSITION_DESCR", "POSITION_NAME" },
                values: new object[,]
                {
                    { 33, "Специалист ИСиКТ ЦУА", "Г-ЦУА4" },
                    { 34, "Отговорник Първа долекарска помощ ЦУА", "Г-ЦУА5" },
                    { 35, "Специалист Вентилационни системи ЦУА", "Г-ЦУА6" },
                    { 36, "Специалист Дизел агрегат ЦУА", "Г-ЦУА7" },
                    { 37, "Специалист Връзки с обществеността", "Г-ЦУА8" },
                    { 38, "Специалист Техническа поддръжка на ИИЦ", "Г-ЦУА9" },
                    { 39, "Специалист Дежурен в Дом на енергетика", "Г-ЦУА10" },
                    { 40, "Специалист Дизел агрегат ПРУ-ИЛК", "Г-ЦУА11" },
                    { 41, "Група Автотранспорт - оперативен дежурен", "Г-АТ1" },
                    { 42, "Група Автотранспорт - водач на автобус", "Г-АТ2" },
                    { 43, "Група Автотранспорт - водач на лек автомобил", "Г-АТ3" },
                    { 44, "Група Автотранспорт - водач на влекач", "Г-АТ4" },
                    { 45, "Група Автотранспорт - водач па трактор", "Г-АТ5" }
                });

            migrationBuilder.InsertData(
                table: "NOT_PROCES_STATES",
                columns: new[] { "ST_ID", "ST_DESC" },
                values: new object[,]
                {
                    { (byte)0, "В процес на оповестяване" },
                    { (byte)1, "Успешно приключил" },
                    { (byte)2, "Прекратен процес" },
                    { (byte)3, "Незапочнал процес" }
                });

            migrationBuilder.InsertData(
                table: "NOT_PULTS",
                columns: new[] { "PULT_ID", "PULT_DESCR", "PULT_IP", "PULT_NAME", "PULT_NUMBER" },
                values: new object[,]
                {
                    { 1, "КП ЦУА", "10.10.0.31", "КП ЦУА", "8100" },
                    { 2, "КП СТК", "10.10.0.51", "КП СТК", "8101" },
                    { 3, "КП БЩУ 5", "172.16.1.250", "КП БЩУ 5", "8102" },
                    { 4, "КП ГД АЕЦ", "10.10.0.81", "КП ГД АЕЦ", "8103" },
                    { 5, "КП БЩУ 6", "172.16.1.251", "КП БЩУ 6", "8104" },
                    { 6, "КП СИМУЛАТОР", "10.10.0.251", "КП СИМУЛАТОР", "8105" },
                    { 7, "PRIZM", "10.10.0.6", "PRIZM", "1111" },
                    { 8, "КП СТК Тест", "172.31.98.196", "КП СТК Тест", "8106" },
                    { 9, "КП Мизия", "10.10.1.108", "КП МИЗИЯ", "8053" },
                    { 10, "КП Козлодуй", "10.10.1.109", "КП КОЗЛОДУЙ", "8054" },
                    { 11, "КП НЦУА", "10.10.0.53", "КП НЦУА", "8107" }
                });

            migrationBuilder.InsertData(
                table: "NOT_STATUS_PHONE_STATES",
                columns: new[] { "ST_ID", "ST_DESC" },
                values: new object[,]
                {
                    { (byte)0, "" },
                    { (byte)1, "Оповестен" },
                    { (byte)2, "" },
                    { (byte)3, "Не вдигнал" },
                    { (byte)4, "Заето" },
                    { (byte)5, "Невалиден номер" },
                    { (byte)6, "Липса на ресурси" },
                    { (byte)7, "Изчерпан лимит" }
                });

            migrationBuilder.InsertData(
                table: "NOT_STATUS_STATES",
                columns: new[] { "ST_ID", "ST_DESC" },
                values: new object[,]
                {
                    { (byte)0, "Неуспешно оповестяване" },
                    { (byte)1, "Успешно оповестяване" },
                    { (byte)2, "Прекратен" },
                    { (byte)3, "Незапочнал процес" },
                    { (byte)4, "N/A" },
                    { (byte)5, "Невалиден номер/a" }
                });

            migrationBuilder.InsertData(
                table: "NOT_STATUS_STATES",
                columns: new[] { "ST_ID", "ST_DESC" },
                values: new object[,]
                {
                    { (byte)6, "Празен обект" },
                    { (byte)7, "Изчерпан лимит" }
                });

            migrationBuilder.InsertData(
                table: "NO_TYPES",
                columns: new[] { "NO_TYPE_ID", "NO_TYPE_DESCRIPTION" },
                values: new object[,]
                {
                    { (byte)1, "Оповестителен обект" },
                    { (byte)2, "Лице" },
                    { (byte)3, "Сигнал 2" },
                    { (byte)4, "Радио уредба" }
                });

            migrationBuilder.InsertData(
                table: "NPR_TYPES",
                columns: new[] { "NTP_ID", "NTP_DESCRIPTION" },
                values: new object[,]
                {
                    { 1, "Радиоактивно Замърсяване" },
                    { 2, "Химическа Опасност" },
                    { 3, "Опасност от наводнение" },
                    { 4, "Въздушна опасност" },
                    { 5, "Отбой" },
                    { 6, "Гласово съобщение" },
                    { 7, "N/A" },
                    { 8, "N/A" },
                    { 9, "Техническа проверка" },
                    { 10, "Техническа проверка по аварийния план" },
                    { 11, "N/A" },
                    { 12, "N/A" },
                    { 13, "N/A" },
                    { 14, "N/A" },
                    { 15, "N/A" },
                    { 16, "N/A" },
                    { 17, "N/A" },
                    { 18, "N/A" },
                    { 19, "N/A" },
                    { 20, "N/A" },
                    { 21, "N/A" },
                    { 22, "N/A" },
                    { 23, "N/A" },
                    { 24, "N/A" },
                    { 25, "N/A" },
                    { 26, "N/A" },
                    { 27, "N/A" },
                    { 28, "N/A" },
                    { 29, "N/A" },
                    { 30, "N/A" },
                    { 31, "N/A" },
                    { 32, "N/A" },
                    { 33, "N/A" },
                    { 34, "N/A" },
                    { 35, "N/A" },
                    { 36, "N/A" }
                });

            migrationBuilder.InsertData(
                table: "NPR_TYPES",
                columns: new[] { "NTP_ID", "NTP_DESCRIPTION" },
                values: new object[,]
                {
                    { 37, "N/A" },
                    { 38, "N/A" },
                    { 39, "N/A" },
                    { 40, "N/A" },
                    { 41, "Тревога Козлодуй/Мизия" },
                    { 42, "Въздушна опасност Козлодуй/Мизия" },
                    { 43, "Отбой Козлодуй/Мизия" },
                    { 44, "N/A" },
                    { 45, "N/A" },
                    { 46, "N/A" },
                    { 47, "N/A" },
                    { 48, "N/A" },
                    { 49, "N/A" },
                    { 50, "N/A" },
                    { 51, "N/A" },
                    { 52, "N/A" },
                    { 53, "N/A" },
                    { 54, "N/A" },
                    { 55, " " },
                    { 56, " " },
                    { 57, " " },
                    { 58, " " },
                    { 59, " " },
                    { 60, " " },
                    { 61, " " },
                    { 62, " " },
                    { 63, " " },
                    { 64, " " },
                    { 65, " " },
                    { 66, " " },
                    { 67, " " },
                    { 68, " " },
                    { 69, " " },
                    { 70, " " },
                    { 71, " " },
                    { 72, " " },
                    { 73, " " },
                    { 74, " " },
                    { 75, " " },
                    { 76, " " },
                    { 77, " " },
                    { 78, " " }
                });

            migrationBuilder.InsertData(
                table: "NPR_TYPES",
                columns: new[] { "NTP_ID", "NTP_DESCRIPTION" },
                values: new object[,]
                {
                    { 79, " " },
                    { 80, " " },
                    { 81, "Техническа проверка" },
                    { 82, " " },
                    { 83, " " },
                    { 84, " " },
                    { 85, " " },
                    { 86, " " },
                    { 87, " " },
                    { 88, " " },
                    { 89, " " },
                    { 90, " " },
                    { 91, "N/A" },
                    { 92, "N/A" },
                    { 93, "N/A" },
                    { 94, "N/A" },
                    { 95, "N/A" },
                    { 96, "N/A" },
                    { 97, "N/A" },
                    { 98, "N/A" },
                    { 99, "N/A" },
                    { 100, "N/A" },
                    { 101, "Техническа проверка" },
                    { 102, "Локална авария. Укриване." },
                    { 103, "Местна авария. Укриване" },
                    { 104, "Местна авария. Укриване и йодна профилактика." },
                    { 105, "Местна авария. Евакуация" },
                    { 106, "Местна авария. Евакуация и йодна профилактика." },
                    { 107, "Обща авария. Укриване и йодна профилактика." },
                    { 108, "Обща авария. Евакуация и йодна профилактика." },
                    { 109, "Местна авария. Укриване на населението." },
                    { 110, "Край на аварийната обстановка." },
                    { 111, "Общо аварийното учение." },
                    { 112, "Край на аварийното учение." },
                    { 113, "Локална авария без радиоактивно замърсяване." },
                    { 114, "Обща авария с опасност от радиоактивно замърсяване." },
                    { 115, "Резервен авариен екип." },
                    { 116, "Сборен пункт на резервния авариен екип." },
                    { 117, "Техническа проверка. Лица." },
                    { 118, "Аварийна тренировка. Оповестяване лица и сандружина." },
                    { 119, "Аварийна ситуация. Оповестяване лица и сандружина." },
                    { 120, "Локална авария. Евакуация." }
                });

            migrationBuilder.InsertData(
                table: "NPR_TYPES",
                columns: new[] { "NTP_ID", "NTP_DESCRIPTION" },
                values: new object[,]
                {
                    { 121, "-" },
                    { 122, "N/A" },
                    { 123, "N/A" },
                    { 124, "N/A" },
                    { 125, "N/A" },
                    { 126, "N/A" },
                    { 127, "N/A" },
                    { 128, "N/A" },
                    { 129, "N/A" },
                    { 130, "-" },
                    { 131, "-" },
                    { 132, "-" },
                    { 133, "-" },
                    { 134, "02.06 Въздушна опасност" },
                    { 135, "Тест НСРПО" },
                    { 136, "Общо аварийно учение" },
                    { 137, "Общо аварийно учение Сандружина" },
                    { 138, "Аварийна тренировка" },
                    { 139, "-" },
                    { 140, "-" },
                    { 141, "Начало аварийно учение Защита 2014" },
                    { 142, "Аварийно учение. Евакуация" },
                    { 143, "Край аварийно учение Защита 2014" }
                });

            migrationBuilder.InsertData(
                table: "STATUS_STATES",
                columns: new[] { "ST_ID", "ST_DESC" },
                values: new object[,]
                {
                    { (byte)0, "Започнал процес" },
                    { (byte)1, "Приключил процес" },
                    { (byte)2, "Прекратен" },
                    { (byte)3, "Незапочнал процес" },
                    { (byte)4, "N/A" },
                    { (byte)5, "Невалиден номер/a" },
                    { (byte)6, "Празен обект" },
                    { (byte)7, "Изчерпан лимит" }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 38, "00879890711", "АНТОАНЕТА ВАЛЕНТИНОВА КЯТИНА", (byte)2, null, "2623", null, 8, null },
                    { 41, "00888906258", "ЕМИЛИЯН ГЕОРГИЕВ ЕДРЕВ", (byte)2, "6263", "2763", null, 1, null },
                    { 45, "00888991362", "ВАЛЕНТИНА КОЛЕВА СТАНЧЕВА", (byte)2, null, "3607", null, 4, null },
                    { 46, "00878203811", "ВАЛЕНТИН ТОШКОВ ВЛАДИНОВ", (byte)2, null, "3850", "00888203810", 5, null },
                    { 55, "00879503105", "МИРОСЛАВ БОЖИДАРОВ БУКОЕВ", (byte)2, null, "3895", "00887799069", 5, null },
                    { 57, "00888829896", "ЕМИЛИЯ АНГЕЛОВА ДОНЧЕВА", (byte)2, null, "6548", null, 7, null },
                    { 58, "00888616787", "ДАНИЕЛА ГЕОРГИЕВА ЦВЕТАНОВА", (byte)2, null, "6643", null, 8, null },
                    { 76, "00888622227", "НИКОЛАЙ ПЕТРОВ БОНОВ", (byte)2, null, "6277", "00888141400", 6, null },
                    { 100, "00898858800", "БИСЕР ЙОРДАНОВ ТОДОРОВ", (byte)2, null, "4277", null, 6, null },
                    { 104, "00888012119", "РУМЕН ДИМИТРОВ ХРИСТОВ", (byte)2, "6959", "3367", "00879979660", 2, null },
                    { 109, "00886144221", "СТОЯН ЛЮБОМИРОВ КРЪСТЕВ", (byte)2, null, "2677", null, 6, null },
                    { 130, "00888662560", "ДАРИН СИМЕОНОВ СТОЕВ", (byte)2, null, "4218", null, 3, null },
                    { 132, "00888407409", "КРАСЕН ПЕТКОВ РАШКОВ", (byte)2, null, "2050", null, 3, null },
                    { 136, "00888213061", "ЕМИЛ МАРИНОВ СТЕФАНОВ", (byte)2, null, "6196", null, 7, null },
                    { 137, "00889717231", "ВАЛЕРИ СЛАВЧЕВ МИЛОШЕВ", (byte)2, "6677", "6676", "00886113758", 2, null },
                    { 139, "00888799197", "ОГНЯН ДИМИТРОВ КАМЕНОВ", (byte)2, null, "2581", "00878555442", 5, null },
                    { 150, "00889500377", "ПЕТЪР БОРИСОВ ДОНЧЕВ", (byte)2, null, "3624", null, 2, null },
                    { 154, "00887497631", "ИСКРЕН ГЕОРГИЕВ КОЕВ", (byte)2, null, "3824", null, 6, null },
                    { 158, "00886817903", "ВЕСЕЛИН ИВАНОВ НИКОЛОВ", (byte)2, null, "6189", null, 7, null },
                    { 163, "00888575664", "КАТЕРИНА КОЛЕВА КОСТАДИНОВА", (byte)2, null, "4412", null, 4, null },
                    { 166, "00888140867", "ОРЛИН САШКОВ СТОЯНОВ", (byte)2, null, "2143", null, 4, null },
                    { 167, "00899815620", "ОЛЕСЯ ВИКТОРОВНА ЙОРДАНОВА", (byte)2, null, "2536", null, 4, null },
                    { 169, "00889504858", "ХРИСТО КЪНЧЕВ ХРИСТОВ", (byte)2, "6237", "3098", "00889500368", 3, null },
                    { 170, "00879996699", "АЛЕКСАНДЪР ХРИСТОВ НИКОЛОВ", (byte)2, null, "6333", null, 1, null },
                    { 179, "00888903537", "ДАРИУШ МАРЕК НОВАК", (byte)2, "6016", "3870", "00888000116", 1, null },
                    { 183, "00898490868", "АЛЕКСАНДЪР ИВАНОВ КАЗАКОВ", (byte)2, null, "2629", "00889655090", 5, null },
                    { 184, "00884673777", "ВИОЛИН ПЕТРОВ РАЙКОВ", (byte)2, null, "2899", "00878858403", 5, null },
                    { 185, "00896844850", "СТИЛЯНА ТОДОРОВА МЛАДЕНОВА", (byte)2, null, "3880", null, 2, null },
                    { 256, "00887443238", "АТАНАС ГЕОРГИЕВ АТАНАСОВ", (byte)2, "6600", "3281", null, 1, null },
                    { 260, "00888887172", "АНТОН ПАВЛОВ СТОИЛОВ", (byte)2, null, "3286", null, 3, null },
                    { 263, "00885043410", "ВЯРА НИКОЛАЕВА ИЛИЕВА", (byte)2, null, "2020", null, 8, null },
                    { 265, "00883539953", "МИГЛЕНА ГЕОРГИЕВА ЦВЕТКОВСКА", (byte)2, null, "2020", null, 8, null },
                    { 274, "00899857570", "ДИМИТЪР ИГНАТОВ ПИРЧЕВ", (byte)2, null, "2743", null, 6, null },
                    { 276, "00878838112", "ЦВЕТАН КРЪСТЕВ МАРИНОВ", (byte)2, "6984", "2723", null, 4, null },
                    { 284, "00888833132", "БОЯН ВЕНЕЛИНОВ КОЛИНОВ", (byte)2, null, "2060", "00879554305", 1, null },
                    { 285, "00887545956", "СВЕТОСЛАВ ИВАИЛОВ ЛАШКОВ", (byte)2, "6965", "3523", "00879963292", 2, null },
                    { 286, "00896868669", "СВЕТОСЛАВ ЕМИЛОВ НАЙДЕНОВ", (byte)2, null, "3730", null, 3, null },
                    { 287, "00887272987", "ЛЮДМИЛ АТАНАСОВ ЦОЛОВ", (byte)2, null, "3046", null, 4, null },
                    { 288, "00877225262", "РАДОСЛАВ КИРИЛОВ МАРИНОВ", (byte)2, null, "3494", null, 5, null },
                    { 290, "00889407815", "СОФИЯ КИРИЛОВА ПЕТКОВА", (byte)2, null, "3740", null, 8, null },
                    { 323, "00888272087", "МАРИЕЛА ЕМИЛОВА СТАМЕНОВА", (byte)2, null, "6100", null, 7, null },
                    { 339, "00879979661", "СВЕТОЗАР ИВАНОВ ВАСИЛЕВ", (byte)2, "2501", "3596", null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "NOTIFY_OBJECTS",
                columns: new[] { "NO_ID", "NO_INT_PHONE", "NO_NAME", "NO_TYPE", "NP_EXT_PHONE1", "NP_EXT_PHONE2", "NP_MOB_PHONE", "POSITION_ID", "PULT_ID" },
                values: new object[,]
                {
                    { 340, "00887435199", "КИРИЛ ВАНЬОВ КИРИЛОВ", (byte)2, null, "4162", null, 7, null },
                    { 349, "00888296771", "ВЛАДИМИР ВАСИЛЕВ ЯНКОВ", (byte)2, null, "2385", "00878889220", 5, null },
                    { 383, "00878352288", "ЕВГЕНИ ВАСИЛЕВ ГЪЛЪБОВ", (byte)2, null, "3144", null, 3, null },
                    { 385, "00888697974", "АНДРЕЙ АЛЕКСАНДРОВИЧ КРАСНОЧАРОВ", (byte)2, "6944", "3144", "00887002986", 3, null },
                    { 406, "00887732801", "ТАНЯ ТОДОРОВА ТОДОРОВА", (byte)2, null, "3580", null, 8, null },
                    { 413, "00879148122", "ЛИЛИЯН ГЕОРГИЕВ МЛАДЕНОВ", (byte)2, "6653", "6366", null, 2, null },
                    { 429, "00888910117", "ЯНКО ИВАНОВ ТОШЕВ", (byte)2, "6902", "3002", null, 1, null },
                    { 433, "00888697356", "КАМЕЛИЯ ПЕТРОВА КРАСНОЧАРОВА", (byte)2, null, "2792", null, 7, null },
                    { 439, "00882997889", "АНИТА АНАТОЛИЕВА ГЕОРГИЕВА", (byte)2, null, "2525", null, 8, null },
                    { 441, "00898732018", "НАДЯ ЧАВДАРОВА ЗАНЕВА", (byte)2, null, "6336", null, 8, null },
                    { 442, "00887421239", "БОЖИДАР ИВАНОВ РАЧЕВ", (byte)2, null, "6314", "00879148119", 7, null }
                });

            migrationBuilder.InsertData(
                table: "NOT_PROCESS",
                columns: new[] { "NPR_ID", "NG_ID", "NPR_CALL_ID", "NPR_DATE", "NPR_END_DATE", "NPR_FLAG", "NPR_HORN_ID", "NTP_ID", "PULT_NUMBER", "USR_ID" },
                values: new object[,]
                {
                    { 1, 30, "8602", new DateTime(2022, 2, 15, 11, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 11, 24, 42, 0, DateTimeKind.Unspecified), "1", true, 101, "8101", null },
                    { 2, 40, "8602", new DateTime(2022, 2, 15, 11, 30, 9, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 11, 32, 6, 0, DateTimeKind.Unspecified), "1", true, 101, "8100", null },
                    { 3, 20, "8601", new DateTime(2022, 2, 21, 14, 40, 1, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 14, 48, 53, 0, DateTimeKind.Unspecified), "1", false, 117, "8101", null }
                });

            migrationBuilder.InsertData(
                table: "NOT_STATUS",
                columns: new[] { "STAT_ID", "NO_ID", "NO_TYPE", "NPR_ID", "STAT_CALL_ID", "STAT_FLAG", "STAT_GET_FLAG", "STAT_INT_COUNT", "STAT_INT_FLAG", "STAT_INT_PHONE", "STAT_IN_CALL", "STAT_MOB_COUNT", "STAT_MOB_FLAG", "STAT_MOB_PHONE", "STAT_NOTIFICATION", "STAT_NUM_OF_CALLS", "STAT_PH1_COUNT", "STAT_PH1_FLAG", "STAT_PH2_COUNT", "STAT_PH2_FLAG", "STAT_PHONE1", "STAT_PHONE2" },
                values: new object[,]
                {
                    { 1, null, (byte)1, 1, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8062", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 2, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8061", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 3, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8001", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 4, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8002", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 5, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8003", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 6, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8004", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 7, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8005", (byte)0, (byte)0, (byte)0, null, (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, null, null },
                    { 8, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8006", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 9, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8007", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 10, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8008", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 11, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8009", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 12, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8010", (byte)0, (byte)0, (byte)0, null, (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, null, null },
                    { 13, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8012", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 14, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8014", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 15, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8015", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 16, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8017", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 17, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8018", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 18, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8019", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 19, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8021", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 20, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8022", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 21, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8023", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 22, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8024", (byte)0, (byte)0, (byte)0, null, (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, null, null },
                    { 23, null, (byte)1, 2, "8602", (byte)1, (byte)1, (byte)1, (byte)1, "8013", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "" },
                    { 24, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "2110", (byte)0, (byte)0, (byte)0, "6207", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "4461", "" },
                    { 25, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00885046435", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3915" },
                    { 26, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)3, "00888991362", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)2, (byte)0, (byte)0, (byte)1, (byte)1, "", "3607" },
                    { 27, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)4, "00897698897", (byte)0, (byte)1, (byte)1, "00878591131", (byte)1, (byte)2, (byte)0, (byte)0, (byte)0, (byte)0, "", "3775" },
                    { 28, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)2, (byte)1, "00888616787", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)2, (byte)0, (byte)0, (byte)0, (byte)0, "", "6643" },
                    { 29, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00879503102", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2517" },
                    { 30, null, (byte)2, 3, "8601", (byte)1, (byte)0, (byte)1, (byte)1, "00884143567", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)3, (byte)0, (byte)0, (byte)0, (byte)0, "", "3278" },
                    { 31, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00898334993", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "3385", "2550" },
                    { 32, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00884323423", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3471" },
                    { 33, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00885040374", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3208" },
                    { 34, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00888315516", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2273" },
                    { 35, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00898858800", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "4277" },
                    { 36, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00878682250", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3625" },
                    { 37, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00888288860", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3108" },
                    { 38, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00886089871", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "4552" },
                    { 39, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00886838687", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3612" },
                    { 40, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00888010909", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3386" },
                    { 41, null, (byte)2, 3, "8601", (byte)1, (byte)0, (byte)1, (byte)1, "00887099748", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)5, (byte)2, (byte)0, (byte)0, (byte)0, "6954", "2224" },
                    { 42, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00879996699", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "6333" }
                });

            migrationBuilder.InsertData(
                table: "NOT_STATUS",
                columns: new[] { "STAT_ID", "NO_ID", "NO_TYPE", "NPR_ID", "STAT_CALL_ID", "STAT_FLAG", "STAT_GET_FLAG", "STAT_INT_COUNT", "STAT_INT_FLAG", "STAT_INT_PHONE", "STAT_IN_CALL", "STAT_MOB_COUNT", "STAT_MOB_FLAG", "STAT_MOB_PHONE", "STAT_NOTIFICATION", "STAT_NUM_OF_CALLS", "STAT_PH1_COUNT", "STAT_PH1_FLAG", "STAT_PH2_COUNT", "STAT_PH2_FLAG", "STAT_PHONE1", "STAT_PHONE2" },
                values: new object[,]
                {
                    { 43, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00886046497", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3646" },
                    { 44, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00898490868", (byte)0, (byte)0, (byte)0, "00889655090", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2629" },
                    { 45, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00896828187", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2566" },
                    { 46, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00877566608", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2741" },
                    { 47, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00888012119", (byte)0, (byte)0, (byte)0, "00879979660", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "6959", "3367" },
                    { 48, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00879698852", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "5760", "5758" },
                    { 49, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00876051094", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2869" },
                    { 50, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)3, "00889920256", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)2, (byte)0, (byte)0, (byte)1, (byte)1, "", "3256" },
                    { 51, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)2, (byte)1, "00889990041", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)4, (byte)1, (byte)3, (byte)1, (byte)3, "2477", "2945" },
                    { 52, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)2, (byte)1, "00885708595", (byte)0, (byte)1, (byte)3, "00879911645", (byte)1, (byte)4, (byte)0, (byte)0, (byte)1, (byte)3, "", "2704" },
                    { 53, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00888879494", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "2556", "2056" },
                    { 54, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00896868669", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3730" },
                    { 55, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00889224450", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2065" },
                    { 56, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00879363800", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3935" },
                    { 57, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)2, (byte)1, "00889136326", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)2, (byte)0, (byte)0, (byte)0, (byte)0, "", "2091" },
                    { 58, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)3, "00898467220", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)2, (byte)0, (byte)0, (byte)1, (byte)1, "", "3436" },
                    { 59, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00888272087", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "6100" },
                    { 60, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00878386391", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2091" },
                    { 61, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)3, "00879438877", (byte)0, (byte)1, (byte)1, "00878756306", (byte)1, (byte)2, (byte)0, (byte)0, (byte)0, (byte)0, "", "2894" },
                    { 62, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00878807791", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2056" },
                    { 63, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00878677729", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "2510" },
                    { 64, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)1, (byte)1, "00878930117", (byte)0, (byte)0, (byte)0, "", (byte)1, (byte)1, (byte)0, (byte)0, (byte)0, (byte)0, "", "3633" },
                    { 65, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)3, (byte)7, "00888655124", (byte)0, (byte)0, (byte)0, "", (byte)7, (byte)9, (byte)0, (byte)0, (byte)3, (byte)7, "", "2768" },
                    { 66, null, (byte)2, 3, "8601", (byte)1, (byte)1, (byte)3, (byte)7, "00888797467", (byte)0, (byte)0, (byte)0, "", (byte)7, (byte)9, (byte)0, (byte)0, (byte)3, (byte)7, "", "3534" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NOTIFY_GROUPS",
                keyColumn: "NG_ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "NOTIFY_OBJECTS",
                keyColumn: "NO_ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NOT_PROCES_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)0);

            migrationBuilder.DeleteData(
                table: "NOT_PROCES_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "NOT_PROCES_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "NOT_PROCES_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NOT_PULTS",
                keyColumn: "PULT_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS",
                keyColumn: "STAT_ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)0);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)6);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_PHONE_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)7);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)0);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)6);

            migrationBuilder.DeleteData(
                table: "NOT_STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)7);

            migrationBuilder.DeleteData(
                table: "NO_TYPES",
                keyColumn: "NO_TYPE_ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "NO_TYPES",
                keyColumn: "NO_TYPE_ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "NO_TYPES",
                keyColumn: "NO_TYPE_ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "NO_TYPES",
                keyColumn: "NO_TYPE_ID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)0);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)6);

            migrationBuilder.DeleteData(
                table: "STATUS_STATES",
                keyColumn: "ST_ID",
                keyValue: (byte)7);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NOT_POSITIONS",
                keyColumn: "POSITION_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NOT_PROCESS",
                keyColumn: "NPR_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NOT_PROCESS",
                keyColumn: "NPR_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NOT_PROCESS",
                keyColumn: "NPR_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "NPR_TYPES",
                keyColumn: "NTP_ID",
                keyValue: 117);
        }
    }
}
