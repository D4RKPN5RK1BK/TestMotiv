using System.Data.Entity;
using TestMotiv.Models.Domain;

namespace TestMotiv.Contexts
{
    public class UserRequestContext : DbContext
    {
        public UserRequestContext(string connectionString) : base(connectionString)
        {            
        }

        public DbSet<SubscriberRequest> SubscriberRequests { get; set; }
        
        public DbSet<RequestReason> RequestReasons { get; set; }
        
        public DbSet<Country> Countries { get; set; }
        
        public DbSet<City> Cities { get; set; }
        
        public DbSet<Region> Regions { get; set; }
    }
}