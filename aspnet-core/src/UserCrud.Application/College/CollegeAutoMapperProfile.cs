using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCrud.College.Dto;

namespace UserCrud.Collage
{
    public class CollageAutoMapperProfile : Profile
    {
        public CollageAutoMapperProfile()
        {
            CreateMap<Collage.CollageEntity, CollageDto>();
            CreateMap<CreateCollege, Collage.CollageEntity>();
            CreateMap<UpdateCollege, Collage.CollageEntity>();
        }
    }
}
