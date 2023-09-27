using System.Text.Json;
using System;
using System.IO;
using System.Net;
using WhereIsPackage.Models;
using WhereIsPackage.Models.Route;

namespace WhereIsPackage.Service
{
    public class PostService
    {
        public object getPackagTracking(RouteGetPackagTracking route)
        {
            // 택배사마다 사용할 수 있도록 최상위 object 사용
            object result = null;

            try
            {
                WebClient client = new WebClient();

                //특정 요청 헤더값을 추가해준다. 
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                using (Stream data = client.OpenRead(route.url))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        // 결과값 읽어와서
                        string result_string = reader.ReadToEnd();

                        // 앞부분 자르고
                        result_string = result_string.Split(route.subString1, StringSplitOptions.None)[1];

                        // 뒷부분 자르기
                        result_string = result_string.Split(route.subString2, StringSplitOptions.None)[0];

                        switch (route.postType)
                        {
                            default:
                            case Common.CommonEnum.CommonPostType.GSPOST:
                                result_string = result_string.Replace(@"\", "");
                                result = JsonSerializer.Deserialize<GSPost>(result_string);
                                break;
                        }

                        reader.Close();
                        data.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}