﻿namespace CollectionSoftwareTask
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.a51 = new CollectionSoftwareTask.A5();
            this.SuspendLayout();
            // 
            // a51
            // 
            this.a51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a51.Location = new System.Drawing.Point(0, 0);
            this.a51.Name = "a51";
            this.a51.Size = new System.Drawing.Size(770, 522);
            this.a51.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 522);
            this.Controls.Add(this.a51);
            this.Name = "Form1";
            this.Text = "CollectionSoftwareTask";
            this.ResumeLayout(false);

        }

        #endregion

        private A5 a51;
    }
}

