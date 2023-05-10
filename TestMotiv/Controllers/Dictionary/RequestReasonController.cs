using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Contexts;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models.Domain;

namespace TestMotiv.Controllers.Dictionary
{
    public class RequestReasonController : BaseDictionaryController<RequestReason, RequestReasonFilterDto>
    {
        public RequestReasonController(Mapper mapper, 
                                       UserRequestContext userRequestContext) : base(mapper, userRequestContext)
        {
        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}