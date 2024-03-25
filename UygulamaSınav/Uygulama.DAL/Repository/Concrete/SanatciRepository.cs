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
    public class SanatciRepository : Repository<Album>
    {
        public SanatciRepository(UygulamaDbContext db) : base(db)
        {

        }


    }
}
