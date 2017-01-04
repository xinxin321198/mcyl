using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class IPHelper
    {
        public static string GetIP() //获取本地IP
        {
            string hostName = Dns.GetHostName();//本机名  
            System.Net.IPAddress[] addressList = Dns.GetHostByName(hostName).AddressList;//会警告GetHostByName()已过期，我运行时且只返回了一个IPv4的地址  
            //System.Net.IPAddress[] addressList = Dns.GetHostAddresses(hostName);//会返回所有地址，包括IPv4和IPv6  
            //foreach (IPAddress ip in addressList)
            //{
            //    listBox1.Items.Add(ip.ToString());
            //} 
            return addressList[0].ToString();
        }



        /// <summary>
        /// 使用IPHostEntry获取本机局域网地址
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIp()  
        {  
            string hostname = Dns.GetHostName();//得到本机名  
            //IPHostEntry localhost = Dns.GetHostByName(hostname);//方法已过期，只得到IPv4的地址  
            IPHostEntry localhost = Dns.GetHostEntry(hostname);  
            IPAddress localaddr = localhost.AddressList[0];  
            return localaddr.ToString();  
        }

        /// <summary>
        /// 得到网络IP
        /// </summary>
        /// <returns></returns>
        public static string getNetWorkIp()
        {
            string strUrl = "提供IP查询的网站的链接";
            Uri uri = new Uri(strUrl);
            WebRequest webreq = WebRequest.Create(uri);
            Stream s = webreq.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(s, Encoding.Default);
            string all = sr.ReadToEnd();
            int i = all.IndexOf("[") + 1;
            //分析字符串得到IP  
            return "";
            /* 
             我用的是http://www.ip.cn/getip.php?action=getip&ip_url=&from=web    
             (这种链接很容易找的，百度“IP”得到一些网站，分析一下网站的链接就能得到) 
             返回的数据是：  
             <div class="well"><p>当前 IP：<code>0.0.0.0</code>&nbsp;来自：XX省XX市 电信</p><p>GeoIP: Beijing, China</p></div>  
             解析这段就行  
           */  
        }

        /// <summary>
        /// 通过CMD命令来得到IP
        /// </summary>
        public string GetIPForCmd()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "ipconfig.exe";//设置程序名  
            cmd.StartInfo.Arguments = "/all";  //参数  
            //重定向标准输出  
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true;//不显示窗口（控制台程序是黑屏）  
            //cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//暂时不明白什么意思  
            /* 
     收集一下 有备无患 
            关于:ProcessWindowStyle.Hidden隐藏后如何再显示？ 
            hwndWin32Host = Win32Native.FindWindow(null, win32Exinfo.windowsName); 
            Win32Native.ShowWindow(hwndWin32Host, 1);     //先FindWindow找到窗口后再ShowWindow 
            */
            cmd.Start();
            string info = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            cmd.Close();
            return info;
        }  

    }
}
