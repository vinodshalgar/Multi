using MultiT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiT.Controllers
{
    public class TenantController : Controller
    {
        public ActionResult Index()
        {

            var tenent = new List<Tenant>
            {
                new Tenant
                {
                     id=1,
                     Default=true,
                     DomainName="aabccc.com",
                     Name="svcc"
                },
                new Tenant
                {
                     id=2,
                     Default=false,
                     DomainName="aabccc2.com",
                     Name="svcc2"
                },
                new Tenant
                {
                     id=3,
                     Default=false,
                     DomainName="aabccc3.com",
                     Name="svcc3"
                }
            };
            return View(tenent);
        }
       
    }
}