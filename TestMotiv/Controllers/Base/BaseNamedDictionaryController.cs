using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.DTO;

namespace TestMotiv.Controllers.Base
{
    public class BaseNamedDictionaryController<TModel, TDto, TFilter> : BaseDictionaryController<TModel, TDto, TFilter> 
        where TModel : class, IHasName 
        where TFilter : BaseFilterDto
        where TDto : new()
    {
        public BaseNamedDictionaryController(Mapper mapper, UserRequestContext userRequestContext, IFilterHelper<TModel, TFilter> filterHelper, IPageDataService pageDataService) : base(mapper, userRequestContext, filterHelper, pageDataService)
        {
        }

        /// <summary>
        /// Получение списка в значений словаря в формате Dictionary
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult List()
        {
            var dtoList = new Dictionary<string, string>();
            var list = UserRequestContext.Set<TModel>().ToList()
                .ToList();

            foreach (var element  in list)
            {
                dtoList.Add(element.Id.ToString(), element.Name);
            }

            return Json(dtoList);
        }
    }
}