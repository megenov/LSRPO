using LSRPO.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LSRPO.Data
{
    public class LSRPODbContext : DbContext
    {
        public virtual DbSet<AUTH_USER> AUTH_USERS { get; set; }

        public virtual DbSet<NOT_USER_PIN> NOT_USERS_PIN { get; set; }

        public virtual DbSet<NG_USR> NG_USR { get; set; }

        public virtual DbSet<NOTIFY_GROUP> NOTIFY_GROUPS { get; set; }

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