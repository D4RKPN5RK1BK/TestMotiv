using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Controllers.Base;
using TestMotiv.DTO;
using TestMotiv.Models.Domain;

namespace TestMotiv.Controllers.Dictionary
{
    public class RequestReasonController : BaseDictionaryController<RequestReason, RequestReasonFilterDto>
    {
        public RequestReasonController(Mapper mapper) : base(mapper)
        {
        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}