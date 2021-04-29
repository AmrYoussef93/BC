using AutoMapper;
using BC.Complaints.Application.Common.DTO;
using BC.Complaints.Application.Common.Handler;
using BC.Complaints.Domain.Entities;

namespace BC.Complaints.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap(typeof(Result<>), typeof(Result<>));
            CreateMap<Student, StudentDTO>().ReverseMap();
        }
    }
}
