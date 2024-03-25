using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.BL.Manager.Abstract;
using Uygulama.BL.MappingProfile;
using Uygulama.BL.Models;
using Uygulama.DAL.Context;
using Uygulama.DAL.Entities;
using Uygulama.DAL.Repository.Abstract;
using Uygulama.DAL.Repository.Concrete;

namespace Uygulama.BL.Manager.Concrete
{
    public class AlbumManager : Manager<AlbumModel, Album, AlbumMapProfile>
    {
        public AlbumManager()
        {
            _repository = new AlbumRepository(new UygulamaDbContext());
        }
        
    }
}
