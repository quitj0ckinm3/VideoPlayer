namespace WindowsFormsApplication3
{
    partial class Tortuga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tortuga));
            this.playBtn = new System.Windows.Forms.Button();
            this.dirTabCtrl = new System.Windows.Forms.TabControl();
            this.seqTab = new System.Windows.Forms.TabPage();
            this.seqListBox = new System.Windows.Forms.ListBox();
            this.chSurfTab = new System.Windows.Forms.TabPage();
            this.chSurfListBox = new System.Windows.Forms.ListBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.fullScreenBtn = new System.Windows.Forms.Button();
            this.clearListBox = new System.Windows.Forms.Button();
            this.dirBtn = new System.Windows.Forms.Button();
            this.finishPlaybackTimer = new System.Windows.Forms.Timer(this.components);
            this.changeChannelBtn = new System.Windows.Forms.Button();
            this.prevChannelBtn = new System.Windows.Forms.Button();
            this.durationTimer = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.dirTabCtrl.SuspendLayout();
            this.seqTab.SuspendLayout();
            this.chSurfTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playBtn.AutoSize = true;
            this.playBtn.Location = new System.Drawing.Point(12, 695);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtnBtn_Click);
            // 
            // dirTabCtrl
            // 
            this.dirTabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirTabCtrl.Controls.Add(this.seqTab);
            this.dirTabCtrl.Controls.Add(this.chSurfTab);
            this.dirTabCtrl.Location = new System.Drawing.Point(773, 12);
            this.dirTabCtrl.Name = "dirTabCtrl";
            this.dirTabCtrl.SelectedIndex = 0;
            this.dirTabCtrl.ShowToolTips = true;
            this.dirTabCtrl.Size = new System.Drawing.Size(227, 677);
            this.dirTabCtrl.TabIndex = 2;
            // 
            // seqTab
            // 
            this.seqTab.Controls.Add(this.seqListBox);
            this.seqTab.Location = new System.Drawing.Point(4, 22);
            this.seqTab.Name = "seqTab";
            this.seqTab.Padding = new System.Windows.Forms.Padding(3);
            this.seqTab.Size = new System.Drawing.Size(219, 651);
            this.seqTab.TabIndex = 0;
            this.seqTab.Text = "Sequential Videos";
            this.seqTab.UseVisualStyleBackColor = true;
            // 
            // seqListBox
            // 
            this.seqListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seqListBox.FormattingEnabled = true;
            this.seqListBox.HorizontalScrollbar = true;
            this.seqListBox.Location = new System.Drawing.Point(6, 6);
            this.seqListBox.Name = "seqListBox";
            this.seqListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.seqListBox.Size = new System.Drawing.Size(207, 641);
            this.seqListBox.TabIndex = 0;
            // 
            // chSurfTab
            // 
            this.chSurfTab.Controls.Add(this.chSurfListBox);
            this.chSurfTab.Location = new System.Drawing.Point(4, 22);
            this.chSurfTab.Name = "chSurfTab";
            this.chSurfTab.Padding = new System.Windows.Forms.Padding(3);
            this.chSurfTab.Size = new System.Drawing.Size(219, 651);
            this.chSurfTab.TabIndex = 1;
            this.chSurfTab.Text = "Channel Surf Videos";
            this.chSurfTab.UseVisualStyleBackColor = true;
            // 
            // chSurfListBox
            // 
            this.chSurfListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chSurfListBox.FormattingEnabled = true;
            this.chSurfListBox.HorizontalScrollbar = true;
            this.chSurfListBox.Location = new System.Drawing.Point(7, 7);
            this.chSurfListBox.Name = "chSurfListBox";
            this.chSurfListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.chSurfListBox.Size = new System.Drawing.Size(206, 641);
            this.chSurfListBox.TabIndex = 0;
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopBtn.Location = new System.Drawing.Point(93, 695);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // fullScreenBtn
            // 
            this.fullScreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenBtn.Location = new System.Drawing.Point(921, 695);
            this.fullScreenBtn.Name = "fullScreenBtn";
            this.fullScreenBtn.Size = new System.Drawing.Size(75, 23);
            this.fullScreenBtn.TabIndex = 4;
            this.fullScreenBtn.Text = "Fullscreen";
            this.fullScreenBtn.UseVisualStyleBackColor = true;
            this.fullScreenBtn.Click += new System.EventHandler(this.fullScreenBtn_Click);
            // 
            // clearListBox
            // 
            this.clearListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearListBox.Location = new System.Drawing.Point(840, 695);
            this.clearListBox.Name = "clearListBox";
            this.clearListBox.Size = new System.Drawing.Size(75, 23);
            this.clearListBox.TabIndex = 5;
            this.clearListBox.Text = "Remove Dir";
            this.clearListBox.UseVisualStyleBackColor = true;
            this.clearListBox.Click += new System.EventHandler(this.clearListBox_Click);
            // 
            // dirBtn
            // 
            this.dirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dirBtn.AutoSize = true;
            this.dirBtn.Location = new System.Drawing.Point(808, 695);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(26, 23);
            this.dirBtn.TabIndex = 6;
            this.dirBtn.Text = "...";
            this.dirBtn.UseVisualStyleBackColor = true;
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // finishPlaybackTimer
            // 
            this.finishPlaybackTimer.Tick += new System.EventHandler(this.finishPlaybackTimer_Tick);
            // 
            // changeChannelBtn
            // 
            this.changeChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeChannelBtn.AutoSize = true;
            this.changeChannelBtn.Location = new System.Drawing.Point(174, 695);
            this.changeChannelBtn.Name = "changeChannelBtn";
            this.changeChannelBtn.Size = new System.Drawing.Size(96, 23);
            this.changeChannelBtn.TabIndex = 7;
            this.changeChannelBtn.Text = "Change Channel";
            this.changeChannelBtn.UseVisualStyleBackColor = true;
            this.changeChannelBtn.Click += new System.EventHandler(this.changeChannelBtn_Click);
            // 
            // prevChannelBtn
            // 
            this.prevChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevChannelBtn.AutoSize = true;
            this.prevChannelBtn.Location = new System.Drawing.Point(276, 695);
            this.prevChannelBtn.Name = "prevChannelBtn";
            this.prevChannelBtn.Size = new System.Drawing.Size(100, 23);
            this.prevChannelBtn.TabIndex = 8;
            this.prevChannelBtn.Text = "Previous Channel";
            this.prevChannelBtn.UseVisualStyleBackColor = true;
            this.prevChannelBtn.Click += new System.EventHandler(this.prevChannelBtn_Click);
            // 
            // durationTimer
            // 
            this.durationTimer.Tick += new System.EventHandler(this.durationTimer_Tick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(755, 677);
            this.mediaPlayer.TabIndex = 0;
            // 
            // Tortuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.prevChannelBtn);
            this.Controls.Add(this.changeChannelBtn);
            this.Controls.Add(this.dirBtn);
            this.Controls.Add(this.clearListBox);
            this.Controls.Add(this.fullScreenBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.dirTabCtrl);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.mediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tortuga";
            this.Text = "Tortuga";
            this.Load += new System.EventHandler(this.Tortuga_Load);
            this.dirTabCtrl.ResumeLayout(false);
            this.seqTab.ResumeLayout(false);
            this.chSurfTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.TabControl dirTabCtrl;
        private System.Windows.Forms.TabPage seqTab;
        private System.Windows.Forms.TabPage chSurfTab;
        private System.Windows.Forms.ListBox seqListBox;
        private System.Windows.Forms.ListBox chSurfListBox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button fullScreenBtn;
        private System.Windows.Forms.Button clearListBox;
        private System.Windows.Forms.Button dirBtn;
        private System.Windows.Forms.Timer finishPlaybackTimer;
        private System.Windows.Forms.Button changeChannelBtn;
        private System.Windows.Forms.Button prevChannelBtn;
        private System.Windows.Forms.Timer durationTimer;
    }
}

