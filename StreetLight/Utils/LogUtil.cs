using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StreetLight.Utils
{
    public static class LogUtil
    {
        private static log4net.ILog log;

        public static void LogInfo(object context, string info)
        {
            log = log4net.LogManager.GetLogger(context.GetType());
            log.Info(info);
        }

        public static void LogError(object context, Exception ex, string error)
        {
            log = log4net.LogManager.GetLogger(context.GetType());
            log.Error(error, ex);
        }
    }
}