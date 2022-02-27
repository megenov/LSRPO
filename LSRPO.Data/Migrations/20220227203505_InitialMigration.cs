using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LSRPO.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AUTH_USERS",
                columns: table => new
                {
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_USERNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    USR_REG_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USR_FULLNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    USR_EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    USR_PASSWORD = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTH_USERS", x => x.USR_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOTIFY_GROUPS",
                columns: table => new
                {
                    NG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NG_REG_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NG_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NG_DESCRIPTION = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    NG_NUMBER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NG_MOD_FLAG = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTIFY_GROUPS", x => x.NG_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOT_USERS_PIN",
                columns: table => new
                {
                    NOT_USR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_PIN = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    USR_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_USERS_PIN", x => x.NOT_USR_ID);
                    table.ForeignKey(
                        name: "FK_NOT_USERS_PIN_AUTH_USERS_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "AUTH_USERS",
                        principalColumn: "USR_ID");
                });

            migrationBuilder.CreateTable(
                name: "NG_USR",
                columns: table => new
                {
                    NG_USR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NG_ID = table.Column<int>(type: "int", nullable: true),
                    USR_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NG_USR", x => x.NG_USR_ID);
                    table.ForeignKey(
                        name: "FK_NG_USR_AUTH_USERS_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "AUTH_USERS",
                        principalColumn: "USR_ID");
                    table.ForeignKey(
                        name: "FK_NG_USR_NOTIFY_GROUPS_NG_ID",
                        column: x => x.NG_ID,
                        principalTable: "NOTIFY_GROUPS",
                        principalColumn: "NG_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NG_USR_NG_ID",
                table: "NG_USR",
                column: "NG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NG_USR_USR_ID",
                table: "NG_USR",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOT_USERS_PIN_USR_ID",
                table: "NOT_USERS_PIN",
                column: "USR_ID",
                unique: true,
                filter: "[USR_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NOT_USERS_PIN_USR_PIN",
                table: "NOT_USERS_PIN",
                column: "USR_PIN",
                unique: true,
                filter: "[USR_PIN] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NG_USR");

            migrationBuilder.DropTable(
                name: "NOT_USERS_PIN");

            migrationBuilder.DropTable(
                name: "NOTIFY_GROUPS");

            migrationBuilder.DropTable(
                name: "AUTH_USERS");
        }
    }
}
