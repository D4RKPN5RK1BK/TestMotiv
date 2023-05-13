using System.Collections.Generic;
using TestMotiv.Models.Base;

namespace TestMotiv.Models
{
    public class Department : BaseNamedDictModel
    {
        public ICollection<SubscriberRequest> SubscriberRequests { get; set; } = new List<SubscriberRequest>();
    }
}