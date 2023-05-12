﻿using System.Linq;
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

            if (!string.IsNullOrEmpty(filter.CityName))
                query = query.Where(i => i.CityName.Contains(filter.CityName));
            
            if (!string.IsNullOrEmpty(filter.CountryName))
                query = query.Where(i => i.CountryName.Contains(filter.CountryName));
            
            if (!string.IsNullOrEmpty(filter.RegionName))
                query = query.Where(i => i.RegionName.Contains(filter.RegionName));
            
            if (!string.IsNullOrEmpty(filter.Phone))
                query = query.Where(i => i.RequestReasonId == filter.RequestReasonId);

            return query;
        }
    }
}