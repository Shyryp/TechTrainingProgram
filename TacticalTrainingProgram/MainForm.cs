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
            this.KeyPreview = true;
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
                    TimeForVideo[i] = 0;
                    switch (AllInt)
                    {
                        case 0: PausePanel0.Visible = false;
                            PlayPanel0.Visible = true;
                            trackBarProgress0.Value = 0;
                            trackBarVolume0.Value = 0;
                            trackBarProgress0.Enabled = false;
                            trackBarVolume0.Enabled = false;
                            break;
                        //case 1: PausePanel1.Visible = false; PlayPanel1.Visible = true; break;
                        //case 2: PausePanel2.Visible = false; PlayPanel2.Visible = true; break;
                        //case 3: PausePanel2.Visible = false; PlayPanel3.Visible = true; break;
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
                        case 0: video[AllInt].Owner = panelVideo0; break;
                            //case 1: video[AllInt].Owner = panelVideo1; break;
                            //case 2: video[AllInt].Owner = panelVideo2; break;
                            //case 3: video[AllInt].Owner = panelVideo3; break;
                    }
                    fullscreen = 0;
                    
                }
            }
        }

        ///////////////////////000000000000

        private void PanelVideo0_Click(object sender, EventArgs e)
        {
            if (VideoOn[0] == 0)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.video[0] = new Video(videoPaths[0], false);
                    this.Cursor = Cursors.Default;
                    this.video[0].Owner = panelVideo0;
                    this.PlayPanel0.Visible = false;
                    this.PausePanel0.Visible = true;
                    this.trackBarVolume0.Enabled = true;
                    this.VideoStarts[0] = 1;
                    this.VideoOn[0] = 1;
                    this.TimeForVideo[0] = 0;
                    this.trackBarProgress0.Enabled = true;
                    this.trackBarProgress0.Value = (int)video[0].CurrentPosition;
                    this.trackBarProgress0.Maximum = (int)video[0].Duration;
                    this.timer0.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Second exception caught.", ex);
                    video[0] = null;
                }
                if (video[0] != null) video[0].Play();

            }
        }

        private void PlayPanel0_Click(object sender, EventArgs e)
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
                        video[0].Owner = panelVideo0;
                        this.PlayPanel0.Visible = false;
                        this.PausePanel0.Visible = true;
                        this.trackBarVolume0.Visible = true;
                        VideoStarts[0] = 1;
                        VideoOn[0] = 1;
                        trackBarProgress0.Value = (int)video[0].CurrentPosition;
                        trackBarProgress0.Maximum = (int)video[0].Duration;
                        timer0.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Second exception caught.", ex);
                        video[0] = null;
                    }
                    if (video[0] != null) video[0].Play();

                }
                else
                {
                    if (video[0] != null)
                    {
                        if (trackBarProgress0.Value == trackBarProgress0.Maximum)
                        {
                            this.video[0].Stop();
                            this.video[0].Play();
                            VideoOn[0] = 1;
                            TimeForVideo[0] = 0;
                            trackBarProgress0.Value = 0;
                            this.timer0.Start();
                            this.PlayPanel0.Visible = false;
                            this.PausePanel0.Visible = true;
                        }
                        else
                        {
                            video[0].Play();
                            this.PlayPanel0.Visible = false;
                            this.PausePanel0.Visible = true;
                            VideoOn[0] = 1;
                            trackBarProgress0.Value = (int)video[0].CurrentPosition;
                            timer0.Start();
                        }
                    }
                }
            }
            else if (VideoOn[0] == 1)
            {
                this.PlayPanel0.Visible = true;
                this.PausePanel0.Visible = false;
                if (video[0] != null) video[0].Pause();
                VideoOn[0] = 0;
            }
        }

        private void PausePanel0_Click(object sender, EventArgs e)
        {
            this.PlayPanel0.Visible = true;
            this.PausePanel0.Visible = false;
            if (VideoOn[0] == 1)
            {
                if (video[0] != null) video[0].Pause();
                VideoOn[0] = 0;
            }
        }

        private void StopPanel0_Click(object sender, EventArgs e)
        {
            if (VideoStarts[0] == 1)
            {
                if (video[0] != null)
                {
                    this.PlayPanel0.Visible = true;
                    this.PausePanel0.Visible = false;
                    this.TimeForVideo[0] = 0;
                    this.trackBarProgress0.Value = 0;
                    this.trackBarProgress0.Maximum = (int)video[0].Duration;
                    this.video[0].Stop();
                }
                VideoOn[0] = 0;
            }
        }

        private void TrackBarVolume0_Scroll(object sender, EventArgs e)
        {
            if (trackBarVolume0.Value > -5000)
            {
                video[0].Audio.Volume = trackBarVolume0.Value;
            }
            else
            {
                video[0].Audio.Volume = -10000;
            }
        }

        private void TrackBarProgress0_Scroll(object sender, EventArgs e)
        {
            video[0].CurrentPosition = trackBarProgress0.Value;
            if (trackBarProgress0.Value == trackBarProgress0.Maximum)
            {
                VideoOn[0] = 0;
                this.video[0].Pause();
                TimeForVideo[0] = 0;
                this.PlayPanel0.Visible = true;
                this.PausePanel0.Visible = false;
            }
        }

        private void FullscreenPanel0_Click(object sender, EventArgs e)
        {
            if (video[0] != null)
            {
                fullscreen = 1;
                AllInt = 0;
                video[0].Owner = this;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }
        
        private void Timer0_Tick(object sender, EventArgs e)
        {
            if (VideoOn[0] == 1)
            {
                TimeForVideo[0] += 1;
                if (TimeForVideo[0] == 9)
                {
                    if (trackBarProgress0.Maximum != trackBarProgress0.Value)
                    {
                        trackBarProgress0.Value += 1;
                        TimeForVideo[0] = 0;
                    }
                    else if (trackBarProgress0.Maximum == trackBarProgress0.Value)
                    {
                        this.video[0].Pause();
                        this.timer0.Stop();
                        this.PlayPanel0.Visible = true;
                        this.PausePanel0.Visible = false;
                    }
                }
            }
        }
        ///////////////////////000000000000/////////////////
    }
}
