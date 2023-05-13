using AutoMapper;
using TestMotiv.Core.Models;
using TestMotiv.DTO;

namespace TestMotiv.Core.Automapper.Profiles
{
    public class SubscriberRequestProfile : Profile
    {
        public SubscriberRequestProfile()
        {
            CreateMap<SubscriberRequest, SubscriberRequestDto>();
            CreateMap<SubscriberRequestDto, SubscriberRequest>();
        }
    }
}