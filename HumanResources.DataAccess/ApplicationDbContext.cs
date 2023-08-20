using HumanResources.Core.Configuration;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetSection("Settings")?.Get<Settings>()?.ConnectionStrings);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workspace>().HasMany(x => x.Jobs).WithOne(x => x.Workspace).HasForeignKey(x => x.WorkspaceId).IsRequired();
            modelBuilder.Entity<Job>().HasOne(x => x.Workspace).WithMany(x => x.Jobs).HasForeignKey(x => x.WorkspaceId).IsRequired();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<EducationDegree> EducationDegrees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<ApplyForJob> ApplyForJobs { get; set; }
    }
}
