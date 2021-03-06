﻿using System;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace WallPaperChanger
{
    public partial class Form1 : Form
    {
        String ForwardTime = "";//初始化当前时间
        
        public Form1()
        {
            InitializeComponent();
        }
 
        protected override void WndProc(ref   Message m)
        {//重装API中的关闭  
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {//捕捉关闭窗体消息     
                this.Hide();
                return;
            }
            base.WndProc(ref   m);
        }

        //声明INI文件的写操作函数 WritePrivateProfileString()
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        //声明INI文件的读操作函数 GetPrivateProfileString()
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //换壁纸
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
         ); 


        //换壁纸函数
        public void SetWallPaper()
        {
            //判断是否晚上
            int a = Convert.ToInt32(comboBox1.Text);
            int b = Convert.ToInt32(comboBox2.Text);
            String NowTime = DateTime.Now.Hour.ToString();
            Boolean Night = IsNight(NowTime, a, b);

            if (NowTime != ForwardTime)
            {
                //String FilePath = Application.StartupPath + "\\Laputa\\" + DateTime.Now.Hour.ToString() + ".jpg";
                //String CachePath = Application.StartupPath + "\\Laputa\\Cache.bmp";
                //Image image = Image.FromFile(FilePath);
                //image.Save(CachePath, System.Drawing.Imaging.ImageFormat.Bmp);
                //SystemParametersInfo(20, 0, CachePath, 0x2);
                String FilePath = Application.StartupPath + "\\Laputa\\" + DateTime.Now.Hour.ToString() + ".jpg";
                SystemParametersInfo(20, 0, FilePath, 0x2);

                //菜单相关
                if(checkBox1.Checked == true) //所有时间都提醒
                {
                   Notification();
                }
                else
                    if (Night == false)//不是晚上
                    {
                        Notification();
                    }
                ForwardTime = NowTime;
            }
            System.GC.Collect();
        }

        public void Notification()
        {
            if (BubbleToolStripMenuItem.Checked == true)//气泡提示
            {
                if (englishToolStripMenuItem.Checked == true)
                    this.notifyIcon1.ShowBalloonTip(1, "Laputa", "It's " + DateTime.Now.Hour.ToString() + " now，your wallpaper already changed~\n(づ￣ 3￣)づ", ToolTipIcon.Info);
                else
                    this.notifyIcon1.ShowBalloonTip(1, "Laputa", "现在" + DateTime.Now.Hour.ToString() + "点咯，壁纸已经帮您换好咯\n么么哒~(づ￣ 3￣)づ", ToolTipIcon.Info);
            }

            if (SoundToolStripMenuItem.Checked == true)//声音提示
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = Application.StartupPath + "\\LittleCrystal.wav";
                player.Load();
                player.Play();
            }
        }

        public static Boolean IsNight(String Num,int a,int b)
        {
            int i = Convert.ToInt32(Num);
            if (i>=a && i<=23)
                return true;
            else
                if (i >= 0 && i <=b)
                    return true;
                else
                    return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //读取配置文件

            StringBuilder str = new StringBuilder(255);

            GetPrivateProfileString("Settings", "Sound", "", str, 255, Application.StartupPath + "\\config.ini");
            if (Convert.ToInt32(str.ToString()) == 1)
                SoundToolStripMenuItem.Checked = true;
            else
                SoundToolStripMenuItem.Checked = false;

            GetPrivateProfileString("Settings", "Bubble", "", str, 255, Application.StartupPath + "\\config.ini");
            if (Convert.ToInt32(str.ToString()) == 1)
                BubbleToolStripMenuItem.Checked = true;
            else
                BubbleToolStripMenuItem.Checked = false;

            GetPrivateProfileString("Settings", "AllTime", "", str, 255, Application.StartupPath + "\\config.ini");
            if (Convert.ToInt32(str.ToString()) == 1)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;

            GetPrivateProfileString("Settings", "TimeStart", "", str, 255, Application.StartupPath + "\\config.ini");

            comboBox1.SelectedIndex = Convert.ToInt32(str.ToString());

            GetPrivateProfileString("Settings", "TimeEnd", "", str, 255, Application.StartupPath + "\\config.ini");

            comboBox2.SelectedIndex = Convert.ToInt32(str.ToString());

            GetPrivateProfileString("Settings", "Language", "", str, 255, Application.StartupPath + "\\config.ini");

            if (Convert.ToInt32(str.ToString()) == 1)
                CHToolStripMenuItem.Checked = true;
            else
                englishToolStripMenuItem.Checked = true;

            if (englishToolStripMenuItem.Checked == true)
            {
                ToolStripMenuItem1.Text = "Alert settings";
                SoundToolStripMenuItem.Text = "Sounds";
                BubbleToolStripMenuItem.Text = "Notification Ballons";
                NightToolStripMenuItem.Text = "Do Not Disturb";
                ToolStripMenuItem2.Text = "Exit";
                groupBox1.Text = "Time Settings";
                checkBox1.Text = "Remind me every hour";
                button1.Text = "Apply";
                label1.Text = "To";
                label2.Text = "O'Clock";
                时间设置ToolStripMenuItem.Text = "Time Settings";

            }


            //欢迎
            if (BubbleToolStripMenuItem.Checked == true)//气泡提示
            {
                if (englishToolStripMenuItem.Checked == true)
                    this.notifyIcon1.ShowBalloonTip(1, "Laputa", "Welcome to Laputa！！！\n~(づ￣ 3￣)づ\nRight click the tray icon can open the settings~\n", ToolTipIcon.Info);
                else
                    this.notifyIcon1.ShowBalloonTip(1, "Laputa", "欢迎使用Laputa！！！\n么么哒~(づ￣ 3￣)づ\n右键托盘设置可以关掉提醒哦~\n", ToolTipIcon.Info);
            }

            /*
            if (SoundToolStripMenuItem.Checked == true)//声音提示
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = Application.StartupPath + "\\Laputa.wav";
                player.Load();
                player.Play();
            }
            */


            Thread.Sleep(1000);

            SetWallPaper();
            //第一次设置
            

        }


        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetWallPaper();
        }

        private void sXRWPC10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (englishToolStripMenuItem.Checked == true)
                MessageBox.Show("Version 1.2.0\nAuthor Sign.X.er\nBuild 2016.9\nGithub signxer", "Laputa Ver 1.2");
            else
                MessageBox.Show("版本 1.2.0\n作者 Sign.X.er\n时间 2016.9\nGithub signxer", "Laputa Ver 1.2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;

            //保存配置
            if (checkBox1.Checked == true)
                WritePrivateProfileString("Settings", "Alltime", "1", Application.StartupPath + "\\config.ini");
            else
                WritePrivateProfileString("Settings", "Alltime", "0", Application.StartupPath + "\\config.ini");

            WritePrivateProfileString("Settings", "TimeStart", comboBox1.SelectedIndex.ToString(), Application.StartupPath + "\\config.ini");
            WritePrivateProfileString("Settings", "TimeEnd", comboBox2.SelectedIndex.ToString(), Application.StartupPath + "\\config.ini");

    }

        private void 时间设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void SoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SoundToolStripMenuItem.Checked == true)
            {
                SoundToolStripMenuItem.Checked = false;
                WritePrivateProfileString("Settings", "Sound", "0", Application.StartupPath + "\\config.ini");
            }
            else
            {
                SoundToolStripMenuItem.Checked = true;
                WritePrivateProfileString("Settings", "Sound", "1", Application.StartupPath + "\\config.ini");
            }
        }

        private void BubbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BubbleToolStripMenuItem.Checked == true)
            {
                BubbleToolStripMenuItem.Checked = false;
                WritePrivateProfileString("Settings", "Bubble", "0", Application.StartupPath + "\\config.ini");
            }
            else
            {
                BubbleToolStripMenuItem.Checked = true;
                WritePrivateProfileString("Settings", "Bubble", "1", Application.StartupPath + "\\config.ini");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;

            //保存配置
            if (checkBox1.Checked == true)
                WritePrivateProfileString("Settings", "Alltime", "1", Application.StartupPath + "\\config.ini");
            else
                WritePrivateProfileString("Settings", "Alltime", "0", Application.StartupPath + "\\config.ini");

            WritePrivateProfileString("Settings", "TimeStart", comboBox1.SelectedIndex.ToString(), Application.StartupPath + "\\config.ini");
            WritePrivateProfileString("Settings", "TimeEnd", comboBox2.SelectedIndex.ToString(), Application.StartupPath + "\\config.ini");
        }

        private void CHToolStripMenuItem_Click(object sender, EventArgs e)
        {
                CHToolStripMenuItem.Checked = true;
                WritePrivateProfileString("Settings", "Language", "1", Application.StartupPath + "\\config.ini");
                MessageBox.Show("语言装换为中文，重启生效");
                Application.Restart();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
                englishToolStripMenuItem.Checked = true;
                WritePrivateProfileString("Settings", "Language", "0", Application.StartupPath + "\\config.ini");
                MessageBox.Show("Language settings have been changed，Laputa will restart to apply the changes.");
                Application.Restart();
        }
    }
}
