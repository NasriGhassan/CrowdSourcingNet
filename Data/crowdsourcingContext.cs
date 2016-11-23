using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;
using Domain.Entities;

namespace Data.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class crowdsourcingContext : DbContext
    {
        static crowdsourcingContext()
        {
            Database.SetInitializer<crowdsourcingContext>(null);
        }

        public crowdsourcingContext()
            : base("Name=crowdsourcingContext")
        {
        }

        public DbSet<category> categories { get; set; }
        public DbSet<chat> chats { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<history> histories { get; set; }
        public DbSet<idea> ideas { get; set; }
        public DbSet<point> points { get; set; }
        public DbSet<rate> rates { get; set; }
        public DbSet<report> reports { get; set; }
        public DbSet<reward> rewards { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new chatMap());
            modelBuilder.Configurations.Add(new commentMap());
            modelBuilder.Configurations.Add(new historyMap());
            modelBuilder.Configurations.Add(new ideaMap());
            modelBuilder.Configurations.Add(new pointMap());
            modelBuilder.Configurations.Add(new rateMap());
            modelBuilder.Configurations.Add(new reportMap());
            modelBuilder.Configurations.Add(new rewardMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
