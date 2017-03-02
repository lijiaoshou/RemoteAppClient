namespace RemoteApp
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.axMsRdpClient6NotSafeForScripting1 = new AxMSTSCLib.AxMsRdpClient6NotSafeForScripting();
            this.RemoteApp客户端 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.使用客户端输入法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用服务端输入法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMonitor = new RemoteApp.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient6NotSafeForScripting1)).BeginInit();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(117, 47);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(294, 21);
            this.txtPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "远程程序全路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "服务器地址：";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(119, 96);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(294, 21);
            this.txtServer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "所在域：";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(119, 150);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(294, 21);
            this.txtDomain.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "用户名：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(119, 200);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(294, 21);
            this.txtUser.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "密码：";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(117, 253);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(294, 21);
            this.txtPass.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbAutoConnect
            // 
            this.cbAutoConnect.AutoSize = true;
            this.cbAutoConnect.Location = new System.Drawing.Point(60, 317);
            this.cbAutoConnect.Name = "cbAutoConnect";
            this.cbAutoConnect.Size = new System.Drawing.Size(72, 16);
            this.cbAutoConnect.TabIndex = 13;
            this.cbAutoConnect.Text = "自动重连";
            this.cbAutoConnect.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "发送消息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "监控键盘输入：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "获取进程id";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 423);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "使用客户端输入法";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(447, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "使用服务端输入法";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // axMsRdpClient6NotSafeForScripting1
            // 
            this.axMsRdpClient6NotSafeForScripting1.Enabled = true;
            this.axMsRdpClient6NotSafeForScripting1.Location = new System.Drawing.Point(12, 3);
            this.axMsRdpClient6NotSafeForScripting1.Name = "axMsRdpClient6NotSafeForScripting1";
            this.axMsRdpClient6NotSafeForScripting1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsRdpClient6NotSafeForScripting1.OcxState")));
            this.axMsRdpClient6NotSafeForScripting1.Size = new System.Drawing.Size(192, 192);
            this.axMsRdpClient6NotSafeForScripting1.TabIndex = 0;
            this.axMsRdpClient6NotSafeForScripting1.Visible = false;
            // 
            // RemoteApp客户端
            // 
            this.RemoteApp客户端.ContextMenuStrip = this.NotifyMenu;
            this.RemoteApp客户端.Icon = ((System.Drawing.Icon)(resources.GetObject("RemoteApp客户端.Icon")));
            this.RemoteApp客户端.Text = "notifyIcon1";
            this.RemoteApp客户端.Visible = true;
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用客户端输入法ToolStripMenuItem,
            this.使用服务端输入法ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(173, 92);
            // 
            // 使用客户端输入法ToolStripMenuItem
            // 
            this.使用客户端输入法ToolStripMenuItem.Name = "使用客户端输入法ToolStripMenuItem";
            this.使用客户端输入法ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.使用客户端输入法ToolStripMenuItem.Text = "使用客户端输入法";
            this.使用客户端输入法ToolStripMenuItem.Click += new System.EventHandler(this.使用客户端输入法ToolStripMenuItem_Click);
            // 
            // 使用服务端输入法ToolStripMenuItem
            // 
            this.使用服务端输入法ToolStripMenuItem.Name = "使用服务端输入法ToolStripMenuItem";
            this.使用服务端输入法ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.使用服务端输入法ToolStripMenuItem.Text = "使用服务端输入法";
            this.使用服务端输入法ToolStripMenuItem.Click += new System.EventHandler(this.使用服务端输入法ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(94, 478);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(481, 89);
            this.txtMonitor.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 579);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbAutoConnect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axMsRdpClient6NotSafeForScripting1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient6NotSafeForScripting1)).EndInit();
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient6NotSafeForScripting axMsRdpClient6NotSafeForScripting1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbAutoConnect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NotifyIcon RemoteApp客户端;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem 使用客户端输入法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用服务端输入法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private MyTextBox txtMonitor;
    }
}

