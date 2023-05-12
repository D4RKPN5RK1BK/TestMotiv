using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Controllers.Dict
{
    public class RequestReasonController : BaseNamedDictionaryController<RequestReason, RequestReasonDto, BaseFilterDto>
    {
        public RequestReasonController(Mapper mapper, 
                                       UserRequestContext userRequestContext,
                                       IPageDataService pageDataService) : base(mapper, userRequestContext, pageDataService)
        {
        }
    }
}