using Quartz;
using Quartz.Impl;
using JDReportTask.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportInterface;
using JDTools;
using System.Reflection;
using System.IO;

namespace JDReportTask
{
    public partial class fmMain : Form
    {       
        IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

        public fmMain()
        {
            InitializeComponent();
            // 初始化并启动任务调度器
            StartScheduler();
            #region 表格数据初始化
            dgTaskList.AutoGenerateColumns = false;
            dtExecutingTask.AutoGenerateColumns = false;
            if (AppContext.ListTimerJob.Count > 0)
            {
                dgTaskList.DataSource = AppContext.ListTimerJob;
                dgTaskList.ClearSelection();
            }
            #endregion
        }
        private void fmMain_Load(object sender, EventArgs e)
        {
            LogTool.Info("程序开启");
        }
        #region 窗体设置

        private void SetFullScreen()
        {
            if (this.WindowState == FormWindowState.Maximized)//如果当前的窗体是最大化
            {
                this.WindowState = FormWindowState.Normal;//把当前窗体还原默认大小
            }
            else
            {
                //this.FormBorderStyle = FormBorderStyle.None;//将该窗体的边框设置为无,也就是没有标题栏以及窗口边框的
                this.WindowState = FormWindowState.Maximized;//将该窗体设置为最大化
            }
        }

