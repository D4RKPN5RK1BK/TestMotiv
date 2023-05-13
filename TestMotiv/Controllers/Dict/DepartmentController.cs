using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models;

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