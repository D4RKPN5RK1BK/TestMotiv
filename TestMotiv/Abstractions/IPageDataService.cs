using System.Collections.Generic;
using System.Linq;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Abstractions
{
    public interface IPageDataService
    {
        /// <summary>
        /// Создание страничной форрмы на основе запроса 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pageData"></param>
        /// <returns></returns>
        (IEnumerable<TRes> Items, int Total) ToPageView<TSource, TRes>(IQueryable<TSource> query, PageDataDto pageData) where TSource : IHasId;
    }
}