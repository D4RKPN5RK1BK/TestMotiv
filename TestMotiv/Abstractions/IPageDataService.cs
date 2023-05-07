using System.Collections.Generic;
using System.Linq;
using TestMotiv.Models;

namespace TestMotiv.Abstractions
{
    public interface IPageDataService
    {
        /// <summary>
        /// Создание страничной форрмы на основе запроса 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pageRequest"></param>
        /// <returns></returns>
        (IEnumerable<TRes> Items, int Total) ToPageView<TSource, TRes>(IQueryable<TSource> query, PageRequest pageRequest) where TSource : IHasId;
    }
}