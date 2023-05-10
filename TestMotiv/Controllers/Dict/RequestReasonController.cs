using System.Collections.Generic;
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
    public class RequestReasonController : BaseNamedDictionaryController<RequestReason, RequestReasonDto, BaseFilterDto>
    {
        public RequestReasonController(Mapper mapper, UserRequestContext userRequestContext, IFilterHelper<RequestReason, BaseFilterDto> filterHelper, IPageDataService pageDataService) : base(mapper, userRequestContext, filterHelper, pageDataService)
        {
        }

        // public ActionResult Read()
        // {
        //     var result = UserRequestContext.RequestReasons.ToList();
        //     var dtos = Mapper.Map<List<RequestReasonDto>>(result);
        //     return View(dtos);
        // } 
        
    }
}