using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace bhmz
{
    /// <summary>
    /// http这里实现权限控制，比如只限定访问房号,使用json返回的数据,wget
    /// </summary>
    public class HttpSource : ISource
    {
        /// <summary>
        /// 生成一个key上去，登录成功以后，以后都将这个值传上去
        /// </summary>
        private string rndKey = "";
        private string hosturl = Config.ConnStr;
        public void Login(string username, string password)
        {
            rndKey = new Guid().ToString();
            DataFormServer(string.Format("action=login&username={0}&password={1}", ed(username), ed(password)));
        }

        public List<YeZhu> GetYeZhiByBuilding(string building)
        {
            return DataFormServer("action=building&data=" + building);
        }

        public List<YeZhu> SearchYeZhu(string keyword)
        {
            return DataFormServer("action=search&data=" + System.Web.HttpUtility.UrlEncode(keyword, System.Text.Encoding.UTF8));
        }

        public void UpdateYeZhu(YeZhu yz)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(yz);//序列化
            DataFormServer("action=update&data=" + System.Web.HttpUtility.UrlEncode(jsonData, System.Text.Encoding.UTF8));
        }


        public List<YeZhu> GetYeZhuAll()
        {
            return DataFormServer("action=getall");
        }

        public void AddYeZhu(List<YeZhu> yz)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(yz);//序列化
            DataFormServer("action=add&data=" + ed(jsonData));
        }

        public void RemoveYeZhu(YeZhu yz)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(yz);//序列化
            DataFormServer("action=remove&data=" + ed(jsonData));
        }


        private string ed(string txt)
        {
            return System.Web.HttpUtility.UrlEncode(txt, System.Text.Encoding.UTF8);
        }


        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public List<YeZhu> DataFormServer(string action)
        {
            List<YeZhu> result = new List<YeZhu>();
            string url = this.hosturl;
            if (url.Contains("?")) url += "&" + action;
            else url += "?" + action;
            url += "&key=" + rndKey;
            //请求http
            string html = "";

            //返回200正常有数据，204正常无数据，其它的都为出错
            System.Net.HttpWebRequest request = null;
            System.Net.HttpWebResponse response = null;

            int code = 0;
            try
            {
                request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                response = (System.Net.HttpWebResponse)request.GetResponse();
            }
            catch (System.Net.WebException wex)
            {
                if (wex.Response != null)
                {
                    response = (System.Net.HttpWebResponse)wex.Response;
                }
                else
                {
                    throw new Exception("http请求出错:" + wex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("出错:" + ex.Message);
            }
            finally
            {
                if (response != null)
                {
                    try
                    {
                        System.IO.Stream ms = response.GetResponseStream();
                        System.IO.StreamReader sr = new System.IO.StreamReader(ms);
                        html = sr.ReadToEnd();
                        code = (int)response.StatusCode;
                        response.Close();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception("html处理出错:" + ex2.Message);
                    }
                }
            }

            if (code == 200)
            {
                try
                {
                    using (var ms = new System.IO.MemoryStream(Encoding.Unicode.GetBytes(html)))
                    {
                        DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(List<YeZhu>));
                        result = (List<YeZhu>)deseralizer.ReadObject(ms);// //反序列化ReadObject
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("解析数据失败:" + ex.Message);
                }
            }
            else if (code == 204)
            {
                return result;
            }
            return result;
        }
    }
}