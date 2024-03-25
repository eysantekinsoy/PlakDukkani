using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Entities;

namespace Uygulama.BL.Models
{
    public class SanatciModel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public List<AlbumModel>? Albums { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
