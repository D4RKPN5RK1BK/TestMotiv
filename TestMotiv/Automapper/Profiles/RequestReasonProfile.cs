using AutoMapper;
using TestMotiv.DTO;
using TestMotiv.Models;
using TestMotiv.Models.Domain;

namespace TestMotiv.Automapper.Profiles
{
    public class RequestReasonProfile : Profile
    {
        public RequestReasonProfile()
        {
            CreateMap<RequestReasonDto, RequestReason>();
            CreateMap<RequestReason, RequestReasonDto>();
        }
    }
}