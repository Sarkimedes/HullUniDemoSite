using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HullUniDemoSite.Models
{
    public class SpaceCheeseDb : DbContext
    {
        public  DbSet<Score> Scores { get; set; }
    }
}