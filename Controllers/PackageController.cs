using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WhereIsPackage.Common;
using WhereIsPackage.Models.Package;
using WhereIsPackage.Service;
using static WhereIsPackage.Common.CommonEnum;

namespace WhereIsPackage.Controllers
{
    [Route("api/[controller]")]
    public class PackageController : Controller
    {
        PostService postService = new PostService();

        /// <summary>
        /// 택배 정보 읽어오기
        /// /api/Package
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index(RoutePackage route)
        {
            object result = null;
            try
            {
                result = postService.getPackagTracking(new Models.Route.RouteGetPackagTracking(route.postType, route.no));

            }
            catch (Exception ex)
            {
                //return ex.ToString();
                return Json(new CommonResult() { message = "에러발생", explain = ex.ToString() }, JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}