﻿using ICareHealth.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Repository.Configuration
{
    class PlanConfiguration : EntityTypeConfiguration<Plan>
    {
        public PlanConfiguration()
        {
            ToTable("TBPlan");

            HasKey(x => x.Id);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(255).HasColumnType("VARCHAR");
            Property(x => x.Value).HasColumnName("Value").IsRequired();
            Property(x => x.IsActive).HasColumnName("IsActive").IsRequired();
            Property(x => x.Save).HasColumnName("Save").IsRequired();
            Property(x => x.Update).HasColumnName("Update").IsRequired();
        }
    }
}
