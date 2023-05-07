using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models;
using TestMotiv.Models.Domain;

namespace TestMotiv.Controllers.Dictionary
{
    public class SubscriberRequestController : BaseDictionaryController<SubscriberRequest, SubscriberRequestDto>
    {
        private readonly IFilterHelper<SubscriberRequest, SubscriberRequestFilterDto> _filterHelper;
        private readonly IPageDataService _pageDataService;

        public SubscriberRequestController(Mapper mapper, 
            IPageDataService pageDataService,
            IFilterHelper<SubscriberRequest, SubscriberRequestFilterDto> filterHelper) : base(mapper)
        {
            _filterHelper = filterHelper;
            _pageDataService = pageDataService;
        }

        [HttpGet]
        public ActionResult Read(int currentPage = 1, 
                                 int pageSize = 10, 
                                 int countryId = 0, 
                                 int cityId = 0, 
                                 string phone = "", 
                                 int requestReasonId = 0, 
                                 int regionId = 0)
        {
            var filter = new SubscriberRequestFilterDto
            {
                PageRequest = new PageRequestDto
                {
                    PageSize = pageSize,
                    CurrentPage = currentPage
                },
                Phone = phone,
                CountryId = countryId,
                CityId = cityId,
                RegionId = regionId,
                RequestReasonId = requestReasonId
            };
            
            var pageRequest = Mapper.Map<PageRequest>(filter.PageRequest);
            var query = UserRequestContext.SubscriberRequests.AsQueryable();
            var filtered = _filterHelper.Filter(query, filter);
            var result = _pageDataService.ToPageView<SubscriberRequest, SubscriberRequestDto>(filtered, pageRequest);

            var pageData = new PageView<SubscriberRequestDto, SubscriberRequestFilterDto>
            {
                Filter = filter,
                Items = result.Items.ToList(),
                Total = result.Total
            };

            return Json(pageData);
        }
    }
}