using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JDTools
{
    public class LogTool
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static void Info(string msg)
        {
            logger.Info(msg);
        }
        public static void Info(string msg, params object[] args)
        {
            logger.Info(msg, args);
        }

        public static void Info(string msg, Exception err)
        {
            logger.Info(err, msg);
        }
    }
}
