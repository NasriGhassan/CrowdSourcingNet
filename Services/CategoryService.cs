﻿using Data.Infrastructure;
using Domain.Entities;
using Services.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryServices : Service<category>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public CategoryServices()
           : base(ut)
        {
        }






    }
}


