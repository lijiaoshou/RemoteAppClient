using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxMSTSCLib;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using TSTunnels.Client.WtsApi32;
using Hook;
using System.Diagnostics;

namespace RemoteApp
{
    public partial class Form1 : Form
    {
        IntPtr mHandle = IntPtr.Zero;
        AxMsRdpClient7NotSafeForScripting rdc = new AxMsRdpClient7NotSafeForScripting();
        public int tmpCount = 0;

        //勾子管理类 
        private KeyboardHookLib _keyboardHook = new KeyboardHookLib();

        IntPtr mainHandle = IntPtr.Zero;
        IntPtr lastHandle = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加载配置文件，并显示信息到界面
            GetConfigInfo();

            //连接remoteapp
            ConnectRemoteApp();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetConfigInfo();
        }

        #region old
        //private void OpenVirtualChannel()
        //{
        //    mHandle = WtsApi32.WTSVirtualChannelOpen(IntPtr.Zero, -1, "TSCS");
        //    try
        //    {
        //        string testString = "Hello World";
        //        //MemoryStream ms = new MemoryStream();
        //        //GZipStream gs = new GZipStream(ms, CompressionMode.Compress, true);
        //        //FileStream fs = File.OpenRead();
        //        byte[] buffer = new byte[1024];
        //        //int bytesRead = 0;
        //        //while ((bytesRead = fs.Read(buffer, 0, 1024)) != 0)
        //        //{
        //        //    gs.Write(buffer, 0, bytesRead);
        //        //}
        //        //gs.Close();
        //        byte[] gziped = System.Text.Encoding.UTF8.GetBytes(testString);
        //        //ms.Position = 0;
        //        //ms.Read(gziped, 0, (int)ms.Length);
        //        int written = 0;
        //        bool ret = WtsApi32.WTSVirtualChannelWrite(mHandle, gziped, gziped.Length, ref written);
        //        if (ret || written == gziped.Length)
        //            MessageBox.Show("Sent!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        else
        //            MessageBox.Show("Bumm! Somethings gone wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Somethings gone wrong:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion

