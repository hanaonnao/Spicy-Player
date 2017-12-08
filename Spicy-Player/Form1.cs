using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {

        //定义无边框窗体Form  
        [DllImport("user32.dll")]//*********************拖动无窗体的控件  
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void gPanelTitleBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//*********************调用移动无窗体控件函数  
        }

        //窗體陰影
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect, // x-coordinate of upper-left corner
    int nTopRect, // y-coordinate of upper-left corner
    int nRightRect, // x-coordinate of lower-right corner
    int nBottomRect, // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
 );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION2 = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION2;

        }


        public Form1()
        {

            m_aeroEnabled = false;

            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gPanelTitleBack_MouseDown);
        }

        private void btn_MinMize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lstFileList.Items.CopyTo(fileList, 0);
            numOfMusic = 0;
            CloseBtn();
            WinMediaPlayer.settings.volume = 100;
            msVoiceBar.Minimum = 0;
            msVoiceBar.Maximum = 100;
            msVoiceBar.Value = WinMediaPlayer.settings.volume;
        }







        string[] fileList = new string[10000];
        int numOfMusic;
        int selectOne;
        bool playOne = false;

        public void AddFile(string path)
        {

            if (numOfMusic < 10000)
            {
                numOfMusic += 1;

                fileList[numOfMusic] = path;

            }
            else
            {
                MessageBox.Show("無法添加文件", "播放列表已滿");
            }

        }

        public void AddFiles(string path, ListBox lstFiles)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo f in dir.GetFiles("*mp3"))
            {
                AddFile(f.FullName);
                int i;
                string strFile = Convert.ToString(numOfMusic);
                for (i = 1; i <= 5 - strFile.Length; i++)
                {
                    strFile += "";
                }
                strFile = f.Name;
                lstFileList.Items.Add(strFile);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                AddFiles(d.FullName, lstFileList);
            }
        }


        public void CloseBtn()
        {
            btnPlayPause.Enabled = false;
            btnPlayPause.BackColor = Color.Gainsboro;
            btnNextPlay.Enabled = false;
            btnNextPlay.BackColor = Color.Gainsboro;
            btnPreviousPlay.Enabled = false;
            btnPreviousPlay.BackColor = Color.Gainsboro;
            btnRefresh.Enabled = false;
            btnRefresh.BackColor = Color.Gainsboro;
            btn_repeat.Enabled = false;
            btn_repeat.BackColor = Color.Gainsboro;
            PlayInfo1.Text = "無播放的歌曲";
            PlayInfo2.Text = "未知的藝術家";
            PlayInfo3.Text = "未知的專輯名稱";
        }



        private Image albumImage;

        public void Play(int selectNum)
        {
            WinMediaPlayer.URL = fileList[selectNum];
            var filesong = TagLib.File.Create(WinMediaPlayer.currentMedia.sourceURL);

            if (filesong.Tag.Pictures.Length > 0)
            {
                var bin = (byte[])(filesong.Tag.Pictures[0].Data.Data);
                albumImage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1500, 1500, null, IntPtr.Zero);
            }

            PlayInfo1.Text = filesong.Tag.Title;
            PlayInfo2.Text = filesong.Tag.FirstPerformer;
            PlayInfo3.Text = filesong.Tag.Album;
            PAlbumPIC.BackgroundImage = albumImage;
        }

        public void OpenBtn()
        {
            btnPlayPause.Enabled = true;
            btnPlayPause.BackColor = Color.Transparent;
            btnNextPlay.Enabled = true;
            btnNextPlay.BackColor = Color.Transparent;
            btnPreviousPlay.Enabled = true;
            btnPreviousPlay.BackColor = Color.Transparent;
            btnRefresh.Enabled = true;
            btnRefresh.BackColor = Color.Transparent;
            btn_repeat.Enabled = true;
            btn_repeat.BackColor = Color.Transparent;
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            int i, a;
            openFileMedia.FileName = "";
            openFileMedia.InitialDirectory = "F:\\Music";
            openFileMedia.Filter = "mp3檔案|*.mp3|所有檔案|*.*";
            openFileMedia.Multiselect = true;
            if (openFileMedia.ShowDialog() == DialogResult.OK)
            {
                string[] path = openFileMedia.FileNames;
                for (a = 0; a < path.Length; a++)
                {
                    FileInfo f = new FileInfo(path[a]);
                    AddFile(f.FullName);
                    string strFile = Convert.ToString(numOfMusic);
                    for (i = 1; i <= 5 - strFile.Length; i++)
                    {
                        strFile += "";
                    }
                    strFile = f.Name;

                    lstFileList.Items.Add(strFile);
                }
                if (lstFileList.Items.Count > 0)
                {
                    OpenBtn();
                    txtTipsPlay.Text = "";
                }
            }
        }

        private void btnAddMusicFloder_Click(object sender, EventArgs e)
        {
            folderMedia.SelectedPath = "F:\\";
            folderMedia.ShowNewFolderButton = true;

            folderMedia.Description = "請選擇文件夾目錄:";
            folderMedia.ShowNewFolderButton = false;

            if (folderMedia.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(folderMedia.SelectedPath);
                FileInfo[] inf = dir.GetFiles();
                foreach (FileInfo finf in inf)
                {
                    if (finf.Extension.Equals(".mp3"))
                        AddFiles(folderMedia.SelectedPath, lstFileList);
                }
                if (lstFileList.Items.Count > 0)
                {
                    OpenBtn();
                    txtTipsPlay.Text = "";
                }
            }
        }

        bool playcom = false;
        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            if (WinMediaPlayer.playState.ToString() == "wmppsPlaying")
            {
                btnPlayPause.BackgroundImage = Button_picture.play;
                toolTip.SetToolTip(btnPlayPause, "播放");
                WinMediaPlayer.Ctlcontrols.pause();
                playcom = true;
            }
            else if (playcom == false)
            {
                btnPlayPause.BackgroundImage = Button_picture.pause;
                toolTip.SetToolTip(btnPlayPause, "暫停");
                if (lstFileList.SelectedIndex < 0)
                {
                    selectOne = 1;
                    lstFileList.SelectedIndex = 0;
                }
                else
                {
                    selectOne = lstFileList.SelectedIndex + 1;
                }
                Play(selectOne);
                timerMedia.Enabled = true;
            }
            else if (playcom == true)
            {
                btnPlayPause.BackgroundImage = Button_picture.pause;
                toolTip.SetToolTip(btnPlayPause, "暫停");
                WinMediaPlayer.Ctlcontrols.play();
                playcom = false;
            }

        }




        bool SoundCtl = false;
        int SoundValue;
        private void picSound_Click(object sender, EventArgs e)
        {

            if (SoundCtl == false)
            {
                msVoiceBar.Enabled = false;
                SoundValue = WinMediaPlayer.settings.volume;
                WinMediaPlayer.settings.volume = 0;
                picSound.BackgroundImage = Button_picture.volume_ban;
                msVoiceBar.BackColor = Color.WhiteSmoke;
                //WinMediaPlayer.;
                SoundCtl = true;
            }
            else if (SoundCtl == true)
            {
                msVoiceBar.Enabled = true;
                WinMediaPlayer.settings.volume = SoundValue;
                picSound.BackgroundImage = Button_picture.volume;
                msVoiceBar.BackColor = Color.White;
                SoundCtl = false;
            }
        }

        private void msVoiceBar_ValueChanged(object sender, EventArgs e)
        {
            WinMediaPlayer.settings.volume = msVoiceBar.Value;
        }




        private void msPlaytimebar_Scrolled(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.currentPosition = msPlaytimebar.Value;
        }

        private void msPlaytimebar_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.currentPosition = msPlaytimebar.Value;
        }

        private void lstFileList_DoubleClick(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.pause();
            playcom = false;
            btnPlayPause_Click(sender, e);
            playOne = false;
        }

        private void btnPreviousPlay_Click(object sender, EventArgs e)
        {
            if (lstFileList.SelectedIndex > 0)
            {
                WinMediaPlayer.Ctlcontrols.stop();
                playcom = false;
                if (btnRefreshcrt == 1)
                {
                    Random ran = new Random();
                    int ranp;
                    ranp = lstFileList.Items.Count - 1;
                    int n = lstFileList.SelectedIndex + 1;
                    if (n == 1)
                    {
                        n = ran.Next(2, ranp + 1);
                    }
                    else if (n == ranp)
                    {
                        n = ran.Next(1, ranp);
                    }
                    else
                    {
                        int n1 = ran.Next(1, n - 1);
                        int n2 = ran.Next(n + 1, ranp + 1);
                        int[] str = new int[2] { n1, n2 };
                        int n3 = ran.Next(0, 2);
                        n = str[n3];
                    }
                    lstFileList.SelectedIndex = n - 1;
                    selectOne = n;
                }
                else if (btnRefreshcrt == 0)
                {
                    lstFileList.SelectedIndex -= 1;
                    selectOne = lstFileList.SelectedIndex + 1;
                }
                Play(selectOne);
            }
            else if (lstFileList.SelectedIndex ==0  && btnRefreshcrt == 1)
            {
                Random ran = new Random();
                int ranp;
                ranp = lstFileList.Items.Count - 1;
                int n = ran.Next(0, ranp);

                lstFileList.SelectedIndex = n - 1;
                selectOne = n;
                Play(selectOne);
            }
            else
            {
                btnPlayPause.BackgroundImage = Button_picture.play;
                toolTip.SetToolTip(btnPlayPause, "播放");
                WinMediaPlayer.Ctlcontrols.stop();
                WinMediaPlayer.URL = null;
                playcom = false;

                PAlbumPIC.BackgroundImage = Button_picture.musical;
                PlayInfo1.Text = "無播放的歌曲";
                PlayInfo2.Text = "未知的藝術家";
                PlayInfo3.Text = "未知的專輯名稱";
                txtAlltime.Text = "00:00";
                txtPlayTime.Text = "00:00";

                MessageBox.Show("已經是第一首！");
            }
        }

        private void btnNextPlay_Click(object sender, EventArgs e)
        {
            if (lstFileList.SelectedIndex < lstFileList.Items.Count - 1 && WinMediaPlayer.playState.ToString() == "wmppsPlaying")
            {
                WinMediaPlayer.Ctlcontrols.stop();
                btnPlayPause.BackgroundImage = Button_picture.pause;
                playcom = false;
                if (btnRefreshcrt == 1)
                {
                    Random ran = new Random();
                    int ranp;
                    ranp = lstFileList.Items.Count - 1;
                    int n = lstFileList.SelectedIndex + 1;
                    if(n==1)
                    {
                      n = ran.Next(2, ranp+1);
                    }
                    else if(n== ranp)
                    {
                       n = ran.Next(1, ranp);
                    }
                    else
                    { 
                    int n1 = ran.Next(1, n - 1);
                    int n2 = ran.Next(n + 1,ranp+1);
                    int[] str = new int[2] { n1, n2 };
                    int n3 = ran.Next(0, 2);
                    n = str[n3];
                    }
                    lstFileList.SelectedIndex = n-1;
                    selectOne = n;
                }
                else if (btnRefreshcrt == 0)
                {
                    lstFileList.SelectedIndex += 1;
                    selectOne = lstFileList.SelectedIndex + 1;
                }
                Play(selectOne);
            }
            else if (lstFileList.SelectedIndex == lstFileList.Items.Count - 1&& btnRefreshcrt == 1)
            {
                Random ran = new Random();
                int ranp;
                ranp = lstFileList.Items.Count - 1;
                int n = ran.Next(0, ranp);

                lstFileList.SelectedIndex = n - 1;
                selectOne = n;
                Play(selectOne);
            }
            else if(lstFileList.SelectedIndex==lstFileList.Items.Count-1)
            {
                btnPlayPause.BackgroundImage = Button_picture.play;
                toolTip.SetToolTip(btnPlayPause, "播放");
                WinMediaPlayer.Ctlcontrols.stop();
                WinMediaPlayer.URL = null;
                playcom = false;

                PAlbumPIC.BackgroundImage = Button_picture.musical;
                PlayInfo1.Text = "無播放的歌曲";
                PlayInfo2.Text = "未知的藝術家";
                PlayInfo3.Text = "未知的專輯名稱";
                txtAlltime.Text = "00:00";
                txtPlayTime.Text = "00:00";

                MessageBox.Show("已經是最後第一首！");
            }
            else
            {
                MessageBox.Show("請先播放音樂！");
            }
        }

        int repeatcrl = 0;
        int rebtnRefreshcrt;
        private void btn_repeat_Click(object sender, EventArgs e)
        {
            if (repeatcrl == 0)
            {
                btn_repeat.BackgroundImage = Button_picture.repeat_on;
                repeatcrl = 1;
                toolTip.SetToolTip(btn_repeat, "循環播放,此模式不受到隨機播放影響");
                rebtnRefreshcrt = btnRefreshcrt;
                btnRefresh.BackColor = Color.Silver;
                btnRefreshcrt = 0;
                btnRefresh.Enabled = false;
            }
            else if (repeatcrl == 1)
            {
                btn_repeat.BackgroundImage = Button_picture.repeat_onlist;
                repeatcrl = 2;
                toolTip.SetToolTip(btn_repeat, "列表循環，此模式不受到隨機播放影響");
            }
            else if (repeatcrl == 2)
            {
                btn_repeat.BackgroundImage = Button_picture.repeat;
                repeatcrl = 0;
                toolTip.SetToolTip(btn_repeat, "順序播放");
                btnRefresh.BackColor = Color.White;
                btnRefreshcrt = rebtnRefreshcrt;
                btnRefresh.Enabled = true;
            }
        }

        private void timerMedia_Tick(object sender, EventArgs e)
        {
            msPlaytimebar.Maximum = (int)WinMediaPlayer.currentMedia.duration;
            msPlaytimebar.Minimum = 0;
            msPlaytimebar.Value = (int)WinMediaPlayer.Ctlcontrols.currentPosition;

            if (WinMediaPlayer.playState.ToString() == "wmppsPlaying")
            {
                txtPlayTime.Text = WinMediaPlayer.Ctlcontrols.currentPositionString;
                txtAlltime.Text = WinMediaPlayer.currentMedia.durationString;
            }

            if (WinMediaPlayer.playState.ToString() == "wmppsStopped" && repeatcrl == 1)
            {
                lstFileList.SelectedIndex = selectOne - 1;
                Play(selectOne);
            }

            if (WinMediaPlayer.playState.ToString() == "wmppsStopped" && repeatcrl == 0)
            {

                if (lstFileList.SelectedIndex < lstFileList.Items.Count - 1)
                {
                    WinMediaPlayer.Ctlcontrols.stop();
                    playcom = false;
                    if (btnRefreshcrt == 1)
                    {
                        Random ran = new Random();
                        int ranp;
                        ranp = lstFileList.Items.Count - 1;
                        int n = lstFileList.SelectedIndex + 1;
                        if (n == 1)
                        {
                            n = ran.Next(2, ranp + 1);
                        }
                        else if (n == ranp)
                        {
                            n = ran.Next(1, ranp);
                        }
                        else
                        {
                            int n1 = ran.Next(1, n - 1);
                            int n2 = ran.Next(n + 1, ranp + 1);
                            int[] str = new int[2] { n1, n2 };
                            int n3 = ran.Next(0, 2);
                            n = str[n3];
                        }
                        lstFileList.SelectedIndex = n - 1;
                        selectOne = n;
                    }
                    else if (btnRefreshcrt == 0)
                    {
                        lstFileList.SelectedIndex += 1;
                        selectOne = lstFileList.SelectedIndex + 1;
                    }
                    Play(selectOne);
                }
                else if (lstFileList.SelectedIndex == 0 && btnRefreshcrt == 1)
                {
                    Random ran = new Random();
                    int ranp;
                    ranp = lstFileList.Items.Count - 1;
                    int n = ran.Next(0, ranp);

                    lstFileList.SelectedIndex = n - 1;
                    selectOne = n;
                    Play(selectOne);
                }
                else if (lstFileList.SelectedIndex == lstFileList.Items.Count - 1&& btnRefreshcrt == 1)
                {
                    Random ran = new Random();
                    int ranp;
                    ranp = lstFileList.Items.Count - 1;
                    int n = ran.Next(0, ranp);
                    lstFileList.SelectedIndex = n - 1;
                    selectOne = n;
                    Play(selectOne);
                }
                else
                {
                    btnPlayPause.BackgroundImage = Button_picture.play;
                    toolTip.SetToolTip(btnPlayPause, "播放");
                    WinMediaPlayer.Ctlcontrols.stop();
                    WinMediaPlayer.URL = null;
                    playcom = false;

                    PAlbumPIC.BackgroundImage = Button_picture.musical;
                    PlayInfo1.Text = "無播放的歌曲";
                    PlayInfo2.Text = "未知的藝術家";
                    PlayInfo3.Text = "未知的專輯名稱";
                    txtAlltime.Text = "00:00";
                    txtPlayTime.Text = "00:00";

                    MessageBox.Show("已經是最後第一首！");
                }
            }
            if (WinMediaPlayer.playState.ToString() == "wmppsStopped" && repeatcrl == 2)
            {

                if (lstFileList.SelectedIndex < lstFileList.Items.Count - 1)
                {
                    WinMediaPlayer.Ctlcontrols.stop();
                    playcom = false;
                    lstFileList.SelectedIndex += 1;
                    selectOne = lstFileList.SelectedIndex + 1;
                    Play(selectOne);
                }
                if (selectOne == lstFileList.Items.Count)
                {
                    WinMediaPlayer.Ctlcontrols.stop();
                    playcom = false;
                    lstFileList.SelectedIndex = 0;
                    selectOne = 1;
                    Play(selectOne);
                }
            }



        }

        public void DelFile(int selectNum)
        {
            int i;
            for(i=selectNum;i<=numOfMusic-1;i++)
            {
                fileList[i] = fileList[i + 1];
            }
            numOfMusic -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = lstFileList.SelectedIndex;
            if(lstFileList.SelectedIndex>=0)
            {
                if((selectOne==lstFileList.SelectedIndex+1)&&(WinMediaPlayer.URL!=""))
                {
                    MessageBox.Show("不能刪除正在播放的文件", "錯誤");
                }
                else
                {
                    DelFile(i + 1);
                    lstFileList.Items.RemoveAt(i);
                    if(i<lstFileList.Items.Count)
                    {
                        lstFileList.SelectedIndex = i;
                    }
                    else if(lstFileList.Items.Count==0)
                    {
                        CloseBtn();
                    }
                    else
                    {
                        lstFileList.SelectedIndex = 0;
                    }
                }
            }
        }


        int btnRefreshcrt = 0;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btnRefreshcrt == 0)
            {
                btnRefresh.BackgroundImage = Button_picture.refresh_on;
                btnRefreshcrt = 1;
            }
            else if (btnRefreshcrt == 1)
            {
                btnRefresh.BackgroundImage = Button_picture.refresh;
                btnRefreshcrt =0;
            }
        }




    }
}
