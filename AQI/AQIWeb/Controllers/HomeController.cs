using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Text;

namespace AQIWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.pm25.in/api/querys/all_cities.json");

            request.UseDefaultCredentials = false;
            WebResponse response = request.GetResponse();//返回对 Internet 请求的响应。
            Stream resStream = response.GetResponseStream();//返回从 Internet 资源返回数据流
            StreamReader sr = new StreamReader(resStream, System.Text.Encoding.UTF8);//实例华一个流的读写器
            string result = sr.ReadToEnd();//这就是百度首页的HTML哦 ,字符串形式的流的其余部分（从当前位置到末尾）。如果当前位置位于流的末尾，则返回空字符串 ("")
            resStream.Close();//关闭当前流并释放与之关联的所有资源
            sr.Close(); //关闭 System.IO.StreamReader 对象和基础流，并释放与读取器关联的所有系统资源
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
