using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WhereIsPackage.Controllers
{
    public class PackageController : Controller
    {
        // GET: Package
        public ActionResult Index()
        {
            return View();
        }

        // https://www.cvsnet.co.kr/invoice/tracking.do?invoice_no=210254433432

        public void Package()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.cvsnet.co.kr/invoice/tracking.do?invoice_no=210254433432");
            var response = client.GetAsync("").Result;

            Console.WriteLine(response);
        }
    }
}