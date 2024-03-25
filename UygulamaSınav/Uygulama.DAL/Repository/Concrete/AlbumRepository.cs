﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Context;
using Uygulama.DAL.Entities;
using Uygulama.DAL.Repository.Abstract;

namespace Uygulama.DAL.Repository.Concrete
{
    public class AlbumRepository : Repository<Album>
    {
        public AlbumRepository(UygulamaDbContext db) : base(db)
        {

        }
        

    }
}
