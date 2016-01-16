using System.Data.Entity.Migrations;

namespace SwaggerSample.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SwaggerSample.EntityFramework.SwaggerSampleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SwaggerSample";
        }

        protected override void Seed(SwaggerSample.EntityFramework.SwaggerSampleDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
