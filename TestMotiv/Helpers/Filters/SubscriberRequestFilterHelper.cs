using System.Linq;
using TestMotiv.Abstractions;
using TestMotiv.DTO;
using TestMotiv.Models;
using TestMotiv.Models.Domain;

namespace TestMotiv.Helpers.Filters
{
    public class SubscriberRequestFilterHelper : IFilterHelper<SubscriberRequest, SubscriberRequestFilterDto>
    {
        public IQueryable<SubscriberRequest> Filter(IQueryable<SubscriberRequest> query, SubscriberRequestFilterDto filter)
        {
            if (!string.IsNullOrEmpty(filter.Phone))
                query = query.Where(i => i.Phone == filter.Phone);

            if (filter.CityId > 0)
                query = query.Where(i => i.CityId == filter.CityId);
            
            if (filter.CountryId > 0)
                query = query.Where(i => i.City.Region.CountryId == filter.CountryId);
            
            if (filter.RegionId > 0)
                query = query.Where(i => i.City.RegionId == filter.RegionId);
            
            if (filter.RequestReasonId > 0)
                query = query.Where(i => i.RequestReasonId == filter.RequestReasonId);

            return query;
        }
    }
}