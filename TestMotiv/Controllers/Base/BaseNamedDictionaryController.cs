using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Core.Abstractions;
using TestMotiv.Core.Contexts;
using TestMotiv.DTO;

namespace TestMotiv.Controllers.Base
{
    public class BaseNamedDictionaryController<TModel, TDto, TFilter> : BaseDictionaryController<TModel, TDto, TFilter> 
        where TModel : class, IHasName 
        where TFilter : BaseFilterDto, new()
        where TDto : new()
    {
        public BaseNamedDictionaryController(Mapper mapper, 
                                             SubscriberRequestContext subscriberRequestContext,
                                             IPageDataService pageDataService,
                                             IFilterHelper<TModel, TFilter> filterHelper = null, 
                                             ISelectorHelper<TModel, TDto> selectorHelper = null) : base(mapper, subscriberRequestContext, pageDataService, filterHelper, selectorHelper)
        {
        }

        /// <summary>
        /// Получение списка в значений словаря в формате Dictionary
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult List()
        {
            var list = SubscriberRequestContext.Set<TModel>().ToList()
                .ConvertAll(i => new KeyValuePair<string, string>(i.Id.ToString(), i.Name));

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}