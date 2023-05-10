using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models;
using TestMotiv.Models.Domain;

namespace TestMotiv.Controllers.Dict
{
    public class SubscriberRequestController : BaseDictionaryController<SubscriberRequest, SubscriberRequestDto, SubscriberRequestFilterDto>
    {
        // private readonly IFilterHelper<SubscriberRequest, SubscriberRequestFilterDto> _filterHelper;
        // private readonly IPageDataService _pageDataService;

        public SubscriberRequestController(Mapper mapper, UserRequestContext userRequestContext, IFilterHelper<SubscriberRequest, SubscriberRequestFilterDto> filterHelper, IPageDataService pageDataService) : base(mapper, userRequestContext, filterHelper, pageDataService)
        {
        }

        // [HttpGet]
        // public ActionResult Read(int currentPage = 1, 
        //                          int pageSize = 10, 
        //                          int countryId = 0, 
        //                          int cityId = 0, 
        //                          string phone = "", 
        //                          int requestReasonId = 0, 
        //                          int regionId = 0)
        // {
        //     var filter = new SubscriberRequestFilterDto
        //     {
        //         PageData = new PageDataDto
        //         {
        //             PageSize = pageSize,
        //             CurrentPage = currentPage
        //         },
        //         Phone = phone,
        //         CountryId = countryId,
        //         CityId = cityId,
        //         RegionId = regionId,
        //         RequestReasonId = requestReasonId
        //     };
        //     
        //     var pageRequest = Mapper.Map<PageRequest>(filter.PageData);
        //     var query = UserRequestContext.SubscriberRequests.AsQueryable();
        //     var filtered = _filterHelper.Filter(query, filter);
        //     var result = _pageDataService.ToPageView<SubscriberRequest, SubscriberRequestDto>(filtered, pageRequest);
        //
        //     var pageData = new PageData<SubscriberRequestDto, SubscriberRequestFilterDto>
        //     {
        //         Filter = filter,
        //         Items = result.Items.ToList(),
        //         Total = result.Total
        //     };
        //
        //     return View(pageData);
        // }
        
    }
}