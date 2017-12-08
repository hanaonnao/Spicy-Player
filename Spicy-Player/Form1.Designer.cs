namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MinMize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.WinMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.folderMedia = new System.Windows.Forms.FolderBrowserDialog();
            this.timerMedia = new System.Windows.Forms.Timer(this.components);
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnAddMusicFloder = new System.Windows.Forms.Button();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayInfo1 = new System.Windows.Forms.TextBox();
            this.PlayInfo2 = new System.Windows.Forms.TextBox();
            this.openFileMedia = new System.Windows.Forms.OpenFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNextPlay = new System.Windows.Forms.Button();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.btnPreviousPlay = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.PAlbumPIC = new System.Windows.Forms.PictureBox();
            this.PlayInfo3 = new System.Windows.Forms.TextBox();
            this.msPlaytimebar = new MediaSlider.MediaSlider();
            this.msVoiceBar = new MediaSlider.MediaSlider();
            this.picSound = new System.Windows.Forms.PictureBox();
            this.txtPlayTime = new System.Windows.Forms.Label();
            this.txtAlltime = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtTipsPlay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAlbumPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_MinMize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 32);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_MinMize
            // 
            this.btn_MinMize.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_MinMize.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.minimize;
            this.btn_MinMize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_MinMize.FlatAppearance.BorderSize = 0;
            this.btn_MinMize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_MinMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinMize.Location = new System.Drawing.Point(825, 3);
            this.btn_MinMize.Name = "btn_MinMize";
            this.btn_MinMize.Size = new System.Drawing.Size(25, 25);
            this.btn_MinMize.TabIndex = 9;
            this.btn_MinMize.UseVisualStyleBackColor = false;
            this.btn_MinMize.Click += new System.EventHandler(this.btn_MinMize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(851, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(109)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spicy Player";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // WinMediaPlayer
            // 
            this.WinMediaPlayer.Enabled = true;
            this.WinMediaPlayer.Location = new System.Drawing.Point(150, 168);
            this.WinMediaPlayer.Name = "WinMediaPlayer";
            this.WinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlayer.OcxState")));
            this.WinMediaPlayer.Size = new System.Drawing.Size(74, 49);
            this.WinMediaPlayer.TabIndex = 0;
            // 
            // timerMedia
            // 
            this.timerMedia.Tick += new System.EventHandler(this.timerMedia_Tick);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMusic.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddMusic.Location = new System.Drawing.Point(415, 386);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(135, 25);
            this.btnAddMusic.TabIndex = 13;
            this.btnAddMusic.TabStop = false;
            this.btnAddMusic.Text = "添加音樂";
            this.btnAddMusic.UseVisualStyleBackColor = false;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // btnAddMusicFloder
            // 
            this.btnAddMusicFloder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddMusicFloder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddMusicFloder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMusicFloder.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddMusicFloder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddMusicFloder.Location = new System.Drawing.Point(565, 386);
            this.btnAddMusicFloder.Name = "btnAddMusicFloder";
            this.btnAddMusicFloder.Size = new System.Drawing.Size(135, 25);
            this.btnAddMusicFloder.TabIndex = 13;
            this.btnAddMusicFloder.Text = "添加文件夾";
            this.btnAddMusicFloder.UseVisualStyleBackColor = true;
            this.btnAddMusicFloder.Click += new System.EventHandler(this.btnAddMusicFloder_Click);
            // 
            // lstFileList
            // 
            this.lstFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFileList.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lstFileList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.ItemHeight = 17;
            this.lstFileList.Location = new System.Drawing.Point(415, 52);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(435, 323);
            this.lstFileList.TabIndex = 14;
            this.lstFileList.DoubleClick += new System.EventHandler(this.lstFileList_DoubleClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(715, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "刪除音樂";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayInfo1
            // 
            this.PlayInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayInfo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayInfo1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.PlayInfo1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PlayInfo1.Location = new System.Drawing.Point(68, 298);
            this.PlayInfo1.Name = "PlayInfo1";
            this.PlayInfo1.Size = new System.Drawing.Size(242, 22);
            this.PlayInfo1.TabIndex = 15;
            this.PlayInfo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayInfo2
            // 
            this.PlayInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayInfo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayInfo2.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.PlayInfo2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PlayInfo2.Location = new System.Drawing.Point(68, 324);
            this.PlayInfo2.Name = "PlayInfo2";
            this.PlayInfo2.Size = new System.Drawing.Size(242, 18);
            this.PlayInfo2.TabIndex = 15;
            this.PlayInfo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileMedia
            // 
            this.openFileMedia.FileName = "openFileMedia";
            this.openFileMedia.Multiselect = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(311, 383);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnRefresh, "隨機播放");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNextPlay
            // 
            this.btnNextPlay.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.next_play;
            this.btnNextPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPlay.FlatAppearance.BorderSize = 0;
            this.btnNextPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNextPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnNextPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPlay.Location = new System.Drawing.Point(245, 383);
            this.btnNextPlay.Name = "btnNextPlay";
            this.btnNextPlay.Size = new System.Drawing.Size(30, 30);
            this.btnNextPlay.TabIndex = 10;
            this.btnNextPlay.UseVisualStyleBackColor = true;
            this.btnNextPlay.Click += new System.EventHandler(this.btnNextPlay_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.repeat;
            this.btn_repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_repeat.FlatAppearance.BorderSize = 0;
            this.btn_repeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_repeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repeat.Location = new System.Drawing.Point(37, 383);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(30, 30);
            this.btn_repeat.TabIndex = 10;
            this.toolTip.SetToolTip(this.btn_repeat, "順序播放");
            this.btn_repeat.UseVisualStyleBackColor = true;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btnPreviousPlay
            // 
            this.btnPreviousPlay.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.previous_play;
            this.btnPreviousPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviousPlay.FlatAppearance.BorderSize = 0;
            this.btnPreviousPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPreviousPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPreviousPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPlay.Location = new System.Drawing.Point(103, 383);
            this.btnPreviousPlay.Name = "btnPreviousPlay";
            this.btnPreviousPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousPlay.TabIndex = 10;
            this.btnPreviousPlay.UseVisualStyleBackColor = true;
            this.btnPreviousPlay.Click += new System.EventHandler(this.btnPreviousPlay_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BackgroundImage = global::WindowsFormsApp1.Button_picture.play;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Location = new System.Drawing.Point(169, 378);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(40, 40);
            this.btnPlayPause.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnPlayPause, "播放");
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // PAlbumPIC
            // 
            this.PAlbumPIC.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.musical;
            this.PAlbumPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PAlbumPIC.Location = new System.Drawing.Point(68, 50);
            this.PAlbumPIC.Name = "PAlbumPIC";
            this.PAlbumPIC.Size = new System.Drawing.Size(242, 242);
            this.PAlbumPIC.TabIndex = 11;
            this.PAlbumPIC.TabStop = false;
            // 
            // PlayInfo3
            // 
            this.PlayInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayInfo3.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayInfo3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.PlayInfo3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PlayInfo3.Location = new System.Drawing.Point(68, 348);
            this.PlayInfo3.Name = "PlayInfo3";
            this.PlayInfo3.Size = new System.Drawing.Size(242, 18);
            this.PlayInfo3.TabIndex = 15;
            this.PlayInfo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msPlaytimebar
            // 
            this.msPlaytimebar.Animated = false;
            this.msPlaytimebar.AnimationSize = 0.2F;
            this.msPlaytimebar.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.msPlaytimebar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.msPlaytimebar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.msPlaytimebar.BackColor = System.Drawing.Color.White;
            this.msPlaytimebar.BackgroundImage = null;
            this.msPlaytimebar.ButtonAccentColor = System.Drawing.Color.LightCoral;
            this.msPlaytimebar.ButtonBorderColor = System.Drawing.Color.Salmon;
            this.msPlaytimebar.ButtonColor = System.Drawing.Color.Salmon;
            this.msPlaytimebar.ButtonCornerRadius = ((uint)(4u));
            this.msPlaytimebar.ButtonSize = new System.Drawing.Size(10, 10);
            this.msPlaytimebar.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Hybrid;
            this.msPlaytimebar.ContextMenuStrip = null;
            this.msPlaytimebar.LargeChange = 2;
            this.msPlaytimebar.Location = new System.Drawing.Point(81, 437);
            this.msPlaytimebar.Margin = new System.Windows.Forms.Padding(0);
            this.msPlaytimebar.Maximum = 100;
            this.msPlaytimebar.Minimum = 0;
            this.msPlaytimebar.Name = "msPlaytimebar";
            this.msPlaytimebar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.msPlaytimebar.ShowButtonOnHover = false;
            this.msPlaytimebar.Size = new System.Drawing.Size(505, 18);
            this.msPlaytimebar.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.msPlaytimebar.SmallChange = 10;
            this.msPlaytimebar.SmoothScrolling = true;
            this.msPlaytimebar.TabIndex = 17;
            this.msPlaytimebar.TickColor = System.Drawing.Color.DarkGray;
            this.msPlaytimebar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.msPlaytimebar.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.msPlaytimebar.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.msPlaytimebar.TrackDepth = 4;
            this.msPlaytimebar.TrackFillColor = System.Drawing.Color.MistyRose;
            this.msPlaytimebar.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.msPlaytimebar.TrackShadow = false;
            this.msPlaytimebar.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.msPlaytimebar.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.msPlaytimebar.Value = 0;
            this.msPlaytimebar.Scrolled += new MediaSlider.MediaSlider.ScrollDelegate(this.msPlaytimebar_Scrolled);
            this.msPlaytimebar.Click += new System.EventHandler(this.msPlaytimebar_Click);
            // 
            // msVoiceBar
            // 
            this.msVoiceBar.Animated = false;
            this.msVoiceBar.AnimationSize = 0.2F;
            this.msVoiceBar.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.msVoiceBar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.msVoiceBar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.msVoiceBar.BackColor = System.Drawing.Color.White;
            this.msVoiceBar.BackgroundImage = null;
            this.msVoiceBar.ButtonAccentColor = System.Drawing.Color.LightCoral;
            this.msVoiceBar.ButtonBorderColor = System.Drawing.Color.Salmon;
            this.msVoiceBar.ButtonColor = System.Drawing.Color.Salmon;
            this.msVoiceBar.ButtonCornerRadius = ((uint)(4u));
            this.msVoiceBar.ButtonSize = new System.Drawing.Size(10, 10);
            this.msVoiceBar.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Hybrid;
            this.msVoiceBar.ContextMenuStrip = null;
            this.msVoiceBar.LargeChange = 2;
            this.msVoiceBar.Location = new System.Drawing.Point(742, 437);
            this.msVoiceBar.Margin = new System.Windows.Forms.Padding(0);
            this.msVoiceBar.Maximum = 100;
            this.msVoiceBar.Minimum = 0;
            this.msVoiceBar.Name = "msVoiceBar";
            this.msVoiceBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.msVoiceBar.ShowButtonOnHover = false;
            this.msVoiceBar.Size = new System.Drawing.Size(108, 18);
            this.msVoiceBar.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.msVoiceBar.SmallChange = 1;
            this.msVoiceBar.SmoothScrolling = false;
            this.msVoiceBar.TabIndex = 17;
            this.msVoiceBar.TickColor = System.Drawing.Color.DarkGray;
            this.msVoiceBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.msVoiceBar.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.msVoiceBar.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.msVoiceBar.TrackDepth = 4;
            this.msVoiceBar.TrackFillColor = System.Drawing.Color.MistyRose;
            this.msVoiceBar.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.msVoiceBar.TrackShadow = false;
            this.msVoiceBar.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.msVoiceBar.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.msVoiceBar.Value = 100;
            this.msVoiceBar.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.msVoiceBar_ValueChanged);
            // 
            // picSound
            // 
            this.picSound.BackColor = System.Drawing.Color.Transparent;
            this.picSound.BackgroundImage = global::WindowsFormsApp1.Button_picture.volume;
            this.picSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSound.Location = new System.Drawing.Point(700, 428);
            this.picSound.Name = "picSound";
            this.picSound.Size = new System.Drawing.Size(35, 37);
            this.picSound.TabIndex = 18;
            this.picSound.TabStop = false;
            this.picSound.Click += new System.EventHandler(this.picSound_Click);
            // 
            // txtPlayTime
            // 
            this.txtPlayTime.AutoSize = true;
            this.txtPlayTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPlayTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPlayTime.Location = new System.Drawing.Point(35, 439);
            this.txtPlayTime.Name = "txtPlayTime";
            this.txtPlayTime.Size = new System.Drawing.Size(32, 16);
            this.txtPlayTime.TabIndex = 19;
            this.txtPlayTime.Text = "0:00";
            // 
            // txtAlltime
            // 
            this.txtAlltime.AutoSize = true;
            this.txtAlltime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAlltime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAlltime.Location = new System.Drawing.Point(594, 439);
            this.txtAlltime.Name = "txtAlltime";
            this.txtAlltime.Size = new System.Drawing.Size(32, 16);
            this.txtAlltime.TabIndex = 19;
            this.txtAlltime.Text = "0:00";
            // 
            // txtTipsPlay
            // 
            this.txtTipsPlay.AutoSize = true;
            this.txtTipsPlay.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtTipsPlay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTipsPlay.Location = new System.Drawing.Point(562, 199);
            this.txtTipsPlay.Name = "txtTipsPlay";
            this.txtTipsPlay.Size = new System.Drawing.Size(162, 18);
            this.txtTipsPlay.TabIndex = 20;
            this.txtTipsPlay.Text = "沒有音樂！請添加音樂！";
            // 
            // Form1
            // 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(882, 478);
            this.Controls.Add(this.txtTipsPlay);
            this.Controls.Add(this.txtAlltime);
            this.Controls.Add(this.txtPlayTime);
            this.Controls.Add(this.picSound);
            this.Controls.Add(this.msVoiceBar);
            this.Controls.Add(this.msPlaytimebar);
            this.Controls.Add(this.PlayInfo3);
            this.Controls.Add(this.PlayInfo2);
            this.Controls.Add(this.PlayInfo1);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddMusicFloder);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNextPlay);
            this.Controls.Add(this.btn_repeat);
            this.Controls.Add(this.btnPreviousPlay);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.PAlbumPIC);
            this.Controls.Add(this.WinMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Spicy Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAlbumPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_MinMize;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnPreviousPlay;
        private System.Windows.Forms.Button btnNextPlay;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox PAlbumPIC;
        private AxWMPLib.AxWindowsMediaPlayer WinMediaPlayer;
        private System.Windows.Forms.FolderBrowserDialog folderMedia;
        private System.Windows.Forms.Timer timerMedia;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnAddMusicFloder;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PlayInfo1;
        private System.Windows.Forms.TextBox PlayInfo2;
        private System.Windows.Forms.OpenFileDialog openFileMedia;
        private System.Windows.Forms.TextBox PlayInfo3;
        private MediaSlider.MediaSlider msPlaytimebar;
        private MediaSlider.MediaSlider msVoiceBar;
        private System.Windows.Forms.PictureBox picSound;
        private System.Windows.Forms.Label txtPlayTime;
        private System.Windows.Forms.Label txtAlltime;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label txtTipsPlay;
    }
}

