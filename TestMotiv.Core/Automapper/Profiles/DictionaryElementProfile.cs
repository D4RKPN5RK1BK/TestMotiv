using System.Collections.Generic;
using AutoMapper;
using TestMotiv.DTO;

namespace TestMotiv.Core.Automapper.Profiles
{
    public class DictionaryElementProfile : Profile
    {
        public DictionaryElementProfile()
        {
            CreateMap<DictionaryElement, KeyValuePair<string, string>>();
            CreateMap<KeyValuePair<string, string>, DictionaryElement>();
        }
    }
}