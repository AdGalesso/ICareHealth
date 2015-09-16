namespace ICareHealth.Repository.Migrations
{
    using ICareHealth.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ICareHealth.Repository.Context.UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ICareHealth.Repository.Context.UserContext context)
        {
            var list = new List<Plan>();

            list.Add(new Plan() { Id = 1, Name = "Super Clinical", Value = 1300 });
            list.Add(new Plan() { Id = 2, Name = "Everyday Care", Value = 750 });
            list.Add(new Plan() { Id = 3, Name = "My Way Care", Value = 500 });
            list.Add(new Plan() { Id = 4, Name = "Basic Clinical", Value = 200 });
            list.Add(new Plan() { Id = 5, Name = "Baby Care", Value = 400 });

            foreach (var plan in list)
                context.TBPlan.Add(plan);
        }
    }
}
