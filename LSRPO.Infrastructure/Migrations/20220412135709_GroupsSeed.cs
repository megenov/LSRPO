using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LSRPO.Infrastructure.Migrations
{
    public partial class GroupsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NOTIFY_GROUPS",
                columns: new[] { "NG_ID", "NG_DESCRIPTION", "NG_MOD_FLAG", "NG_NAME", "NG_NUMBER", "NG_REG_DATE" },
                values: new object[,]
                {
                    { 1, "Площадка", false, "Зона АЕЦ", "8811", null },
                    { 2, "Площадка АЕЦ + 12км. зона", false, "12км. АЕЦ", "8812", null },
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
        }
    }
}
