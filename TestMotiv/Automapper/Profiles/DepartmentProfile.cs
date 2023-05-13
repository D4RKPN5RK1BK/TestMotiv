using AutoMapper;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Automapper.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentDto, Department>();
            CreateMap<Department, DepartmentDto>();
        }
    }
}