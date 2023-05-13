using System.Data.Entity.Migrations;

namespace TestMotiv.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexts.SubscriberRequestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}