using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HullUniDemoSite.Models
{
    public class SpaceCheeseDb : DbContext
    {
        public SpaceCheeseDb() : base("SpaceCheeseDb")
        {
            Database.SetInitializer<SpaceCheeseDb>(new DropCreateDatabaseAlways<SpaceCheeseDb>());
        }

        public  DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}