        private void fmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); //或者是this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }
        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认关闭？", "关闭后任务无法定时执行", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                scheduler.Shutdown();
                LogTool.Info("程序关闭");
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }
        #endregion

        #region 任务核心功能

        private void StartScheduler()
        {
            scheduler.Start();
            AppContext.ListTimerJob.Where(c => c.State == "启动").ToList().ForEach(task =>
            {
                Assembly assembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory + @"TasksDll\" + task.InterfaceDll + ".Dll");
                Type type = assembly.GetType(task.InterfaceDll + ".fMain");
                IJobDetail tempJob = JobBuilder.Create(type).WithIdentity(task.JobName, task.JobGroup).Build();
                tempJob.JobDataMap.Add("user", task.user);
                ITrigger tempTrigger = TriggerBuilder.Create().WithIdentity(task.TriggerName, task.TriggerGroup).WithCronSchedule(task.Cron).Build();
                scheduler.ScheduleJob(tempJob, tempTrigger);
            });
            timerExecutingTask.Start();
        }

        public bool AddJob(Core.TimerTask model)
        {
            bool result = false;
            try
            {
                Assembly assembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory + @"TasksDll\" + model.InterfaceDll + ".Dll");
                Type type = assembly.GetType(model.InterfaceDll + ".fMain");
                IJobDetail tempJob = JobBuilder.Create(type).WithIdentity(model.JobName, model.JobGroup).Build();
                ITrigger tempTrigger = TriggerBuilder.Create().WithIdentity(model.TriggerName, model.TriggerGroup).StartNow().WithCronSchedule(model.Cron).Build();
                scheduler.ScheduleJob(tempJob, tempTrigger);
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                LogTool.Info(ex.ToString());
            }
            return result;
        }

        public void ReStartJob(int taskId)
        {
            var task = AppContext.ListTimerJob.First(c => c.Id == taskId);
            //this.scheduler.ResumeJob(new JobKey(task.JobName, task.JobGroup));
            if (!this.AddJob(task))
            {
                MessageBox.Show("启动失败");
                return;
            }
            task.State = "启动";
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            XmlHelper.SaveTask(task);
        }

        public void PauseJob(int taskId)
        {
            var task = AppContext.ListTimerJob.First(c => c.Id == taskId);
            this.scheduler.DeleteJob(new JobKey(task.JobName, task.JobGroup));
            task.State = "停止";
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            XmlHelper.SaveTask(task);
        }

        #endregion

        #region 事件
        private void timerExecutingTask_Tick(object sender, EventArgs e)
        {
            ReLoadExecutingTask();
            ReLoadAllTask();
        }

        private void dgTaskList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(this.dgTaskList["Id", this.dgTaskList.CurrentCell.RowIndex].Value.ToString());
            var m = AppContext.ListTimerJob.Where(c => c.Id == id).First();
            this.txtTaskName.Text = m.Name;
            this.txtCron.Text = m.Cron;
            this.txtInterfaceDll.Text = m.InterfaceDll;
            this.tbxId.Text = m.Id.ToString();
            this.txtRemark.Text = m.remark;
            this.txtUser.Text = m.user;
            if (m.State == "启动") { this.btnStart.Enabled = false; this.btnPause.Enabled = true; } else { this.btnStart.Enabled = true; this.btnPause.Enabled = false; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtTaskName.Text = "";
            this.txtCron.Text = "";
            this.txtInterfaceDll.Text = "";
            this.tbxId.Text = "";
            this.txtUser.Text = "";
            this.txtRemark.Text = "";
        }
        /// <summary>
        /// 暂停任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.dgTaskList["Id", this.dgTaskList.CurrentCell.RowIndex].Value.ToString());
            this.PauseJob(id);
            MessageBox.Show("停止成功!");
        }
        /// <summary>
        /// 开始任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.dgTaskList["Id", this.dgTaskList.CurrentCell.RowIndex].Value.ToString());
            this.ReStartJob(id);            
            MessageBox.Show("启动成功!");
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = tbxId.Text;            
            TimerTask model = new Core.TimerTask();
            if (id != "")
            {
                model = AppContext.ListTimerJob.First(c => c.Id == int.Parse(id));
                if (MessageBox.Show("确认测试" + model.Name + "？", "确认修改", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                if (model.State == "启动") { MessageBox.Show("编辑状态下: 保存前请先停止任务!"); return; }
            }
            FillModel(model);
            if (!CronExpression.IsValidExpression(model.Cron))
            {
                MessageBox.Show("Cron表达式错误，请打开Cron详解验证");
                return;
            }
            if (id == "")
            {
                model.Id = AppContext.ListTimerJob.Count == 0 ? 1 : AppContext.ListTimerJob.Max(c => c.Id) + 1;
                model.JobName = "Job" + model.Id;
                model.JobGroup = "JobGroup" + model.Id;
                model.TriggerName = "Trigger" + model.Id;
                model.TriggerGroup = "TriggerGroup" + model.Id;                
                model.State = "停止";
                AppContext.ListTimerJob.Add(model);
                //#region 启动任务
                //#region 反射类
                //Assembly assembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory + @"TasksDll\" + model.InterfaceDll + ".Dll");
                //Type type = assembly.GetType(model.InterfaceDll + ".fMain");
                //#endregion
                //IJobDetail tempJob = JobBuilder.Create(type).WithIdentity(model.JobName, model.JobGroup).Build();
                //tempJob.JobDataMap.Add("user", model.user);
                //ITrigger tempTrigger = TriggerBuilder.Create().WithIdentity(model.TriggerName, model.TriggerGroup).WithCronSchedule(model.Cron).Build();
                //scheduler.ScheduleJob(tempJob, tempTrigger);
                //#endregion
            }
            #region 查看dll是否有问题
            //查看是否有该文件
            if (!File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + @"TasksDll\" + model.InterfaceDll + ".Dll"))
            {
                MessageBox.Show("接口文件不存在");
                return;
            }
            //查看是否有fMain类和继承JobInterface
            Assembly assembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory + @"TasksDll\" + model.InterfaceDll + ".Dll");
            Type type = assembly.GetType(model.InterfaceDll + ".fMain");
            if (type == null)
            {
                MessageBox.Show("接口文件中没有fMain类");
                return;
            }
            if (type.BaseType.Name != "JobInterface")
            {
                MessageBox.Show("接口文件中没有继承JobInterface");
                return;
            }
            #endregion
            XmlHelper.SaveTask(model);
            MessageBox.Show("保存成功!");
            LogTool.Info("保存成功:"+ model.ToString());
        }

        private void dgTaskList_Enter(object sender, EventArgs e)
        {
            if (dgTaskList.RowCount != 0)
            {
                dgTaskList.Rows[0].Selected = false;
            }
        }
        /// <summary>
        /// 查看corn编辑页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCron_Click(object sender, EventArgs e)
        {
            //调用系统默认的浏览器
            System.Diagnostics.Process.Start("explorer.exe", @"https://www.bejson.com/othertools/cron/");
        }
        /// <summary>
        /// 测试任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestTask_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.dgTaskList["Id", this.dgTaskList.CurrentCell.RowIndex].Value.ToString());
            var task = AppContext.ListTimerJob.First(c => c.Id == id);
            if (MessageBox.Show("确认测试" + task.Name + "？", "确认测试", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            Assembly assembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory + @"TasksDll\" + task.InterfaceDll + ".Dll");
            Type type = assembly.GetType(task.InterfaceDll + ".fMain");
            JobInterface obj = (JobInterface)Activator.CreateInstance(type);
            obj.users = task.user;
            obj.Run();
            MessageBox.Show("调用成功!");
        }
        #endregion

        #region 辅助方法
        private void ReLoadExecutingTask()
        {
            var list = scheduler.GetCurrentlyExecutingJobs();
            var res = list.Select(c => new
            {
                TaskName = AppContext.ListTimerJob.First(d => d.JobName == c.JobDetail.Key.Name).Name
            }).ToList();
            dtExecutingTask.DataSource = res;
        }

        private void ReLoadAllTask()
        {
            base.DoubleBuffered = true;
            if (AppContext.ListTimerJob.Count > 0)
            {
                dgTaskList.DataSource = null;
                dgTaskList.DataSource = AppContext.ListTimerJob;
            }
        }
        /// <summary>
        /// 任务赋值
        /// </summary>
        /// <param name="model"></param>
        private void FillModel(TimerTask model)
        {
            model.InterfaceDll = txtInterfaceDll.Text.Trim();
            model.remark = txtRemark.Text.Trim().ToUpper();
            model.Name = txtTaskName.Text.Trim();
            model.Cron = txtCron.Text.Trim();
            model.user = txtUser.Text.Trim();
            model.InterfaceDll = txtInterfaceDll.Text.Trim();
        }

        #endregion
       
    }
}
