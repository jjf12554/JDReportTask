namespace JDReportTask
{
    partial class fmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgTaskList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接口地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.触发条件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.触发器名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.触发器组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtExecutingTask = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerExecutingTask = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtInterfaceDll = new System.Windows.Forms.TextBox();
            this.txtCron = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCron = new System.Windows.Forms.Button();
            this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnTestTask = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExecutingTask)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgTaskList);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "任务列表";
            // 
            // dgTaskList
            // 
            this.dgTaskList.AllowUserToAddRows = false;
            this.dgTaskList.AllowUserToDeleteRows = false;
            this.dgTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTaskList.BackgroundColor = System.Drawing.Color.White;
            this.dgTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TaskName,
            this.接口地址,
            this.触发条件,
            this.状态,
            this.user,
            this.Remark,
            this.作业名,
            this.作业组,
            this.触发器名,
            this.触发器组});
            this.dgTaskList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgTaskList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgTaskList.Location = new System.Drawing.Point(7, 21);
            this.dgTaskList.MultiSelect = false;
            this.dgTaskList.Name = "dgTaskList";
            this.dgTaskList.ReadOnly = true;
            this.dgTaskList.RowTemplate.Height = 23;
            this.dgTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTaskList.Size = new System.Drawing.Size(1005, 286);
            this.dgTaskList.TabIndex = 0;
            this.dgTaskList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaskList_CellClick);
            this.dgTaskList.Enter += new System.EventHandler(this.dgTaskList_Enter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "Name";
            this.TaskName.HeaderText = "任务名称";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 150;
            // 
            // 接口地址
            // 
            this.接口地址.DataPropertyName = "InterfaceDll";
            this.接口地址.HeaderText = "接口地址";
            this.接口地址.Name = "接口地址";
            this.接口地址.ReadOnly = true;
            // 
            // 触发条件
            // 
            this.触发条件.DataPropertyName = "Cron";
            this.触发条件.HeaderText = "触发条件";
            this.触发条件.Name = "触发条件";
            this.触发条件.ReadOnly = true;
            this.触发条件.Width = 150;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "State";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 60;
            // 
            // user
            // 
            this.user.DataPropertyName = "user";
            this.user.HeaderText = "人员";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 150;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 200;
            // 
            // 作业名
            // 
            this.作业名.DataPropertyName = "JobName";
            this.作业名.HeaderText = "作业名";
            this.作业名.Name = "作业名";
            this.作业名.ReadOnly = true;
            this.作业名.Width = 70;
            // 
            // 作业组
            // 
            this.作业组.DataPropertyName = "JobGroup";
            this.作业组.HeaderText = "作业组";
            this.作业组.Name = "作业组";
            this.作业组.ReadOnly = true;
            this.作业组.Visible = false;
            this.作业组.Width = 70;
            // 
            // 触发器名
            // 
            this.触发器名.DataPropertyName = "TriggerName";
            this.触发器名.HeaderText = "触发器名";
            this.触发器名.Name = "触发器名";
            this.触发器名.ReadOnly = true;
            this.触发器名.Visible = false;
            // 
            // 触发器组
            // 
            this.触发器组.DataPropertyName = "TriggerGroup";
            this.触发器组.HeaderText = "触发器组";
            this.触发器组.Name = "触发器组";
            this.触发器组.ReadOnly = true;
            this.触发器组.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtExecutingTask);
            this.groupBox2.Location = new System.Drawing.Point(4, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "正在执行的任务(耗时任务会出现在这里 - -)";
            // 
            // dtExecutingTask
            // 
            this.dtExecutingTask.AllowUserToAddRows = false;
            this.dtExecutingTask.AllowUserToDeleteRows = false;
            this.dtExecutingTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtExecutingTask.BackgroundColor = System.Drawing.Color.White;
            this.dtExecutingTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtExecutingTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExecutingTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task});
            this.dtExecutingTask.Location = new System.Drawing.Point(7, 21);
            this.dtExecutingTask.Name = "dtExecutingTask";
            this.dtExecutingTask.ReadOnly = true;
            this.dtExecutingTask.RowTemplate.Height = 23;
            this.dtExecutingTask.Size = new System.Drawing.Size(384, 216);
            this.dtExecutingTask.TabIndex = 0;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.DataPropertyName = "TaskName";
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // timerExecutingTask
            // 
            this.timerExecutingTask.Interval = 1000;
            this.timerExecutingTask.Tick += new System.EventHandler(this.timerExecutingTask_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "TaskName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cron:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "备注:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "接口文件:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(100, 35);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(485, 21);
            this.txtTaskName.TabIndex = 8;
            // 
            // txtInterfaceDll
            // 
            this.txtInterfaceDll.Location = new System.Drawing.Point(100, 103);
            this.txtInterfaceDll.Name = "txtInterfaceDll";
            this.txtInterfaceDll.Size = new System.Drawing.Size(485, 21);
            this.txtInterfaceDll.TabIndex = 10;
            // 
            // txtCron
            // 
            this.txtCron.Location = new System.Drawing.Point(100, 69);
            this.txtCron.Name = "txtCron";
            this.txtCron.Size = new System.Drawing.Size(485, 21);
            this.txtCron.TabIndex = 9;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(100, 171);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(344, 21);
            this.txtRemark.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(211, 208);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 23;
            this.btnPause.Text = "停止任务";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(312, 208);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "启用任务";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(114, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID:";
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(489, 171);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(93, 21);
            this.tbxId.TabIndex = 27;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(8, 208);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 12);
            this.lblRes.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnTestTask);
            this.groupBox3.Controls.Add(this.txtUser);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCron);
            this.groupBox3.Controls.Add(this.lblRes);
            this.groupBox3.Controls.Add(this.tbxId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.txtCron);
            this.groupBox3.Controls.Add(this.txtInterfaceDll);
            this.groupBox3.Controls.Add(this.txtTaskName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(421, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "任务操作";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(100, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(485, 21);
            this.txtUser.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "通知人员:";
            // 
            // btnCron
            // 
            this.btnCron.Location = new System.Drawing.Point(505, 208);
            this.btnCron.Name = "btnCron";
            this.btnCron.Size = new System.Drawing.Size(75, 23);
            this.btnCron.TabIndex = 29;
            this.btnCron.Text = "Cron详解";
            this.btnCron.UseVisualStyleBackColor = true;
            this.btnCron.Click += new System.EventHandler(this.btnCron_Click);
            // 
            // showMenuItem
            // 
            this.showMenuItem.Name = "showMenuItem";
            this.showMenuItem.Size = new System.Drawing.Size(100, 22);
            this.showMenuItem.Text = "显示";
            this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
            // 
            // hideMenuItem
            // 
            this.hideMenuItem.Name = "hideMenuItem";
            this.hideMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hideMenuItem.Text = "隐藏";
            this.hideMenuItem.Click += new System.EventHandler(this.hideMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.hideMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JD定时任务调度应用";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // btnTestTask
            // 
            this.btnTestTask.Location = new System.Drawing.Point(408, 208);
            this.btnTestTask.Name = "btnTestTask";
            this.btnTestTask.Size = new System.Drawing.Size(75, 23);
            this.btnTestTask.TabIndex = 31;
            this.btnTestTask.Text = "测试任务";
            this.btnTestTask.UseVisualStyleBackColor = true;
            this.btnTestTask.Click += new System.EventHandler(this.btnTestTask_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.Text = "JD定时任务调度应用";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.SizeChanged += new System.EventHandler(this.fmMain_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtExecutingTask)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtExecutingTask;
        private System.Windows.Forms.Timer timerExecutingTask;
        private System.Windows.Forms.DataGridView dgTaskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtInterfaceDll;
        private System.Windows.Forms.TextBox txtCron;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.Button btnCron;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem showMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接口地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 触发条件;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业组;
        private System.Windows.Forms.DataGridViewTextBoxColumn 触发器名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 触发器组;
        private System.Windows.Forms.Button btnTestTask;
    }
}

