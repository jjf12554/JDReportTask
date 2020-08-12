using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDReportTask.Core
{
    /// <summary>
    /// 定时任务对象
    /// </summary>
    public class TimerTask
    {        
        public int Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 定时任务名称
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// 定时任务群组
        /// </summary>
        public string JobGroup { get; set; }
        /// <summary>
        /// 接口文件名称
        /// </summary>
        public string InterfaceDll { get; set; }
        /// <summary>
        /// 定时器名称
        /// </summary>
        public string TriggerName { get; set; }
        /// <summary>
        /// 定时器群组
        /// </summary>
        public string TriggerGroup { get; set; }
        /// <summary>
        /// 定时规则
        /// </summary>
        public string Cron { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 通知用户
        /// </summary>
        public string user { get; set; }
        /// <summary>
        /// 任务备注
        /// </summary>
        public string remark { get; set; }

        public override string ToString()
        {
            return string.Format("任务:{0} \n 接口:{1}\n", this.Name, this.InterfaceDll);
        }
    }
}
