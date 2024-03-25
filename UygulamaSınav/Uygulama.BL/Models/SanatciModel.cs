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
        public string Adi { get; set; }
        public List<Album> Albums { get; set; }
    }
}
