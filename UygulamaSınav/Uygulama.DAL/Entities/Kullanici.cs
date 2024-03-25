using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Repository.Abstract;

namespace Uygulama.DAL.Entities
{
    public class Kullanici : Entity
    {
        public string KullaniciAdi { get; set; }
        public string Sifre {  get; set; }
    }
}
