using ICareHealth.Domain;
using ICareHealth.Repository.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ICareHealth.Repository.Context
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("DBICareHealth")
        {
        }

        public DbSet<User> TBUser { get; set; }
        public DbSet<Plan> TBPlan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PlanConfiguration());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
