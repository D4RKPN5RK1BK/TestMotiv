using AutoMapper;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Automapper.Profiles
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