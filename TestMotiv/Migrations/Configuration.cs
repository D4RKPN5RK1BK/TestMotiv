using System.Data.Entity.Migrations;

namespace TestMotiv.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexts.UserRequestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}