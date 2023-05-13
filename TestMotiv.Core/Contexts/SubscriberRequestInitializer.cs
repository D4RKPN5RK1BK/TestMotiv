using System.Collections.Generic;
using System.Data.Entity;
using TestMotiv.Core.Models;

namespace TestMotiv.Core.Contexts
{
    public class SubscriberRequestInitializer : CreateDatabaseIfNotExists<SubscriberRequestContext>
    {
        protected override void Seed(SubscriberRequestContext context)
        {
            var departments = new List<Department>
            {
                new Department { Name = "Офис обслуживания" },
                new Department { Name = "Контакт-центр" }
            };

            context.Departments.AddRange(departments);

            base.Seed(context);
        }
    }
}