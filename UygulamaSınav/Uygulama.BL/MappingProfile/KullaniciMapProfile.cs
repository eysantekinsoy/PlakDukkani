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
    public class KullaniciMapProfile : Profile
    {
        public KullaniciMapProfile()
        {
            CreateMap<AlbumModel, Album>().ReverseMap();

        }
    }
}
