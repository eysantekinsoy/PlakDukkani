using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Entities;
using Uygulama.DAL.Enums;

namespace Uygulama.BL.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public int SanatciId { get; set; }
        public SanatciModel Sanatci { get; set; }
        public int Fiyati { get; set; }
        public decimal indirim { get; set; }
        public SatisDurum SatisDurum { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public override string ToString()
        {
            return AlbumAdi;
        }
    }
}
