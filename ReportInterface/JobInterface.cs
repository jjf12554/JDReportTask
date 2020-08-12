using JDTools;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportInterface
{
    public abstract class JobInterface : IJob
    {
        /// <summary>
        /// 用户信息(多用户已,隔开)
        /// </summary>
        public string users = "";

        public void Execute(IJobExecutionContext context)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            users = context.JobDetail.JobDataMap.GetString("user");
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                LogTool.Info(context.JobDetail.Key.Name + "运行失败，原因：" + ex.ToString());
            }
            stopwatch.Stop();
            LogTool.Info(context.JobDetail.Key.Name + "运行时间ms:" + stopwatch.ElapsedMilliseconds.ToString());
        }

        public abstract void Run();
    }
}
