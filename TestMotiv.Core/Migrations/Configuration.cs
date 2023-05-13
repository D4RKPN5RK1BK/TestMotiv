using System.Data.Entity.Migrations;
using TestMotiv.Core.Contexts;

namespace TestMotiv.Core.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SubscriberRequestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}