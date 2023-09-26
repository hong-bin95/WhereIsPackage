using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhereIsPackage.Models.Package
{
    /// <summary>
    /// 조회
    /// </summary>
    public class RequestPackage
    {
        /// <summary>
        /// 호출 url
        /// </summary>
        string url { get; set; }
        /// <summary>
        /// 운송장번호
        /// </summary>
        string no { get; set; }
    }
}