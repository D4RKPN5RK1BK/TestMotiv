using AutoMapper;
using TestMotiv.Core.Models;
using TestMotiv.DTO;

namespace TestMotiv.Core.Automapper.Profiles
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