using System.Data.Entity;
using TestMotiv.Models;
using TestMotiv.Models.Domain;

namespace TestMotiv.Contexts
{
    public class UserRequestContext : DbContext
    {
        public DbSet<SubscriberRequest> SubscriberRequests { get; set; }
        
        public DbSet<RequestReason> RequestReasons { get; set; }
    }
}