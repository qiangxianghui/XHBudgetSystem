
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace XH.BudgetSystem
{
    public class BudgetSystemContext: DbContext
    {
        public BudgetSystemContext():base("BudgetSystemContext")

        {
        }

        public DbSet<EngineeringExamples> EngineeringExamples { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
