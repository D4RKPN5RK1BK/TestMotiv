using System.Collections.Generic;
using TestMotiv.Core.Models.Base;

namespace TestMotiv.Core.Models
{
    public class Department : BaseNamedDictModel
    {
        public ICollection<SubscriberRequest> SubscriberRequests { get; set; } = new List<SubscriberRequest>();
    }
}