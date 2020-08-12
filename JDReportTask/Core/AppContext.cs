using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JDReportTask.Core
{
    /// <summary>
    /// 应用上下文
    /// </summary>
    public static class AppContext
    {
        /// <summary>
        /// 任务XML
        /// </summary>
        public const string XML = "Tasks.xml";
        /// <summary>
        /// 所有任务列表
        /// </summary>
        public static List<TimerTask> ListTimerJob = new List<TimerTask>();
        
        static AppContext()
        {
            LoadTimerJobFromXml();
        }

        /// <summary>
        /// 初始化任务XML
        /// </summary>
        private static void LoadTimerJobFromXml()
        {
            var doc = XDocument.Load(XML);
            foreach (var e in doc.Root.Elements())
            {
                var timerTask = new TimerTask();
                timerTask.Id = int.Parse(e.Attribute("Id").Value);
                timerTask.Name = e.Attribute("Name").Value;
                timerTask.InterfaceDll = e.Element("InterfaceDll").Value;
                timerTask.JobGroup = e.Element("JobGroup").Value;
                timerTask.JobName = e.Element("JobName").Value;
                timerTask.TriggerGroup = e.Element("TriggerGroup").Value;
                timerTask.TriggerName = e.Element("TriggerName").Value;
                timerTask.Cron = e.Element("Cron").Value;
                timerTask.State = e.Element("State").Value;
                timerTask.user = e.Element("user").Value;
                timerTask.remark = e.Element("remark").Value;
                ListTimerJob.Add(timerTask);
            }
        }
    }
}
