using AutoMapper;
using TestMotiv.Controllers.Base;
using TestMotiv.Core.Abstractions;
using TestMotiv.Core.Contexts;
using TestMotiv.Core.Models;
using TestMotiv.DTO;

namespace TestMotiv.Controllers.Dict
{
    public class SubscriberRequestController : BaseDictionaryController<SubscriberRequest, SubscriberRequestDto, SubscriberRequestFilterDto>
    {
        public SubscriberRequestController(Mapper mapper, 
                                           SubscriberRequestContext subscriberRequestContext, 
                                           IFilterHelper<SubscriberRequest, SubscriberRequestFilterDto> filterHelper, 
                                           ISelectorHelper<SubscriberRequest, SubscriberRequestDto> selectorHelper,
                                           IPageDataService pageDataService) : base(mapper, subscriberRequestContext, pageDataService, filterHelper, selectorHelper)
        {
        }
    }
}