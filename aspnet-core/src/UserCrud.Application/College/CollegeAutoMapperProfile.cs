using AutoMapper;
using UserCrud.Collage.Dto;

namespace UserCrud.Collage
{
    public class CollageMapProfile : Profile
    {
        public CollageMapProfile()
        {
            CreateMap<Collage, CollegeDto>();
            CreateMap<CreateCollege, Collage>();
            CreateMap<UpdateCollege, Collage>();
        }
    }
}