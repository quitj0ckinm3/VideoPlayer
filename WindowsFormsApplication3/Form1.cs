using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Tortuga : Form
    {
        Boolean videoPage = false;
        Boolean userStopped = false;
        List<String> videoFileNames = new List<String>();
        List<String> previousVideoFileNames = new List<String>();

        public Tortuga()
        {
            InitializeComponent();
            mediaPlayer.settings.volume = 100;
            //mediaPlayer.uiMode = "none";
        }

        private void Tortuga_Load(object sender, EventArgs e)
        {
            dirTabCtrl.Selected += dirTabCtrl_Selected;
            mediaPlayer.PlayStateChange += mediaPlayer_PlayStateChange;
            this.chSurfTab.ToolTipText = "Select which directory to play videos from.";
            this.seqTab.ToolTipText = "Select which directory to play videos from.";
        }

        private void fullScreenBtn_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.URL.Length > 0)
            {
                mediaPlayer.fullScreen = true;
            }
        }

        private void dirTabCtrl_Selected(Object sender, TabControlEventArgs e)
        {

            if (e.TabPageIndex == 0)
                videoPage = false;
            else if (e.TabPageIndex == 1)
                videoPage = true;
        }

        private void dirBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                videoFileNames.Clear();
                fbd.ShowNewFolderButton = false;
                fbd.Description = "Select the directory of your movie collection";
                fbd.ShowDialog();
                if (fbd.SelectedPath.Length > 0)
                {
                    if (!videoPage)
                    {
                        seqListBox.Items.Add(fbd.SelectedPath);
                    }
                    else if (videoPage)
                    {
                        chSurfListBox.Items.Add(fbd.SelectedPath);
                    }
                }
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.URL.Length > 0)
            {
                if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
                {
                    mediaPlayer.Ctlcontrols.stop();
                    mediaPlayer.Ctlcontrols.currentPosition = 0;
                }
            }
        }

        private void playBtnBtn_Click(object sender, EventArgs e)
        {
            if (userStopped)
            {
                mediaPlayer.Ctlcontrols.play();
                userStopped = false;
            }
            else
            {
                List<String> dirNames = new List<String>();
                if (!videoPage)
                {
                    dirNames.Clear();
                    videoFileNames.Clear();
                    if (seqListBox.SelectedIndices.Count > 0)
                    {
                        foreach (Object selectedItem in seqListBox.SelectedItems)
                        {
                            dirNames.Add(selectedItem as String);
                        }
                        if (dirNames.Count() > 0)
                            foreach (String dir in dirNames)
                            {
                                foreach (string filename in Directory.GetFiles(dir, "." ,System.IO.SearchOption.AllDirectories))
                                {
                                    if (filename.ToLower().EndsWith(".mp4") == true || filename.ToLower().EndsWith(".avi") == true)
                                    {
                                        videoFileNames.Add(filename);
                                    }
                                }
                            }

                        if (videoFileNames.Count() > 1)
                        {
                            mediaPlayer.URL = videoFileNames[0];
                            previousVideoFileNames.Add(videoFileNames[0]);
                            videoFileNames.RemoveAt(0);
                        }

                    }
                }
                else if (videoPage)
                {
                    dirNames.Clear();
                    videoFileNames.Clear();
                    if (chSurfListBox.SelectedIndices.Count > 0)
                    {
                        foreach (Object selectedItem in chSurfListBox.SelectedItems)
                        {
                            dirNames.Add(selectedItem as String);
                        }
                        if (dirNames.Count() > 0)
                            foreach (String dir in dirNames)
                            {
                                foreach (string filename in Directory.GetFiles(dir, ".", System.IO.SearchOption.AllDirectories))
                                {
                                    if (filename.ToLower().EndsWith(".mp4") == true || filename.ToLower().EndsWith(".avi") == true)
                                    {
                                        videoFileNames.Add(filename);
                                    }
                                }
                            }

                        if (videoFileNames.Count() > 1)
                        {
                            int rndIndex = randomIndex();
                            mediaPlayer.URL = videoFileNames[rndIndex];
                            previousVideoFileNames.Add(videoFileNames[rndIndex]);
                        }
                    }
                    
                }
            }
        }

        private void finishPlaybackTimer_Tick(object sender, EventArgs e)
        {
            if (isFinish())
            {
                mediaPlayer.Ctlcontrols.play();
                finishPlaybackTimer.Stop();
            }
        }

        private bool isFinish()
        {
            return (mediaPlayer.playState == WMPPlayState.wmppsReady);
        }

        private bool isPlaying()
        {
            return (mediaPlayer.playState == WMPPlayState.wmppsPlaying);
        }

        private int randomIndex()
        {
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, videoFileNames.Count());
            return rndIndex;
        }

        private void clearListBox_Click(object sender, EventArgs e)
        {
            if (isPlaying())
            {
                mediaPlayer.Ctlcontrols.stop();
                videoFileNames.Clear();
                previousVideoFileNames.Clear();
                userStopped = false;
            }
            if (videoPage)
            {
                for (int i = chSurfListBox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    chSurfListBox.Items.RemoveAt(chSurfListBox.SelectedIndices[i]);
                }
            }
            else if (!videoPage)
            {
                for (int i = seqListBox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    seqListBox.Items.RemoveAt(seqListBox.SelectedIndices[i]);
                }
            }
        }

        private void changeChannelBtn_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.URL.Length > 0 || mediaPlayer.playState == WMPPlayState.wmppsStopped)
            {
                if (videoPage)
                {
                    int rndIndex = randomIndex();
                    mediaPlayer.URL = videoFileNames[rndIndex];
                    previousVideoFileNames.Add(videoFileNames[rndIndex]);
                    durationTimer.Start();
                }
                else if (!videoPage)
                {
                    if (videoFileNames.Count() > 0)
                    {
                        mediaPlayer.URL = videoFileNames[0];
                        previousVideoFileNames.Add(videoFileNames[0]);
                        videoFileNames.RemoveAt(0);
                    }
                }
            }
        }

        private void durationTimer_Tick(object sender, EventArgs e)
        {
            if (isPlaying())
            {
                Random rnd = new Random();
                int duration = Convert.ToInt32(mediaPlayer.currentMedia.duration);
                double newPos = rnd.Next(0, duration / 2);
                mediaPlayer.Ctlcontrols.currentPosition = newPos;
                durationTimer.Stop();
            }
        }

        private void prevChannelBtn_Click(object sender, EventArgs e)
        {
            if (previousVideoFileNames.Count() > 0)
            {
                if (videoPage)
                {
                    mediaPlayer.URL = previousVideoFileNames[0];
                    previousVideoFileNames.RemoveAt(0);
                    durationTimer.Start();
                }
                else if (!videoPage)
                {
                    mediaPlayer.URL = previousVideoFileNames[0];
                    videoFileNames.Insert(0, previousVideoFileNames[0]);
                    previousVideoFileNames.RemoveAt(0);
                }
            }
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                if (videoPage)
                {
                    mediaPlayer.URL = videoFileNames[randomIndex()];
                    finishPlaybackTimer.Start();
                }
                else if (!videoPage)
                {
                    if (videoFileNames.Count() > 0)
                    {
                        mediaPlayer.URL = videoFileNames[0];
                        videoFileNames.RemoveAt(0);
                        finishPlaybackTimer.Start();
                    }

                }
            }
            if (e.newState == 1)
            {
                userStopped = true;
            }
        }
    }
}
