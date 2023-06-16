using HumanResources.Core.Configuration;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess
{
    public class ApplicationDbContext : DbContext
    {

        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
        //    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=HumanResources;");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
