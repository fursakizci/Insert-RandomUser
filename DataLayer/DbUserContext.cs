using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DbUserContext:DbContext
    {
        public DbSet<Coordinates> Coordinates { get; set; }
        public DbSet<Dob> Dobs { get; set; }
        public DbSet<Id> Ids { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Registered> Registereds { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Root> Roots { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Timezone> Timezones { get; set; }
    }
}
