using System.Data.Entity;
using System.Linq;
using TestMotiv.Core.Abstractions;
using TestMotiv.Core.Models;
using TestMotiv.DTO;

namespace TestMotiv.Core.Helpers.Selectors
{
    public class SubscriberRequestSelectorHelper : ISelectorHelper<SubscriberRequest, SubscriberRequestDto>
    {
        IQueryable<SubscriberRequest> ISelectorHelper<SubscriberRequest, SubscriberRequestDto>.ApplySelectors(IQueryable<SubscriberRequest> query)
        {
            return query.Include(i => i.Department);
        }
    }
}