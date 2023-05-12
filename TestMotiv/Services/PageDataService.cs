using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.DTO;

namespace TestMotiv.Services
{
    public class PageDataService : IPageDataService
    {
        private readonly Mapper _mapper;
        
        public PageDataService(Mapper mapper)
        {
            _mapper = mapper;
        }

        public (IEnumerable<TRes> Items, int Total) ToPageView<TSource, TRes>(IQueryable<TSource> query, PageDataDto pageData) where TSource : IHasId
        {
            var total = query.Count();
            var res = query
                .OrderBy(i => "Id")
                .Skip((pageData.CurrentPage - 1) * pageData.PageSize)
                .Take(pageData.PageSize)
                .ToList();

            return (_mapper.Map<List<TRes>>(res), total);
        }
    }
}