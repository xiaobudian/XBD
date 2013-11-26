using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Timers;

namespace GetAQIData
{
    class Program
    {
        //每隔一段时间读取一次数据
        private static int seconds = 1000;
        private static Timer timer = null;
        static void Main(string[] args)
        {
            GetData();
            timer = new Timer();
            timer.Interval = seconds * 1000;
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
            Console.ReadLine();
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            GetData();
        }

        private static void GetData()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.pm25.in/api/querys/all_cities.json");

            request.UseDefaultCredentials = false;
            WebResponse response = request.GetResponse();//返回对 Internet 请求的响应。
            Stream resStream = response.GetResponseStream();//返回从 Internet 资源返回数据流
            StreamReader sr = new StreamReader(resStream, System.Text.Encoding.UTF8);//实例华一个流的读写器
            string result = sr.ReadToEnd();//这就是百度首页的HTML哦 ,字符串形式的流的其余部分（从当前位置到末尾）。如果当前位置位于流的末尾，则返回空字符串 ("")
            resStream.Close();//关闭当前流并释放与之关联的所有资源
            sr.Close(); //关闭 System.IO.StreamReader 对象和基础流，并释放与读取器关联的所有系统资源

            string path = AppDomain.CurrentDomain.BaseDirectory + "data\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (result.Contains("time_point"))
            {
                result = result.Substring(result.IndexOf("time_point") + "time_point".Length + 3, 19);
                DateTime dt = DateTime.Parse(result);
                string fileName = dt.ToString("yyyyMMddHH");
                string[] files = Directory.GetFiles(path);
                if (!files.Contains(fileName))
                {
                    File.AppendAllText(path + fileName + ".txt", DateTime.Now.ToString() + "\r\n", Encoding.UTF8);
                }
            }


        }
    }
}
