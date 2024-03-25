using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Enums;
using Uygulama.DAL.Repository.Abstract;

namespace Uygulama.DAL.Entities
{
    public class Album : Entity
    {
        public string AlbumAdi { get ; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public int SanatciId { get; set; }
        public Sanatci  Sanatci { get; set; }
        public int Fiyati { get; set; }
        public decimal indirim { get; set; }
        public SatisDurum SatisDurum { get; set; }
        public Status Status { get; set; }
    }
}
