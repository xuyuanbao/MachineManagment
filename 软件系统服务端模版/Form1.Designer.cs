﻿namespace 软件系统服务端模版
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
            //紧急存储数据
            UserServer.ServerSettings.SaveToFile();
            UserServer.ServerAccounts.SaveFile();

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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消息发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一键断开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本号说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStripStatusLabel_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_version,
            this.toolStripStatusLabel_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "本软件著作权归***所有";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel2.Text = "     软件版本：";
            // 
            // toolStripStatusLabel_version
            // 
            this.toolStripStatusLabel_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel_version.Name = "toolStripStatusLabel_version";
            this.toolStripStatusLabel_version.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel_version.Text = "V3.0.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.启动服务器ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本控制ToolStripMenuItem,
            this.维护切换ToolStripMenuItem,
            this.消息发送ToolStripMenuItem,
            this.一键断开ToolStripMenuItem,
            this.账户管理ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 版本控制ToolStripMenuItem
            // 
            this.版本控制ToolStripMenuItem.Name = "版本控制ToolStripMenuItem";
            this.版本控制ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.版本控制ToolStripMenuItem.Text = "版本控制";
            this.版本控制ToolStripMenuItem.Click += new System.EventHandler(this.版本控制ToolStripMenuItem_Click);
            // 
            // 维护切换ToolStripMenuItem
            // 
            this.维护切换ToolStripMenuItem.Name = "维护切换ToolStripMenuItem";
            this.维护切换ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.维护切换ToolStripMenuItem.Text = "维护切换";
            this.维护切换ToolStripMenuItem.Click += new System.EventHandler(this.维护切换ToolStripMenuItem_Click);
            // 
            // 消息发送ToolStripMenuItem
            // 
            this.消息发送ToolStripMenuItem.Name = "消息发送ToolStripMenuItem";
            this.消息发送ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.消息发送ToolStripMenuItem.Text = "消息发送";
            this.消息发送ToolStripMenuItem.Click += new System.EventHandler(this.消息发送ToolStripMenuItem_Click);
            // 
            // 一键断开ToolStripMenuItem
            // 
            this.一键断开ToolStripMenuItem.Name = "一键断开ToolStripMenuItem";
            this.一键断开ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.一键断开ToolStripMenuItem.Text = "一键断开";
            this.一键断开ToolStripMenuItem.Click += new System.EventHandler(this.一键断开ToolStripMenuItem_Click);
            // 
            // 账户管理ToolStripMenuItem
            // 
            this.账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            this.账户管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.账户管理ToolStripMenuItem.Text = "账户管理";
            this.账户管理ToolStripMenuItem.Click += new System.EventHandler(this.账户管理ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于软件ToolStripMenuItem,
            this.版本号说明ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            this.关于软件ToolStripMenuItem.Click += new System.EventHandler(this.关于软件ToolStripMenuItem_Click);
            // 
            // 版本号说明ToolStripMenuItem
            // 
            this.版本号说明ToolStripMenuItem.Name = "版本号说明ToolStripMenuItem";
            this.版本号说明ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.版本号说明ToolStripMenuItem.Text = "版本号说明";
            this.版本号说明ToolStripMenuItem.Click += new System.EventHandler(this.版本号说明ToolStripMenuItem_Click);
            // 
            // 启动服务器ToolStripMenuItem
            // 
            this.启动服务器ToolStripMenuItem.Name = "启动服务器ToolStripMenuItem";
            this.启动服务器ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.启动服务器ToolStripMenuItem.Text = "启动服务器";
            this.启动服务器ToolStripMenuItem.Click += new System.EventHandler(this.启动服务器ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(661, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "可登录";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(146, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(237, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(511, 344);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "系统消息：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "在线客户端：";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(10, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(216, 344);
            this.listBox1.TabIndex = 8;
            // 
            // toolStripStatusLabel_time
            // 
            this.toolStripStatusLabel_time.Name = "toolStripStatusLabel_time";
            this.toolStripStatusLabel_time.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel_time.Text = "toolStripStatusLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备管理系统【第三代】";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动服务器ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_version;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem 版本控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护切换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消息发送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一键断开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本号说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time;
    }
}

