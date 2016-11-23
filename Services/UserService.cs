using Data.Infrastructure;
using Domain.Entities;
using Services.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices : Service<user>
    {
       

        public UserServices(IUnitOfWork ut)
           : base(ut)
        {
        }






    }
}


