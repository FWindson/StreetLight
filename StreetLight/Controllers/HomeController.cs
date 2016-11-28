using StreetLight.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StreetLight.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 程序总入口
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            LogUtil.LogInfo(this, $"IP地址为：{GetIP4Address()}的用户进入系统");
            return View();
        }

        private static string GetIP4Address()
        {
            string IP4Address = String.Empty;
            foreach (IPAddress IPA in Dns.GetHostAddresses(System.Web.HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            if (IP4Address != String.Empty)
            {
                return IP4Address;
            }
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            return IP4Address;
        }
    }
}