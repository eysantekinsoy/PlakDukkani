using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.BL.Models;
using Uygulama.DAL.Entities;

namespace Uygulama.BL.MappingProfile
{
    public class AlbumMapProfile : Profile
    {
        public AlbumMapProfile()
        {
            CreateMap<AlbumModel, Album>().ReverseMap();


            //CreateMap<CategoryModel, Category>().
            //ForMember(a => a.Id, b => b.MapFrom(src => src.Id)).
            //ForMember(a => a.CreatedDate, b => b.MapFrom(src => src.CreatedDate)).
            //ForMember(a => a.CategoryName, b => b.MapFrom(src => src.CategoryName)).
            //ForMember(a => a.Meals, b => b.MapFrom(src => src.Meals)).
            //ReverseMap();
        }
    }
}
