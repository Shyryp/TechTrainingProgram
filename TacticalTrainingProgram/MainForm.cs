using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;
using System.Threading;

namespace TacticalTrainingProgram
{
    public partial class MainForm : Form
    {
        private int[] VideoOn = new int[10];
        private int[] TimeForVideo = new int[10];
        private int AllInt = 0;
        private int[] VideoStarts = new int[10];
        private int fullscreen = 0;
        private Video [] video = new Video[10];
        private string[] videoPaths;
        private string folderPath = Application.StartupPath + @"\Video\\";
        public MainForm()
        {
            InitializeComponent();
            this.mainTableLayoutPanel.Visible = true;
            this.typesTablePanel.Visible = false;
            this.checkKnowlengePanel.Visible = false;
            this.theoryPanel.Visible = false;
            this.floatingPanel.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            videoPaths = Directory.GetFiles(folderPath, "*.wmv");
            for (int i = 0; i < 10; i++)
            {
                TimeForVideo[i] = 0;
                video[i] = null;
                VideoOn[i] = 0;
                VideoStarts[i] = 0;
            }
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            AboutAuthor aboutA = new AboutAuthor();
            aboutA.ShowDialog();
            
        }

        private void bBackToTheory_Click(object sender, EventArgs e)
        {
            this.theoryPanel.Visible = true;
            this.checkKnowlengePanel.Visible = false;
        }

        private void bTheory_Click(object sender, EventArgs e)
        {
            this.theoryPanel.Visible = true;
            this.mainTableLayoutPanel.Visible = false;
        }

