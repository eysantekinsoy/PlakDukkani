using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Entities;

namespace Uygulama.DAL.Repository.Abstract
{
    public interface IAlbumRepository
    {
        Album FindUser(string AlbumAdi);
    }
}
