using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace AbcYazilim.OgrenciTakip.Data.Contexts
{
    public class BaseDbContext<TContext, TConfiguration> : DbContext where TContext : DbContext where TConfiguration:DbMigrationsConfiguration<TContext>, new()
    {
        private static string _nameOrConnetionString=typeof(TContext).Name;
        public BaseDbContext():base(_nameOrConnetionString){       }
        public BaseDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext, TConfiguration>());
            _nameOrConnetionString = connectionString;
        }
    }
}