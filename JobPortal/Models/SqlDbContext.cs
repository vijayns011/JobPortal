using System.Data.Entity;

namespace CustomAuthorizationFilter.Models
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<CustomAuthorizationFilter.Models.Employer> Employers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SqlDbContext>(new CreateDatabaseIfNotExists<SqlDbContext>());
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<CustomAuthorizationFilter.Models.JobSeeker> JobSeekers { get; set; }

        public System.Data.Entity.DbSet<CustomAuthorizationFilter.Models.JobDetails> JobDetails { get; set; }

        public System.Data.Entity.DbSet<CustomAuthorizationFilter.Models.EducationDetails> EducationDetails { get; set; }
    }
}