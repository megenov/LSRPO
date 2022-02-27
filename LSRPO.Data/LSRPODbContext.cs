﻿using LSRPO.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LSRPO.Data
{
    public class LSRPODbContext : DbContext
    {
        public virtual DbSet<AUTH_USER> AUTH_USERS { get; set; }

        public virtual DbSet<NOT_USER_PIN> NOT_USERS_PIN { get; set; }

        public virtual DbSet<NG_USR> NG_USR { get; set; }

        public virtual DbSet<NOTIFY_GROUP> NOTIFY_GROUPS { get; set; }

        public virtual DbSet<NG_NP> NG_NP { get; set; }

        public virtual DbSet<NOTIFY_OBJECT> NOTIFY_OBJECTS { get; set; }

        public virtual DbSet<NOT_STATUS> NOT_STATUS { get; set; }

        public virtual DbSet<NOT_PROCESS> NOT_PROCESS { get; set; }

        public virtual DbSet<NPR_TYPE> NPR_TYPES { get; set; }

        public virtual DbSet<NOT_PULT> NOT_PULTS { get; set; }

        public virtual DbSet<NO_TYPE> NO_TYPES { get; set; }

        public virtual DbSet<NOT_PROCES_STATE> NOT_PROCES_STATES { get; set; }

        public virtual DbSet<NOT_STATUS_PHONE_STATE> NOT_STATUS_PHONE_STATES { get; set; }

        public virtual DbSet<NOT_STATUS_STATE> NOT_STATUS_STATES { get; set; }

        public virtual DbSet<STATUS_STATE> STATUS_STATES { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=OpovAEC;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NOT_USER_PIN>().HasIndex(i => i.USR_PIN).IsUnique();
            modelBuilder.Entity<NOT_USER_PIN>().HasIndex(i => i.USR_ID).IsUnique();
        }
    }
}