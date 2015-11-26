using JobPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Business.Base
{
    public abstract class BusinessBase : IDisposable
    {
        protected UserContext Context { get; set; }

        public BusinessBase()
        {
            this.Context = new UserContext();
        }

        public void Dispose()
        {
            this.Context.Dispose();    
        }
    }
}
