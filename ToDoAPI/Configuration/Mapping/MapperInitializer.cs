using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Model;
using ToDoAPI.ModelDto;

namespace ToDoAPI.Configuration.Mapping
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}
