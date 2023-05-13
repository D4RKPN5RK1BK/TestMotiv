using AutoMapper;
using TestMotiv.Controllers.Base;
using TestMotiv.Core.Abstractions;
using TestMotiv.Core.Contexts;
using TestMotiv.Core.Models;
using TestMotiv.DTO;

namespace TestMotiv.Controllers.Dict
{
    public class DepartmentController : BaseNamedDictionaryController<Department, DepartmentDto, BaseFilterDto>
    {
        public DepartmentController(Mapper mapper, 
                                       SubscriberRequestContext subscriberRequestContext,
                                       IPageDataService pageDataService) : base(mapper, subscriberRequestContext, pageDataService)
        {
        }
    }
}