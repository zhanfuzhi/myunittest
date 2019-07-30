using System.Data.Entity.Migrations;

namespace myproject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<myproject.EntityFramework.myprojectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "myproject";
        }

        protected override void Seed(myproject.EntityFramework.myprojectDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
