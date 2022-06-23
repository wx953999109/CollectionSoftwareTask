namespace CollectionSoftwareTask
{
    partial class A5
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listTasks = new System.Windows.Forms.ListView();
            this.tbTaskDetail = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listTasks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbTaskDetail);
            this.splitContainer1.Panel2.Controls.Add(this.tbStep);
            this.splitContainer1.Panel2.Controls.Add(this.tbTitle);
            this.splitContainer1.Size = new System.Drawing.Size(736, 432);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 1;
            // 
            // listTasks
            // 
            this.listTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTasks.FullRowSelect = true;
            this.listTasks.HideSelection = false;
            this.listTasks.Location = new System.Drawing.Point(0, 0);
            this.listTasks.MultiSelect = false;
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(272, 432);
            this.listTasks.TabIndex = 5;
            this.listTasks.UseCompatibleStateImageBehavior = false;
            this.listTasks.View = System.Windows.Forms.View.List;
            this.listTasks.SelectedIndexChanged += new System.EventHandler(this.listTasks_SelectedIndexChanged);
            // 
            // tbTaskDetail
            // 
            this.tbTaskDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTaskDetail.Location = new System.Drawing.Point(0, 42);
            this.tbTaskDetail.Multiline = true;
            this.tbTaskDetail.Name = "tbTaskDetail";
            this.tbTaskDetail.Size = new System.Drawing.Size(460, 390);
            this.tbTaskDetail.TabIndex = 2;
            // 
            // tbStep
            // 
            this.tbStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStep.Location = new System.Drawing.Point(0, 21);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(460, 21);
            this.tbStep.TabIndex = 1;
            this.tbStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTitle
            // 
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTitle.Location = new System.Drawing.Point(0, 0);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(460, 21);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 411);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(736, 21);
            this.tbLog.TabIndex = 2;
            // 
            // A5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.splitContainer1);
            this.Name = "A5";
            this.Size = new System.Drawing.Size(736, 432);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listTasks;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.TextBox tbTaskDetail;
        private System.Windows.Forms.TextBox tbLog;
    }
}
