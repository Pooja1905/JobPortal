using JobPortal.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace JobPortal.Api.Controllers.Base
{
    public class BaseApiController<TBusiness> : ApiController where TBusiness:BusinessBase, new()
    {
        protected TBusiness Business { get; set; }
        protected override void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);

            Business = new TBusiness();

        }        
        
        protected override void Dispose(bool disposing)
        {
            this.Business.Dispose();
            base.Dispose(disposing);
        }
    }
}