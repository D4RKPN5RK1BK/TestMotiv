using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models;

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