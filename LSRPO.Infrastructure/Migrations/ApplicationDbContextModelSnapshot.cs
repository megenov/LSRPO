﻿// <auto-generated />
using System;
using LSRPO.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LSRPO.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.AUTH_ROLE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.AUTH_USER", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("IMAGE_URL")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("USR_FULLNAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("USR_REG_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NG_NP", b =>
                {
                    b.Property<int>("NGNP_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NGNP_ID"), 1L, 1);

                    b.Property<int>("NG_ID")
                        .HasColumnType("int");

                    b.Property<int>("NO_ID")
                        .HasColumnType("int");

                    b.HasKey("NGNP_ID");

                    b.HasIndex("NG_ID");

                    b.HasIndex("NO_ID");

                    b.ToTable("NG_NP");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NG_USR", b =>
                {
                    b.Property<int>("NG_USR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NG_USR_ID"), 1L, 1);

                    b.Property<int?>("NG_ID")
                        .HasColumnType("int");

                    b.Property<int?>("USR_ID")
                        .HasColumnType("int");

                    b.HasKey("NG_USR_ID");

                    b.HasIndex("NG_ID");

                    b.HasIndex("USR_ID");

                    b.ToTable("NG_USR");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NO_TYPE", b =>
                {
                    b.Property<byte>("NO_TYPE_ID")
                        .HasColumnType("tinyint");

                    b.Property<string>("NO_TYPE_DESCRIPTION")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("NO_TYPE_ID");

                    b.ToTable("NO_TYPES");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_PROCES_STATE", b =>
                {
                    b.Property<byte>("ST_ID")
                        .HasColumnType("tinyint");

                    b.Property<string>("ST_DESC")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ST_ID");

                    b.ToTable("NOT_PROCES_STATES");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_PROCESS", b =>
                {
                    b.Property<int>("NPR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NPR_ID"), 1L, 1);

                    b.Property<int?>("NG_ID")
                        .HasColumnType("int");

                    b.Property<string>("NPR_CALL_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("NPR_DATE")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NPR_END_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("NPR_FLAG")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool?>("NPR_HORN_ID")
                        .HasColumnType("bit");

                    b.Property<int?>("NTP_ID")
                        .HasColumnType("int");

                    b.Property<string>("PULT_NUMBER")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("USR_ID")
                        .HasColumnType("int");

                    b.HasKey("NPR_ID");

                    b.HasIndex("NTP_ID");

                    b.ToTable("NOT_PROCESS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_PULT", b =>
                {
                    b.Property<int>("PULT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PULT_ID"), 1L, 1);

                    b.Property<string>("PULT_DESCR")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PULT_IP")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PULT_NAME")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PULT_NUMBER")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PULT_ID");

                    b.ToTable("NOT_PULTS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_STATUS", b =>
                {
                    b.Property<int>("STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("STAT_ID"), 1L, 1);

                    b.Property<int?>("NO_ID")
                        .HasColumnType("int");

                    b.Property<byte?>("NO_TYPE")
                        .HasColumnType("tinyint");

                    b.Property<int?>("NPR_ID")
                        .HasColumnType("int");

                    b.Property<string>("STAT_CALL_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte?>("STAT_FLAG")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_GET_FLAG")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_INT_COUNT")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_INT_FLAG")
                        .HasColumnType("tinyint");

                    b.Property<string>("STAT_INT_PHONE")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte?>("STAT_IN_CALL")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_MOB_COUNT")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_MOB_FLAG")
                        .HasColumnType("tinyint");

                    b.Property<string>("STAT_MOB_PHONE")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte?>("STAT_NOTIFICATION")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_NUM_OF_CALLS")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_PH1_COUNT")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_PH1_FLAG")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_PH2_COUNT")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("STAT_PH2_FLAG")
                        .HasColumnType("tinyint");

                    b.Property<string>("STAT_PHONE1")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("STAT_PHONE2")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("STAT_ID");

                    b.HasIndex("NO_ID");

                    b.HasIndex("NPR_ID");

                    b.ToTable("NOT_STATUS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_STATUS_PHONE_STATE", b =>
                {
                    b.Property<byte>("ST_ID")
                        .HasColumnType("tinyint");

                    b.Property<string>("ST_DESC")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ST_ID");

                    b.ToTable("NOT_STATUS_PHONE_STATES");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_STATUS_STATE", b =>
                {
                    b.Property<byte>("ST_ID")
                        .HasColumnType("tinyint");

                    b.Property<string>("ST_DESC")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ST_ID");

                    b.ToTable("NOT_STATUS_STATES");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_USER_PIN", b =>
                {
                    b.Property<int>("NOT_USR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NOT_USR_ID"), 1L, 1);

                    b.Property<int?>("USR_ID")
                        .HasColumnType("int");

                    b.Property<string>("USR_PIN")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("NOT_USR_ID");

                    b.HasIndex("USR_ID")
                        .IsUnique()
                        .HasFilter("[USR_ID] IS NOT NULL");

                    b.HasIndex("USR_PIN")
                        .IsUnique()
                        .HasFilter("[USR_PIN] IS NOT NULL");

                    b.ToTable("NOT_USERS_PIN");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOTIFY_GROUP", b =>
                {
                    b.Property<int>("NG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NG_ID"), 1L, 1);

                    b.Property<string>("NG_DESCRIPTION")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<bool?>("NG_MOD_FLAG")
                        .HasColumnType("bit");

                    b.Property<string>("NG_NAME")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NG_NUMBER")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("NG_REG_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("NG_ID");

                    b.ToTable("NOTIFY_GROUPS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOTIFY_OBJECT", b =>
                {
                    b.Property<int>("NO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NO_ID"), 1L, 1);

                    b.Property<string>("NO_INT_PHONE")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NO_NAME")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte?>("NO_TYPE")
                        .HasColumnType("tinyint");

                    b.Property<string>("NP_EXT_PHONE1")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NP_EXT_PHONE2")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NP_MOB_PHONE")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("PULT_ID")
                        .HasColumnType("int");

                    b.HasKey("NO_ID");

                    b.HasIndex("PULT_ID");

                    b.ToTable("NOTIFY_OBJECTS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NPR_TYPE", b =>
                {
                    b.Property<int>("NTP_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NTP_ID"), 1L, 1);

                    b.Property<string>("NTP_DESCRIPTION")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("NTP_ID");

                    b.ToTable("NPR_TYPES");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.STATUS_STATE", b =>
                {
                    b.Property<byte>("ST_ID")
                        .HasColumnType("tinyint");

                    b.Property<string>("ST_DESC")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ST_ID");

                    b.ToTable("STATUS_STATES");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NG_NP", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.NOTIFY_GROUP", "NOTIFY_GROUP")
                        .WithMany("NG_NPS")
                        .HasForeignKey("NG_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LSRPO.Infrastructure.Data.Models.NOTIFY_OBJECT", "NOTIFY_OBJECT")
                        .WithMany("NG_NPS")
                        .HasForeignKey("NO_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NOTIFY_GROUP");

                    b.Navigation("NOTIFY_OBJECT");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NG_USR", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.NOTIFY_GROUP", "NOTIFY_GROUP")
                        .WithMany("NG_USRS")
                        .HasForeignKey("NG_ID");

                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_USER", "AUTH_USER")
                        .WithMany("NG_USRS")
                        .HasForeignKey("USR_ID");

                    b.Navigation("AUTH_USER");

                    b.Navigation("NOTIFY_GROUP");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_PROCESS", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.NPR_TYPE", "NPR_TYPE")
                        .WithMany("NOT_PROCESS")
                        .HasForeignKey("NTP_ID");

                    b.Navigation("NPR_TYPE");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_STATUS", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.NOTIFY_OBJECT", "NOTIFY_OBJECT")
                        .WithMany("NOT_STATUS")
                        .HasForeignKey("NO_ID");

                    b.HasOne("LSRPO.Infrastructure.Data.Models.NOT_PROCESS", "NOT_PROCESS")
                        .WithMany("NOT_STATUS")
                        .HasForeignKey("NPR_ID");

                    b.Navigation("NOTIFY_OBJECT");

                    b.Navigation("NOT_PROCESS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_USER_PIN", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_USER", "AUTH_USER")
                        .WithOne("NOT_USER_PIN")
                        .HasForeignKey("LSRPO.Infrastructure.Data.Models.NOT_USER_PIN", "USR_ID");

                    b.Navigation("AUTH_USER");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOTIFY_OBJECT", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.NOT_PULT", "NOT_PULT")
                        .WithMany("NOTIFY_OBJECTS")
                        .HasForeignKey("PULT_ID");

                    b.Navigation("NOT_PULT");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_ROLE", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_USER", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_USER", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_ROLE", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_USER", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("LSRPO.Infrastructure.Data.Models.AUTH_USER", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.AUTH_USER", b =>
                {
                    b.Navigation("NG_USRS");

                    b.Navigation("NOT_USER_PIN")
                        .IsRequired();
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_PROCESS", b =>
                {
                    b.Navigation("NOT_STATUS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOT_PULT", b =>
                {
                    b.Navigation("NOTIFY_OBJECTS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOTIFY_GROUP", b =>
                {
                    b.Navigation("NG_NPS");

                    b.Navigation("NG_USRS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NOTIFY_OBJECT", b =>
                {
                    b.Navigation("NG_NPS");

                    b.Navigation("NOT_STATUS");
                });

            modelBuilder.Entity("LSRPO.Infrastructure.Data.Models.NPR_TYPE", b =>
                {
                    b.Navigation("NOT_PROCESS");
                });
#pragma warning restore 612, 618
        }
    }
}
