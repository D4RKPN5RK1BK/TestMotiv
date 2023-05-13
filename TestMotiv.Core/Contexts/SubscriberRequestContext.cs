using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestMotiv.Core.Abstractions;
using TestMotiv.Core.Models;

namespace TestMotiv.Core.Contexts
{
    public class SubscriberRequestContext : DbContext
    {
        public SubscriberRequestContext() : base()
        {
            Database.SetInitializer(new SubscriberRequestInitializer());
        }

        public override int SaveChanges()
        {
            SaveChangesHandler();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            SaveChangesHandler();
            return base.SaveChangesAsync();
        }

        private void SaveChangesHandler()
        {
            var entries = ChangeTracker.Entries();
            var audiables = entries.Where(e => e.Entity is IAudiable);
            foreach (var entry in audiables)
            {
                var entity = entry.Entity as IAudiable;

                if (entry.State == EntityState.Added)
                    entity.Created = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    Entry(entity).Property(i => i.Created).IsModified = false;
            }
        }
        
        public DbSet<SubscriberRequest> SubscriberRequests { get; set; }
        
        public DbSet<Department> Departments { get; set; }

        
    }
}