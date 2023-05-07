using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Models;

namespace TestMotiv.Services
{
    public class PageDataService : IPageDataService
    {
        private readonly Mapper _mapper;
        
        public PageDataService(Mapper mapper)
        {
            _mapper = mapper;
        }

        public (IEnumerable<TRes> Items, int Total) ToPageView<TSource, TRes>(IQueryable<TSource> query, PageRequest pageRequest) where TSource : IHasId
        {
            var total = query.Count();
            var res = query.Skip((pageRequest.CurrentPage - 1) * pageRequest.PageSize)
                .Take(pageRequest.PageSize)
                .ToList();

            return (_mapper.Map<List<TRes>>(res), total);
        }
    }
}