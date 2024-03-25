using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Repository.Abstract;

namespace Uygulama.DAL.Entities
{
    public class Sanatci : Entity
    {
        public string Adi { get; set; }
        public List<Album> Albums { get; set; }
    }
}
