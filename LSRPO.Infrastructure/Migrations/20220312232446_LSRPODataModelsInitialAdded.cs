﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LSRPO.Infrastructure.Migrations
{
    public partial class LSRPODataModelsInitialAdded : Migration
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
                    USR_PASSWORD = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    IMAGE_URL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTH_USERS", x => x.USR_ID);
                });

            migrationBuilder.CreateTable(
                name: "NO_TYPES",
                columns: table => new
                {
                    NO_TYPE_ID = table.Column<byte>(type: "tinyint", nullable: false),
                    NO_TYPE_DESCRIPTION = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NO_TYPES", x => x.NO_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOT_PROCES_STATES",
                columns: table => new
                {
                    ST_ID = table.Column<byte>(type: "tinyint", nullable: false),
                    ST_DESC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_PROCES_STATES", x => x.ST_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOT_PULTS",
                columns: table => new
                {
                    PULT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PULT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PULT_DESCR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PULT_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PULT_NUMBER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_PULTS", x => x.PULT_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOT_STATUS_PHONE_STATES",
                columns: table => new
                {
                    ST_ID = table.Column<byte>(type: "tinyint", nullable: false),
                    ST_DESC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_STATUS_PHONE_STATES", x => x.ST_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOT_STATUS_STATES",
                columns: table => new
                {
                    ST_ID = table.Column<byte>(type: "tinyint", nullable: false),
                    ST_DESC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_STATUS_STATES", x => x.ST_ID);
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
                name: "NPR_TYPES",
                columns: table => new
                {
                    NTP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NTP_DESCRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPR_TYPES", x => x.NTP_ID);
                });

            migrationBuilder.CreateTable(
                name: "STATUS_STATES",
                columns: table => new
                {
                    ST_ID = table.Column<byte>(type: "tinyint", nullable: false),
                    ST_DESC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS_STATES", x => x.ST_ID);
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
                name: "NOTIFY_OBJECTS",
                columns: table => new
                {
                    NO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NO_INT_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NP_MOB_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NP_EXT_PHONE1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NP_EXT_PHONE2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NO_TYPE = table.Column<byte>(type: "tinyint", nullable: true),
                    PULT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTIFY_OBJECTS", x => x.NO_ID);
                    table.ForeignKey(
                        name: "FK_NOTIFY_OBJECTS_NOT_PULTS_PULT_ID",
                        column: x => x.PULT_ID,
                        principalTable: "NOT_PULTS",
                        principalColumn: "PULT_ID");
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

            migrationBuilder.CreateTable(
                name: "NOT_PROCESS",
                columns: table => new
                {
                    NPR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NPR_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NPR_FLAG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NG_ID = table.Column<int>(type: "int", nullable: true),
                    USR_ID = table.Column<int>(type: "int", nullable: true),
                    NTP_ID = table.Column<int>(type: "int", nullable: true),
                    PULT_NUMBER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NPR_END_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NPR_CALL_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NPR_HORN_ID = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_PROCESS", x => x.NPR_ID);
                    table.ForeignKey(
                        name: "FK_NOT_PROCESS_NPR_TYPES_NTP_ID",
                        column: x => x.NTP_ID,
                        principalTable: "NPR_TYPES",
                        principalColumn: "NTP_ID");
                });

            migrationBuilder.CreateTable(
                name: "NG_NP",
                columns: table => new
                {
                    NGNP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NG_ID = table.Column<int>(type: "int", nullable: false),
                    NO_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NG_NP", x => x.NGNP_ID);
                    table.ForeignKey(
                        name: "FK_NG_NP_NOTIFY_GROUPS_NG_ID",
                        column: x => x.NG_ID,
                        principalTable: "NOTIFY_GROUPS",
                        principalColumn: "NG_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NG_NP_NOTIFY_OBJECTS_NO_ID",
                        column: x => x.NO_ID,
                        principalTable: "NOTIFY_OBJECTS",
                        principalColumn: "NO_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NOT_STATUS",
                columns: table => new
                {
                    STAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STAT_FLAG = table.Column<byte>(type: "tinyint", nullable: true),
                    NPR_ID = table.Column<int>(type: "int", nullable: true),
                    STAT_INT_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STAT_INT_COUNT = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_INT_FLAG = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_MOB_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STAT_MOB_COUNT = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_MOB_FLAG = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_PHONE1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STAT_PH1_COUNT = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_PH1_FLAG = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_PHONE2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STAT_PH2_COUNT = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_PH2_FLAG = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_NOTIFICATION = table.Column<byte>(type: "tinyint", nullable: true),
                    NO_ID = table.Column<int>(type: "int", nullable: true),
                    STAT_CALL_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NO_TYPE = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_IN_CALL = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_GET_FLAG = table.Column<byte>(type: "tinyint", nullable: true),
                    STAT_NUM_OF_CALLS = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOT_STATUS", x => x.STAT_ID);
                    table.ForeignKey(
                        name: "FK_NOT_STATUS_NOT_PROCESS_NPR_ID",
                        column: x => x.NPR_ID,
                        principalTable: "NOT_PROCESS",
                        principalColumn: "NPR_ID");
                    table.ForeignKey(
                        name: "FK_NOT_STATUS_NOTIFY_OBJECTS_NO_ID",
                        column: x => x.NO_ID,
                        principalTable: "NOTIFY_OBJECTS",
                        principalColumn: "NO_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NG_NP_NG_ID",
                table: "NG_NP",
                column: "NG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NG_NP_NO_ID",
                table: "NG_NP",
                column: "NO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NG_USR_NG_ID",
                table: "NG_USR",
                column: "NG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NG_USR_USR_ID",
                table: "NG_USR",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOT_PROCESS_NTP_ID",
                table: "NOT_PROCESS",
                column: "NTP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOT_STATUS_NO_ID",
                table: "NOT_STATUS",
                column: "NO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOT_STATUS_NPR_ID",
                table: "NOT_STATUS",
                column: "NPR_ID");

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

            migrationBuilder.CreateIndex(
                name: "IX_NOTIFY_OBJECTS_PULT_ID",
                table: "NOTIFY_OBJECTS",
                column: "PULT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NG_NP");

            migrationBuilder.DropTable(
                name: "NG_USR");

            migrationBuilder.DropTable(
                name: "NO_TYPES");

            migrationBuilder.DropTable(
                name: "NOT_PROCES_STATES");

            migrationBuilder.DropTable(
                name: "NOT_STATUS");

            migrationBuilder.DropTable(
                name: "NOT_STATUS_PHONE_STATES");

            migrationBuilder.DropTable(
                name: "NOT_STATUS_STATES");

            migrationBuilder.DropTable(
                name: "NOT_USERS_PIN");

            migrationBuilder.DropTable(
                name: "STATUS_STATES");

            migrationBuilder.DropTable(
                name: "NOTIFY_GROUPS");

            migrationBuilder.DropTable(
                name: "NOT_PROCESS");

            migrationBuilder.DropTable(
                name: "NOTIFY_OBJECTS");

            migrationBuilder.DropTable(
                name: "AUTH_USERS");

            migrationBuilder.DropTable(
                name: "NPR_TYPES");

            migrationBuilder.DropTable(
                name: "NOT_PULTS");
        }
    }
}
