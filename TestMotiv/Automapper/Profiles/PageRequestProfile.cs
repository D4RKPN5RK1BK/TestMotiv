using AutoMapper;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Automapper.Profiles
{
    public class PageRequestProfile : Profile
    {
        public PageRequestProfile()
        {
            CreateMap<PageRequest, PageRequestDto>();
            CreateMap<PageRequestDto, PageRequest>();
        }
    }
}