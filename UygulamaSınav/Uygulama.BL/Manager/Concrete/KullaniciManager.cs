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
using Kullanici = Uygulama.DAL.Entities.Kullanici;

namespace Uygulama.BL.Manager.Concrete
{
    public class KullaniciManager : Manager<KullaniciModel, Kullanici, KullaniciMapProfile>
    {
        public KullaniciManager()
        {
            _repository = new AlbumRepository(new UygulamaDbContext());
        }

    }
}
