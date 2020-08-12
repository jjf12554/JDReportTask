using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JDReportTask.Core
{
    /// <summary>
    /// XML辅助类
    /// </summary>
    public static class XmlHelper
    {
        /// <summary>
        /// 保存任务
        /// </summary>
        /// <param name="task"></param>
        public static void SaveTask(TimerTask task)
        {
            var doc = XDocument.Load(AppContext.XML);
            if (doc.Root.Elements().Any(e => e.Attribute("Id").Value == task.Id.ToString()))
            {
                // edit
                var m = doc.Root.Elements().First(e => e.Attribute("Id").Value == task.Id.ToString());
                m.Attribute("Name").Value = task.Name;
                m.Element("InterfaceDll").Value = task.InterfaceDll;
                m.Element("Cron").Value = task.Cron;
                m.Element("user").Value = task.user;
                m.Element("State").Value = task.State;
                m.Element("remark").Value = task.remark;
            }
            else
            {
                // add
                XElement e = new XElement("Task");
                e.Add(
                        new XAttribute("Id", task.Id.ToString()),
                        new XAttribute("Name", task.Name),
                        new XElement("JobName", task.JobName),
                        new XElement("JobGroup", task.JobGroup),
                        new XElement("TriggerName", task.TriggerName),
                        new XElement("TriggerGroup", task.TriggerGroup),
                        new XElement("Cron", task.Cron),
                        new XElement("State", task.State),
                        new XElement("InterfaceDll", task.InterfaceDll),
                        new XElement("user", task.user),
                        new XElement("remark", task.remark)
                     );
                doc.Root.Add(e);
            }
            doc.Save(AppContext.XML);
        }

        /// <summary>
        /// 解析webservice返回结果
        /// </summary>
        /// <param name="xml"></param>
        /// <returns>arr[0]: code (0:success, -1:error) | arr[1]: msg</returns> 
        public static string[] ParseWebResponse(string info, bool isWebService)
        {
            if (isWebService)
            {
                var doc = XDocument.Parse(info);
                return doc.Root.Value.Split('|');
            }
            else
            {
                return info.Split('|');
            }            
        }
    }
}
