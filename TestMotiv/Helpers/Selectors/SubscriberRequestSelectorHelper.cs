using System.Data.Entity;
using System.Linq;
using TestMotiv.Abstractions;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Helpers.Selectors
{
    public class SubscriberRequestSelectorHelper : ISelectorHelper<SubscriberRequest, SubscriberRequestDto>
    {
        IQueryable<SubscriberRequest> ISelectorHelper<SubscriberRequest, SubscriberRequestDto>.ApplySelectors(IQueryable<SubscriberRequest> query)
        {
            return query.Include(i => i.RequestReason);
        }
    }
}