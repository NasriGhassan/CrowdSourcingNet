using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private crowdsourcingContext dataContext;
        public crowdsourcingContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new crowdsourcingContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
