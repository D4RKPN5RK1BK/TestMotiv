using System.Collections.Generic;
using TestMotiv.Models.Domain.Base;

namespace TestMotiv.Models
{
    public class RequestReason : BaseNamedDictModel
    {
        public ICollection<SubscriberRequest> SubscriberRequests { get; set; } = new List<SubscriberRequest>();
    }
}