        private void ConnectRemoteApp() {
            rdc.Dock = DockStyle.Fill;
            this.Controls.Add(rdc);
            //this.Hide(); //这里是Form1在加载的时候就陈隐藏掉，这样就只看到RemoteAPP了，估计微软也是这样处理的
            rdc.RemoteProgram2.RemoteProgramMode = true;
            rdc.OnConnected += (_1, _2) =>
            {
                rdc.RemoteProgram2.ServerStartProgram(txtPath.Text.Trim(), "", "%SYSTEMROOT%", true, "", false);
            };
            rdc.Server = txtServer.Text.Trim();
            rdc.UserName = string.IsNullOrEmpty(txtDomain.Text.Trim()) ? txtUser.Text.ToString() : txtDomain.Text.ToString() + "\\" + txtUser.Text.ToString(); //注意这里的用户名格式
            rdc.AdvancedSettings7.ClearTextPassword = txtPass.Text.Trim();  //用户名密码
            //rdc.AdvancedSettings7.EnableCredSspSupport = true;
            //rdc.AdvancedSettings7.PublicMode = false;
            rdc.DesktopWidth = SystemInformation.VirtualScreen.Width;
           
            rdc.DesktopHeight = SystemInformation.VirtualScreen.Height;
            rdc.AdvancedSettings7.SmartSizing = true;
            rdc.AdvancedSettings7.keepAliveInterval = 5000;
            //rdc.AdvancedSettings7.DisplayConnectionBar = true;

            //rdc.AdvancedSettings7.CanAutoReconnect = true;
            rdc.AdvancedSettings7.DisableCtrlAltDel = 1;
            rdc.AdvancedSettings7.DisplayConnectionBar = true;

            rdc.AdvancedSettings7.EnableAutoReconnect=cbAutoConnect.Checked?true:false;
            
            rdc.AdvancedSettings7.keepAliveInterval = 5000;
            rdc.CreateVirtualChannels("TSTnls");
            //rdc.SendOnVirtualChannel("TSTnls", "Hello");
            rdc.FullScreen = true;

            //禁用ctrl+alt+del，只允许remoteapp，不允许远程桌面登录
            rdc.AdvancedSettings7.DisableCtrlAltDel = 1;
            rdc.AdvancedSettings7.EnableWindowsKey = -1;
           
            //rdc.AdvancedSettings3.
          

            try
            {
                rdc.Connect();
                /*rdc.OnConnected += (object sender, EventArgs e) =>
                {
                    Thread thread = new Thread(Send);
                    thread.Start();
                };*/
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

       /* private void sendMessage()
        {
            int i = 1;
            while (true)
            {
                Thread.Sleep(20000);
                rdc.SendOnVirtualChannel("TSTnls", "jj");
                //i++;
                if (i > 5)
                {
                    break;
                }
            }
        }*/

        private void GetConfigInfo()
        {
            #region 加载配置文件，从配置文件中读取相应信息
            Config config = new Config();
            Configs list = (Configs)XmlHelper.XmlDeserializeFromFile(AppDomain.CurrentDomain.BaseDirectory + "RemoteApp.xml", Encoding.UTF8);
            if (list.Datas != null && list.Datas.Count > 0)
            {
                config = list.Datas[0];
            }
            else
            {
                MessageBox.Show("没有找到配置文件！");
            }
            #endregion

            #region 将配置信息默认加载到界面上
            txtPath.Text = config.RemoteProgramePath;
            txtServer.Text = config.Server;
            txtDomain.Text = config.Domain;
            txtUser.Text = config.UserName;
            txtPass.Text = config.Password;
            cbAutoConnect.Checked = config.AutoConnect ? true : false;
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            使用客户端输入法ToolStripMenuItem.Checked = true;
            使用服务端输入法ToolStripMenuItem.Checked = false;

            GetConfigInfo();

            //启用客户端输入法
            UseClientInput();

            //传this到自定义控件
            this.txtMonitor.form1 = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendMessage("大阿朵司法所地方");
        }

        private void Send()
        {
            int i = 0;
            while (true)
            {
                string text = "我是测试消息"+i + "\r\n";
                SendMessage(text);
                i++;
                Thread.Sleep(2000);
            }
        }
        public void SendMessage(string messageContent)
        {
           /* string result = "";
            if (messageContent != null)
            {
                for (int i = 0; i < messageContent.Length; i++)
                {
                    if ((int)messageContent[i] > 32 && (int)messageContent[i] < 127)
                    {
                        result += messageContent[i].ToString();
                    }
                    else
                    {
                        result += string.Format("\\u{0:x4}", (int)messageContent[i]);
                    }
                }

               
            }*/
            rdc.SendOnVirtualChannel("TSTnls", messageContent);
            //txtMonitor.Text = messageContent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(TestFunc);
            thread.Start();
        }

        #region 进程
        public static int processid = 0;

        [DllImport("user32", EntryPoint = "GetWindowThreadProcessId")]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int pid);

        public static string GetFormProcessId()
        {
                int processId = 0;
                IntPtr handle = FindWindow.GetActiveWindow();
                processid = GetWindowThreadProcessId(handle, out processId);
                return processid.ToString();

        }

        public static void TestFunc()
        {
            while (true)
            {
                string str = GetFormProcessId();
                MessageBox.Show(str);
                Thread.Sleep(2000);
            }

        }

        #endregion

        /*private void button5_Click(object sender, EventArgs e)
        {
            _keyboardHook = new KeyboardHookLib();
            _keyboardHook.InstallHook(this.OnKeyPress);

            //启用客户端输入法的时候，自动让客户端输入法的输入窗口聚焦
            FindWindow.SetForegroundWindow(mainHandle);
            txtMonitor.Focus();
        }*/

        /*private void button6_Click(object sender, EventArgs e)
        {
            //解除客户端键盘监控钩子
            if (_keyboardHook != null)
            {
                _keyboardHook.UninstallHook();
            }

            //启用服务端输入法时，发消息到服务端
            SendMessage("使用服务端输入法！");
        }*/

        /// <summary> 
        /// 客户端键盘捕捉事件. 
        /// </summary> 
        /// <param name="hookStruct">由Hook程序发送的按键信息</param> 
        /// <param name="handle">是否拦截</param> 
        public void OnKeyPress(KeyboardHookLib.HookStruct hookStruct, out bool handle)
        {
            handle = false; //预设不拦截任何键 

            //如果前置窗口时主窗口，则不拦截
            if (FindWindow.GetForegroundWindow() == mainHandle)
            {
                if (tmpCount == 0)
                {
                    tmpCount++;
                    FindWindow.keybd_event((Keys)hookStruct.vkCode, 0, 0, 0);
                    handle = true;
                }
                return;
            }

            //如果键A~Z 
            if (hookStruct.vkCode >= (int)Keys.A && hookStruct.vkCode <= (int)Keys.Z
                &&FindWindow.GetForegroundWindow()!=mainHandle)
            {
                tmpCount = 0;
                lastHandle = FindWindow.GetForegroundWindow();
                //A~Z键时，focus隐藏的主窗口
                FindWindow.SetForegroundWindow(mainHandle);
                txtMonitor.Focus();
                tmpCount = 0;

                handle = true;
            }
        }

        public void SetLastWindowFocus()
        {
            FindWindow.SetForegroundWindow(lastHandle);
        }

       /* private void txtMonitor_TextChanged(object sender, EventArgs e)
        {
            RemoteApp.MyTextBox.GetComposition getImmStr = new RemoteApp.MyTextBox.GetComposition();
            //string immStr;
            FindWindow.SetForegroundWindow(lastHandle);
            string inputResult = getImmStr.CurrentCompStr(mainHandle,m);
            SendMessage(inputResult);
            //txtMonitor.Text = "";
        }*/

        private void Form1_Activated(object sender, EventArgs e)
        {
            //获取主窗口句柄（正式运行时，主窗口是隐藏的）
            mainHandle = FindWindow.GetForegroundWindow();

            button1_Click(this,null);

            //this.Hide();
            //this.Opacity = 0.001;//让客户端窗体的透明度接近看不到 
        }

        private void 使用客户端输入法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseClientInput();

            //启用客户端输入法，发送消息到服务端
            SendMessage("使用客户端输入法！");
        }

        private void UseClientInput()
        {
            使用客户端输入法ToolStripMenuItem.Checked = true;
            使用服务端输入法ToolStripMenuItem.Checked = false;

            //_keyboardHook = new KeyboardHookLib();
            _keyboardHook.InstallHook(this.OnKeyPress);

            //启用客户端输入法的时候，自动让客户端输入法的输入窗口聚焦
            FindWindow.SetForegroundWindow(mainHandle);
            txtMonitor.Focus();
        }

        private void 使用服务端输入法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            使用客户端输入法ToolStripMenuItem.Checked = false;
            使用服务端输入法ToolStripMenuItem.Checked = true;

            //解除客户端键盘监控钩子
            if (_keyboardHook != null)
            {
                _keyboardHook.UninstallHook();
            }

            //启用服务端输入法时，发消息到服务端
            SendMessage("使用服务端输入法！");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.RemoteApp客户端.Dispose();
        }

    }
}
