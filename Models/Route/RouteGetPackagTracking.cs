using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WhereIsPackage.Common.CommonEnum;

namespace WhereIsPackage.Models.Route
{
    /// <summary>
    /// 택배 조회 라우트 모델
    /// </summary>
    public class RouteGetPackagTracking
    {
        public RouteGetPackagTracking(CommonPostType postType,string invoiceNo)
        {
            this.postType = postType;
            this.invoiceNo = invoiceNo;

            string _url = string.Empty;
            string[] _subString1 = { };
            string[] _subString2 = { };

            switch (postType)
            {
                default:
                case Common.CommonEnum.CommonPostType.GSPOST:
                    _url = string.Format("https://www.cvsnet.co.kr/invoice/tracking.do?invoice_no={0}", invoiceNo);
                    _subString1 = new string[] { "var trackingInfo = " };
                    _subString2 = new string[] { ";\n    if (!(trackingInfo.code === 200))" };
                    break;
            }

            this.url = _url;
            this.subString1 = _subString1;
            this.subString2 = _subString2;
        }
        /// <summary>
        /// 택배타입
        /// </summary>
        public CommonPostType postType { get; set; }
        /// <summary>
        /// 운송장번호
        /// </summary>
        public string invoiceNo { get; set; }
        /// <summary>
        /// 조회 url
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 앞부분 자르는 문자열
        /// </summary>
        public string[] subString1 { get; set; }
        /// <summary>
        /// 뒷부분 자르는 문자열
        /// </summary>
        public string[] subString2 { get; set; }
    }
}