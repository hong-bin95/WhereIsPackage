using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WhereIsPackage.Common.CommonEnum;

namespace WhereIsPackage.Common
{
    public class CommonEnum
    {
        /// <summary>
        /// 택배 종류
        /// </summary>
        public enum CommonPostType
        {
            /// <summary>
            /// GS 택배
            /// </summary>
            GSPOST,
            /// <summary>
            /// CU 택배
            /// </summary>
            CUPOST,
            /// <summary>
            /// CJ 택배
            /// </summary>
            CJPOST,
            /// <summary>
            /// 우체국 택배
            /// </summary>
            POST,
            /// <summary>
            /// 한진 택배
            /// </summary>
            HGPOST,
            /// <summary>
            /// 롯데 택배
            /// </summary>
            LTPOST,
            /// <summary>
            /// 로젠 택배
            /// </summary>
            RZPOST
        }
    }
}