        private void bVar1_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(1, this);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                testForm.Show();
                
            }
            
        }

        private void bVar2_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(2, this);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                testForm.Show();
                
            }
        }

        private void bVar3_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(3, this);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                testForm.Show();
                
            }
        }

        private void bVar4_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(4, this);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                testForm.Show();
                
            }
        }

        private void bVar5_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(5, this);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                testForm.Show();
                
            }
        }

        private void bVarRandom_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(0, this);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                testForm.Show();
                
            }
        }

        private void bMap_Click(object sender, EventArgs e)
        {
            MapForm map = new MapForm(this);
            this.Visible = false;
            map.ShowDialog();
            
        }

        private void bGotoTypeCrossing_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.theoryPanel.Visible = false;
        }

        private void bGotoPractice_Click(object sender, EventArgs e)
        {
            this.checkKnowlengePanel.Visible = true;
            this.theoryPanel.Visible = false;
        }

        private void bGotoVideo_Click(object sender, EventArgs e)
        {
            
            this.videoPanel.Visible = true;
            this.theoryPanel.Visible = false;
        }

        private void bBackToTheoryFromVideo_Click(object sender, EventArgs e)
        {            
            this.theoryPanel.Visible = true;
            this.videoPanel.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                if (VideoStarts[i] == 1)
                {
                    VideoOn[i] = 0;
                    VideoStarts[i] = 0;
                    video[i].Dispose();
                    video[i] = null;
                    switch (AllInt)
                    {
                        case 0: PausePanel1.Visible = false; PlayPanel1.Visible = true; break;
                        case 1: PausePanel2.Visible = false; PlayPanel2.Visible = true; break;
                        case 2: PausePanel3.Visible = false; PlayPanel3.Visible = true; break;

                    }
                }

            }
        }

        private void bBackToTheoryFromType_Click(object sender, EventArgs e)
        {
            this.theoryPanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bBackToMain_Click(object sender, EventArgs e)
        {
            this.mainTableLayoutPanel.Visible = true;
            this.theoryPanel.Visible = false;
        }

        private void bBackToTypeFromFloating_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.floatingPanel.Visible = false;
        }

        private void bGotoFloating_Click(object sender, EventArgs e)
        {
            this.floatingPanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bBackToTheoryFromBridge_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.bridgePanel.Visible = false;
        }

        private void bGotoBridge_Click(object sender, EventArgs e)
        {
            this.bridgePanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bBackToTheoryFromIce_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.icePanel.Visible = false;
        }

        private void bGotoIce_Click(object sender, EventArgs e)
        {
            this.icePanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bBackToTheoryFromFerry_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.ferryPanel.Visible = false;
        }

        private void bGotoFerry_Click(object sender, EventArgs e)
        {
            this.ferryPanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bBackToTheoryFromUnder_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.underPanel.Visible = false;
        }

        private void bGotoUnder_Click(object sender, EventArgs e)
        {
            this.underPanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bGotoFord_Click(object sender, EventArgs e)
        {
            this.fordPanel.Visible = true;
            this.typesTablePanel.Visible = false;
        }

        private void bBackToTheoryFromFord_Click(object sender, EventArgs e)
        {
            this.typesTablePanel.Visible = true;
            this.fordPanel.Visible = false;
        }

        private void panelVideo1_Click(object sender, EventArgs e)
        {
            if (VideoOn[0] == 0)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.video[0] = new Video(videoPaths[0], false);
                    this.Cursor = Cursors.Default;
                    this.video[0].Owner = panelVideo1;
                    this.PlayPanel1.Visible = false;
                    this.PausePanel1.Visible = true;
                    this.trackBarVolume1.Enabled = true;
                    this.VideoStarts[0] = 1;
                    this.VideoOn[0] = 1;
                    this.TimeForVideo[0] = 0;
                    this.trackBarProgress1.Enabled = true;
                    this.trackBarProgress1.Value = (int)video[0].CurrentPosition;
                    this.trackBarProgress1.Maximum = (int)video[0].Duration;
                    this.timer1.Start();
                }
                catch (Exception ex)
                {
                    video[0] = null;
                }
                if (video[0] != null) video[0].Play();
                
            }
        }

        private void trackBarVolume1_Scroll(object sender, EventArgs e)
        {
            if (trackBarVolume1.Value > -5000)
            {
                video[0].Audio.Volume = trackBarVolume1.Value;
            }
            else
            {
                video[0].Audio.Volume = -10000;
            }
        }

        private void PlayPanel1_Click(object sender, EventArgs e)
        {
            if (VideoOn[0] == 0)
            {
                if (VideoStarts[0] == 0)
                {

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        video[0] = new Video(videoPaths[0], false);
                        this.Cursor = Cursors.Default;
                        video[0].Owner = panelVideo1;
                        this.PlayPanel1.Visible = false;
                        this.PausePanel1.Visible = true;
                        this.trackBarVolume1.Visible = true;
                        VideoStarts[0] = 1;
                        VideoOn[0] = 1;
                        trackBarProgress1.Value = (int)video[0].CurrentPosition;
                        trackBarProgress1.Maximum = (int)video[0].Duration;
                        timer1.Start();
                    }
                    catch (Exception ex)
                    {
                        video[0] = null;
                    }
                    if (video[0] != null) video[0].Play();

                }
                else
                {
                    if (video[0] != null)
                    {
                        video[0].Play();
                        this.PlayPanel1.Visible = false;
                        this.PausePanel1.Visible = true;
                        VideoOn[0] = 1;
                        trackBarProgress1.Value = (int)video[0].CurrentPosition;
                        timer1.Start();
                    }
                }
            }
            else if (VideoOn[0] == 1)
            {
                this.PlayPanel1.Visible = true;
                this.PausePanel1.Visible = false;
                if (video[0] != null) video[0].Pause();
                VideoOn[0] = 0;
            }
        }
        private void PausePanel1_Click(object sender, EventArgs e)
        {
            this.PlayPanel1.Visible = true;
            this.PausePanel1.Visible = false;
            if (VideoOn[0] == 1)
            {
                if (video[0] != null) video[0].Pause();
                VideoOn[0] = 0;
            }
        }

        private void StopPanel1_Click(object sender, EventArgs e)
        {
            if (VideoStarts[0] == 1)
            {
                if (video[0] != null) {
                    this.PlayPanel1.Visible = true;
                    this.PausePanel1.Visible = false;
                    this.TimeForVideo[0] = 0;
                    this.trackBarProgress1.Value = 0;
                    this.trackBarProgress1.Maximum = (int)video[0].Duration;
                    this.video[0].Stop();
                }
                VideoOn[0] = 0;
            }
        }
        
        private void FullscreenPanel1_Click(object sender, EventArgs e)
        {
            if (video[0] != null)
            {
                fullscreen = 1;
                AllInt = 0;
                video[0].Owner = this;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                this.Focus();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fullscreen == 1)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;


                    switch (AllInt)
                    {
                        case 0: video[AllInt].Owner = panelVideo1; break;
                        case 1: video[AllInt].Owner = panelVideo2; break;
                        case 2: video[AllInt].Owner = panelVideo3; break;

                    }
                    fullscreen = 0;
                }
            }
        }

        private void panelVideo2_Click(object sender, EventArgs e)
        {
            if (VideoOn[1] == 0)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    video[1] = new Video(videoPaths[1], false);
                    this.Cursor = Cursors.Default;
                    video[1].Owner = panelVideo2;
                    this.PlayPanel2.Visible = false;
                    this.PausePanel2.Visible = true;
                    VideoStarts[1] = 1;
                    VideoOn[1] = 1;
                }
                catch (Exception ex)
                {
                    video[1] = null;
                }
                if (video[1] != null) video[1].Play();

            }
        }

        private void PlayPanel2_Click(object sender, EventArgs e)
        {
            if (VideoOn[1] == 0)
            {
                if (VideoStarts[1] == 0)
                {

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        video[1] = new Video(videoPaths[1], false);
                        this.Cursor = Cursors.Default;
                        video[1].Owner = panelVideo2;
                        this.PlayPanel2.Visible = false;
                        this.PausePanel2.Visible = true;
                        VideoStarts[1] = 1;
                        VideoOn[1] = 1;
                    }
                    catch (Exception ex)
                    {
                        video[1] = null;
                    }
                    if (video[1] != null) video[1].Play();

                }
                else
                {
                    if (video[1] != null) video[1].Play();
                    this.PlayPanel2.Visible = false;
                    this.PausePanel2.Visible = true;
                    VideoOn[1] = 1;
                }
            }
        }
        
        private void PausePanel2_Click(object sender, EventArgs e)
        {
            this.PlayPanel2.Visible = true;
            this.PausePanel2.Visible = false;
            if (VideoOn[1] == 1)
            {
                if (video[1] != null) video[1].Pause();
                VideoOn[1] = 0;
            }
        }

        private void StopPanel2_Click(object sender, EventArgs e)
        {
            if (VideoOn[1] == 1)
            {
                this.PlayPanel2.Visible = true;
                this.PausePanel2.Visible = false;
                if (video[1] != null) video[1].Stop();
                VideoOn[1] = 0;
            }
        }

        private void FullscreenPanel2_Click(object sender, EventArgs e)
        {
            if (video[1] != null)
            {
                fullscreen = 1;
                AllInt = 1;
                video[1].Owner = this;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                this.Focus();
            }
        }







        private void panelVideo3_Click(object sender, EventArgs e)
        {
            if (VideoOn[2] == 0)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    video[2] = new Video(videoPaths[2], false);
                    this.Cursor = Cursors.Default;
                    video[2].Owner = panelVideo3;
                    this.PlayPanel3.Visible = false;
                    this.PausePanel3.Visible = true;
                    VideoStarts[2] = 1;
                    VideoOn[2] = 1;
                }
                catch (Exception ex)
                {
                    video[2] = null;
                }
                if (video[2] != null) video[2].Play();

            }
        }

        private void PlayPanel3_Click(object sender, EventArgs e)
        {
            if (VideoOn[2] == 0)
            {
                if (VideoStarts[2] == 0)
                {

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        video[2] = new Video(videoPaths[2], false);
                        this.Cursor = Cursors.Default;
                        video[2].Owner = panelVideo3;
                        this.PlayPanel3.Visible = false;
                        this.PausePanel3.Visible = true;
                        VideoStarts[2] = 1;
                        VideoOn[2] = 1;
                    }
                    catch (Exception ex)
                    {
                        video[2] = null;
                    }
                    if (video[2] != null) video[2].Play();

                }
                else
                {
                    if (video[2] != null) video[2].Play();
                    this.PlayPanel3.Visible = false;
                    this.PausePanel3.Visible = true;
                    VideoOn[2] = 1;
                }
            }
        }

        private void PausePanel3_Click(object sender, EventArgs e)
        {
            this.PlayPanel3.Visible = true;
            this.PausePanel3.Visible = false;
            if (VideoOn[2] == 1)
            {
                if (video[2] != null) video[2].Pause();
                VideoOn[2] = 0;
            }
        }

        private void StopPanel3_Click(object sender, EventArgs e)
        {
            if (VideoOn[2] == 1)
            {
                this.PlayPanel3.Visible = true;
                this.PausePanel3.Visible = false;
                if (video[2] != null) video[2].Stop();
                VideoOn[2] = 0;
            }
        }

        private void FullscreenPanel3_Click(object sender, EventArgs e)
        {
            if (video[2] != null)
            {
                fullscreen = 1;
                AllInt = 2;
                video[2].Owner = this;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                this.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VideoOn[0] == 1)
            {
                TimeForVideo[0] += 1;
                if (TimeForVideo[0] == 9)
                {
                    if (trackBarProgress1.Maximum != trackBarProgress1.Value)
                    {
                        trackBarProgress1.Value += 1;
                        TimeForVideo[0] = 0;
                    }
                    else if (trackBarProgress1.Maximum == trackBarProgress1.Value)
                    {
                        this.video[0].Pause();
                        this.timer1.Stop();
                        this.PlayPanel1.Visible = true;
                        this.PausePanel1.Visible = false;

                    }
                }
            }
        }

        private void trackBarProgress1_Scroll(object sender, EventArgs e)
        {
            video[0].CurrentPosition = trackBarProgress1.Value;
            if (trackBarProgress1.Value < trackBarProgress1.Maximum)
            {
                this.timer1.Start();
                VideoOn[0] = 1;
                TimeForVideo[0] = 1;
                this.PlayPanel1.Visible = false;
                this.PausePanel1.Visible = true;
                this.video[0].Play();
            }
        }
    }
}
