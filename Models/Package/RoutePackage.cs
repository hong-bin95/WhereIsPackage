using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WhereIsPackage.Common.CommonEnum;

namespace WhereIsPackage.Models.Package
{
    /// <summary>
    /// 조회
    /// </summary>
    public class RoutePackage
    {
        /// <summary>
        /// 택배 타입
        /// </summary>
        public CommonPostType postType { get; set; }
        /// <summary>
        /// 운송장번호
        /// </summary>
        public string no { get; set; }
    }
}