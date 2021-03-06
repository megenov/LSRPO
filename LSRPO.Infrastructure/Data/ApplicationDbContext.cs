using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.InitialSeed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LSRPO.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AUTH_USER, AUTH_ROLE, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

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

        public virtual DbSet<NOT_POSITION> NOT_POSITIONS { get; set; }

        public virtual DbSet<NO_TYPE> NO_TYPES { get; set; }

        public virtual DbSet<NOT_PROCES_STATE> NOT_PROCES_STATES { get; set; }

        public virtual DbSet<NOT_STATUS_PHONE_STATE> NOT_STATUS_PHONE_STATES { get; set; }

        public virtual DbSet<NOT_STATUS_STATE> NOT_STATUS_STATES { get; set; }

        public virtual DbSet<STATUS_STATE> STATUS_STATES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NOT_USER_PIN>().HasIndex(i => i.USR_PIN).IsUnique();
            modelBuilder.Entity<NOT_USER_PIN>().HasIndex(i => i.USR_ID).IsUnique();

            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_POSITION>(@"InitialSeed/NOT_POSITION.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOTIFY_GROUP>(@"InitialSeed/NOTIFY_GROUPS.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOTIFY_OBJECT>(@"InitialSeed/NOTIFY_OBJECTS.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NPR_TYPE>(@"InitialSeed/NPR_TYPES.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_PROCESS>(@"InitialSeed/NOT_PROCESS.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NO_TYPE>(@"InitialSeed/NO_TYPES.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_PULT>(@"InitialSeed/NOT_PULTS.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_PROCES_STATE>(@"InitialSeed/NOT_PROCES_STATES.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_STATUS_PHONE_STATE>(@"InitialSeed/NOT_STATUS_PHONE_STATES.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_STATUS_STATE>(@"InitialSeed/NOT_STATUS_STATES.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<STATUS_STATE>(@"InitialSeed/STATUS_STATES.json"));
            //modelBuilder.ApplyConfiguration(new InitialDataConfiguration<NOT_STATUS>(@"InitialSeed/NOT_STATUS.json"));

            base.OnModelCreating(modelBuilder);
        }
    }
}