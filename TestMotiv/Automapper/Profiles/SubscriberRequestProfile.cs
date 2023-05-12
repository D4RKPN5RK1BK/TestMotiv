using AutoMapper;
using TestMotiv.DTO;
using TestMotiv.Models;
using TestMotiv.Models.Domain;

namespace TestMotiv.Automapper.Profiles
{
    public class SubscriberRequestProfile : Profile
    {
        public SubscriberRequestProfile()
        {
            CreateMap<SubscriberRequest, SubscriberRequestDto>()
                .ForMember(dest => dest.RequestReasonName, opt =>
                {
                    opt.PreCondition(src => src.RequestReason != null);
                    opt.MapFrom(src => src.RequestReason.Name);
                });
            CreateMap<SubscriberRequestDto, SubscriberRequest>();
        }
    }
}