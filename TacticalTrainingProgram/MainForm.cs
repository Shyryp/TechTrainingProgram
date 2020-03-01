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
        private Point LocationForm;
        private FormWindowState formState;
        private int FormHeihgt = 0;
        private int FormWidth = 0;
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
            this.FormHeihgt = this.Height;
            this.FormWidth = this.Width;
            this.LocationForm = this.Location;
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
                    switch (i)
                    {
                        case 0: PausePanel0.Visible = false;
                            PlayPanel0.Visible = true;
                            trackBarProgress0.Value = 0;
                            trackBarVolume0.Value = 0;
                            trackBarProgress0.Enabled = false;
                            trackBarVolume0.Enabled = false;
                            PictureStartVideo0.Visible = true;
                            break;
                        case 1:
                            PausePanel1.Visible = false;
                            PlayPanel1.Visible = true;
                            trackBarProgress1.Value = 0;
                            trackBarVolume1.Value = 0;
                            trackBarProgress1.Enabled = false;
                            trackBarVolume1.Enabled = false;
                            PictureStartVideo1.Visible = true;
                            break;
                        case 2:
                            PausePanel2.Visible = false;
                            PlayPanel2.Visible = true;
                            trackBarProgress2.Value = 0;
                            trackBarVolume2.Value = 0;
                            trackBarProgress2.Enabled = false;
                            trackBarVolume2.Enabled = false;
                            PictureStartVideo2.Visible = true;
                            break;
                        case 3:
                            PausePanel3.Visible = false;
                            PlayPanel3.Visible = true;
                            trackBarProgress3.Value = 0;
                            trackBarVolume3.Value = 0;
                            trackBarProgress3.Enabled = false;
                            trackBarVolume3.Enabled = false;
                            PictureStartVideo3.Visible = true;
                            break;
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                FormHeihgt = this.Height;
                FormWidth = this.Width;
                LocationForm = this.Location;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fullscreen == 1)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = formState;
                    this.Height = FormHeihgt;
                    this.Width = FormWidth;
                    this.Location = LocationForm;

                    switch (AllInt)
                    {
                        case 0: video[AllInt].Owner = panelVideo0; break;
                        case 1: video[AllInt].Owner = panelVideo1; break;
                        case 2: video[AllInt].Owner = panelVideo2; break;
                        case 3: video[AllInt].Owner = panelVideo3; break;
                    }
                    fullscreen = 0;
                    
                }
            }
        }

        ///////////////////////000000000000

        private void PictureStartVideo0_Click(object sender, EventArgs e)
        {
            if (VideoOn[0] == 0)
            {
                if (VideoStarts[0] == 0)
                {
                    try
                    {
                        this.PictureStartVideo0.Visible = false;
                        this.Cursor = Cursors.WaitCursor;
                        this.video[0] = new Video(videoPaths[0], false);
                        this.Cursor = Cursors.Default;
                        this.video[0].Owner = panelVideo0;
                        this.PlayPanel0.Visible = false;
                        this.PausePanel0.Visible = true;
                        this.trackBarVolume0.Enabled = true;
                        this.VideoStarts[0] = 1;
                        this.VideoOn[0] = 1;
                        this.trackBarProgress0.Enabled = true;
                        this.trackBarProgress0.Value = (int)video[0].CurrentPosition;
                        this.trackBarProgress0.Maximum = (int)video[0].Duration;
                        this.timer0.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Second exception caught.", ex);
                        this.video[0] = null;
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
                            this.VideoOn[0] = 1;
                            this.TimeForVideo[0] = 0;
                            this.trackBarProgress0.Value = 0;
                            this.timer0.Start();
                            this.PlayPanel0.Visible = false;
                            this.PausePanel0.Visible = true;
                        }
                        else
                        {
                            this.video[0].Play();
                            this.PlayPanel0.Visible = false;
                            this.PausePanel0.Visible = true;
                            this.VideoOn[0] = 1;
                            this.trackBarProgress0.Value = (int)video[0].CurrentPosition;
                            this.timer0.Start();
                        }
                    }
                }
            }
            else if (VideoOn[0] == 1)
            {
                this.PlayPanel0.Visible = true;
                this.PausePanel0.Visible = false;
                if (video[0] != null) this.video[0].Pause();
                this.VideoOn[0] = 0;
            }
        }

        private void PausePanel0_Click(object sender, EventArgs e)
        {
            this.PlayPanel0.Visible = true;
            this.PausePanel0.Visible = false;
            if (this.VideoOn[0] == 1)
            {
                if (this.video[0] != null) this.video[0].Pause();
                this.VideoOn[0] = 0;
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
                this.VideoOn[0] = 0;
            }
        }

        private void TrackBarVolume0_Scroll(object sender, EventArgs e)
        {
            if (trackBarVolume0.Value > -5000)
            {
                this.video[0].Audio.Volume = trackBarVolume0.Value;
            }
            else
            {
                this.video[0].Audio.Volume = -10000;
            }
        }

        private void TrackBarProgress0_Scroll(object sender, EventArgs e)
        {
            video[0].CurrentPosition = trackBarProgress0.Value;
            if (trackBarProgress0.Value == trackBarProgress0.Maximum)
            {
                this.VideoOn[0] = 0;
                this.video[0].Pause();
                this.TimeForVideo[0] = 0;
                this.PlayPanel0.Visible = true;
                this.PausePanel0.Visible = false;
            }
        }

        private void FullscreenPanel0_Click(object sender, EventArgs e)
        {
            if (video[0] != null)
            {
                formState = this.WindowState;
                this.fullscreen = 1;
                this.AllInt = 0;
                this.video[0].Owner = this;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        
        private void Timer0_Tick(object sender, EventArgs e)
        {
            if (VideoOn[0] == 1)
            {
                this.TimeForVideo[0] += 1;
                if (TimeForVideo[0] == 9)
                {
                    if (trackBarProgress0.Maximum != trackBarProgress0.Value)
                    {
                        this.trackBarProgress0.Value += 1;
                        this.TimeForVideo[0] = 0;
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

        ///111111111111111111111111111////////////
        private void PictureStartVideo1_Click(object sender, EventArgs e)
        {
            if (VideoOn[1] == 0)
            {
                if (VideoStarts[1] == 0)
                {
                    try
                    {
                        this.PictureStartVideo1.Visible = false;
                        this.Cursor = Cursors.WaitCursor;
                        this.video[1] = new Video(videoPaths[1], false);
                        this.Cursor = Cursors.Default;
                        this.video[1].Owner = panelVideo1;
                        this.PlayPanel1.Visible = false;
                        this.PausePanel1.Visible = true;
                        this.trackBarVolume1.Enabled = true;
                        this.VideoStarts[1] = 1;
                        this.VideoOn[1] = 1;
                        this.trackBarProgress1.Enabled = true;
                        this.trackBarProgress1.Value = (int)video[1].CurrentPosition;
                        this.trackBarProgress1.Maximum = (int)video[1].Duration;
                        this.timer1.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Second exception caught.", ex);
                        this.video[1] = null;
                    }
                    if (video[1] != null) video[1].Play();

                }
                else
                {
                    if (video[1] != null)
                    {
                        if (trackBarProgress1.Value == trackBarProgress1.Maximum)
                        {
                            this.video[1].Stop();
                            this.video[1].Play();
                            this.VideoOn[1] = 1;
                            this.TimeForVideo[1] = 0;
                            this.trackBarProgress1.Value = 0;
                            this.timer1.Start();
                            this.PlayPanel1.Visible = false;
                            this.PausePanel1.Visible = true;
                        }
                        else
                        {
                            this.video[1].Play();
                            this.PlayPanel1.Visible = false;
                            this.PausePanel1.Visible = true;
                            this.VideoOn[1] = 1;
                            this.trackBarProgress1.Value = (int)video[1].CurrentPosition;
                            this.timer1.Start();
                        }
                    }
                }
            }
            else if (VideoOn[1] == 1)
            {
                this.PlayPanel1.Visible = true;
                this.PausePanel1.Visible = false;
                if (video[1] != null) this.video[1].Pause();
                this.VideoOn[1] = 0;
            }
        }

        private void PausePanel1_Click(object sender, EventArgs e)
        {
            this.PlayPanel1.Visible = true;
            this.PausePanel1.Visible = false;
            if (this.VideoOn[1] == 1)
            {
                if (this.video[1] != null) this.video[1].Pause();
                this.VideoOn[1] = 0;
            }
        }

        private void StopPanel1_Click(object sender, EventArgs e)
        {
            if (VideoStarts[1] == 1)
            {
                if (video[1] != null)
                {
                    this.PlayPanel1.Visible = true;
                    this.PausePanel1.Visible = false;
                    this.TimeForVideo[1] = 0;
                    this.trackBarProgress1.Value = 0;
                    this.trackBarProgress1.Maximum = (int)video[1].Duration;
                    this.video[1].Stop();
                }
                this.VideoOn[1] = 0;
            }
        }

        private void TrackBarVolume1_Scroll(object sender, EventArgs e)
        {
            if (trackBarVolume1.Value > -5000)
            {
                this.video[1].Audio.Volume = trackBarVolume1.Value;
            }
            else
            {
                this.video[1].Audio.Volume = -10000;
            }
        }

        private void TrackBarProgress1_Scroll(object sender, EventArgs e)
        {
            video[1].CurrentPosition = trackBarProgress1.Value;
            if (trackBarProgress1.Value == trackBarProgress1.Maximum)
            {
                this.VideoOn[1] = 0;
                this.video[1].Pause();
                this.TimeForVideo[1] = 0;
                this.PlayPanel1.Visible = true;
                this.PausePanel1.Visible = false;
            }
        }

        private void FullscreenPanel1_Click(object sender, EventArgs e)
        {
            if (video[1] != null)
            {
                formState = this.WindowState;
                this.fullscreen = 1;
                this.AllInt = 1;
                this.video[1].Owner = this;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (VideoOn[1] == 1)
            {
                this.TimeForVideo[1] += 1;
                if (TimeForVideo[1] == 9)
                {
                    if (trackBarProgress1.Maximum != trackBarProgress1.Value)
                    {
                        this.trackBarProgress1.Value += 1;
                        this.TimeForVideo[1] = 0;
                    }
                    else if (trackBarProgress1.Maximum == trackBarProgress1.Value)
                    {
                        this.video[1].Pause();
                        this.timer1.Stop();
                        this.PlayPanel1.Visible = true;
                        this.PausePanel1.Visible = false;
                    }
                }
            }
        }

        //////////////////////11111//////////////

        ///222222222222222222222222222222222222222////////////
        private void PictureStartVideo2_Click(object sender, EventArgs e)
        {
            if (VideoOn[2] == 0)
            {
                if (VideoStarts[2] == 0)
                {
                    try
                    {
                        this.PictureStartVideo2.Visible = false;
                        this.Cursor = Cursors.WaitCursor;
                        this.video[2] = new Video(videoPaths[2], false);
                        this.Cursor = Cursors.Default;
                        this.video[2].Owner = panelVideo2;
                        this.PlayPanel2.Visible = false;
                        this.PausePanel2.Visible = true;
                        this.trackBarVolume2.Enabled = true;
                        this.VideoStarts[2] = 1;
                        this.VideoOn[2] = 1;
                        this.trackBarProgress2.Enabled = true;
                        this.trackBarProgress2.Value = (int)video[2].CurrentPosition;
                        this.trackBarProgress2.Maximum = (int)video[2].Duration;
                        this.timer2.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Second exception caught.", ex);
                        this.video[2] = null;
                    }
                    if (video[2] != null) video[2].Play();

                }
                else
                {
                    if (video[2] != null)
                    {
                        if (trackBarProgress2.Value == trackBarProgress2.Maximum)
                        {
                            this.video[2].Stop();
                            this.video[2].Play();
                            this.VideoOn[2] = 1;
                            this.TimeForVideo[2] = 0;
                            this.trackBarProgress2.Value = 0;
                            this.timer2.Start();
                            this.PlayPanel2.Visible = false;
                            this.PausePanel2.Visible = true;
                        }
                        else
                        {
                            this.video[2].Play();
                            this.PlayPanel2.Visible = false;
                            this.PausePanel2.Visible = true;
                            this.VideoOn[2] = 1;
                            this.trackBarProgress2.Value = (int)video[2].CurrentPosition;
                            this.timer2.Start();
                        }
                    }
                }
            }
            else if (VideoOn[2] == 1)
            {
                this.PlayPanel2.Visible = true;
                this.PausePanel2.Visible = false;
                if (video[2] != null) this.video[2].Pause();
                this.VideoOn[2] = 0;
            }
        }

        private void PausePanel2_Click(object sender, EventArgs e)
        {
            this.PlayPanel2.Visible = true;
            this.PausePanel2.Visible = false;
            if (this.VideoOn[2] == 1)
            {
                if (this.video[2] != null) this.video[2].Pause();
                this.VideoOn[2] = 0;
            }
        }

        private void StopPanel2_Click(object sender, EventArgs e)
        {
            if (VideoStarts[2] == 1)
            {
                if (video[2] != null)
                {
                    this.PlayPanel2.Visible = true;
                    this.PausePanel2.Visible = false;
                    this.TimeForVideo[2] = 0;
                    this.trackBarProgress2.Value = 0;
                    this.trackBarProgress2.Maximum = (int)video[2].Duration;
                    this.video[2].Stop();
                }
                this.VideoOn[2] = 0;
            }
        }

        private void TrackBarVolume2_Scroll(object sender, EventArgs e)
        {
            if (trackBarVolume2.Value > -5000)
            {
                this.video[2].Audio.Volume = trackBarVolume2.Value;
            }
            else
            {
                this.video[2].Audio.Volume = -10000;
            }
        }

        private void TrackBarProgress2_Scroll(object sender, EventArgs e)
        {
            video[2].CurrentPosition = trackBarProgress2.Value;
            if (trackBarProgress2.Value == trackBarProgress2.Maximum)
            {
                this.VideoOn[2] = 0;
                this.video[2].Pause();
                this.TimeForVideo[2] = 0;
                this.PlayPanel2.Visible = true;
                this.PausePanel2.Visible = false;
            }
        }

        private void FullscreenPanel2_Click(object sender, EventArgs e)
        {
            if (video[2] != null)
            {
                formState = this.WindowState;
                this.fullscreen = 1;
                this.AllInt = 2;
                this.video[2].Owner = this;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (VideoOn[2] == 1)
            {
                this.TimeForVideo[2] += 1;
                if (TimeForVideo[2] == 9)
                {
                    if (trackBarProgress2.Maximum != trackBarProgress2.Value)
                    {
                        this.trackBarProgress2.Value += 1;
                        this.TimeForVideo[2] = 0;
                    }
                    else if (trackBarProgress2.Maximum == trackBarProgress2.Value)
                    {
                        this.video[2].Pause();
                        this.timer2.Stop();
                        this.PlayPanel2.Visible = true;
                        this.PausePanel2.Visible = false;
                    }
                }
            }
        }

        /////////////////////2222222//////////////

        ///33333333333333333333333333333////////////
        private void PictureStartVideo3_Click(object sender, EventArgs e)
        {
            if (VideoOn[3] == 0)
            {
                if (VideoStarts[3] == 0)
                {
                    try
                    {
                        this.PictureStartVideo3.Visible = false;
                        this.Cursor = Cursors.WaitCursor;
                        this.video[3] = new Video(videoPaths[3], false);
                        this.Cursor = Cursors.Default;
                        this.video[3].Owner = panelVideo3;
                        this.PlayPanel3.Visible = false;
                        this.PausePanel3.Visible = true;
                        this.trackBarVolume3.Enabled = true;
                        this.VideoStarts[3] = 1;
                        this.VideoOn[3] = 1;
                        this.trackBarProgress3.Enabled = true;
                        this.trackBarProgress3.Value = (int)video[3].CurrentPosition;
                        this.trackBarProgress3.Maximum = (int)video[3].Duration;
                        this.timer3.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Second exception caught.", ex);
                        this.video[3] = null;
                    }
                    if (video[3] != null) video[3].Play();

                }
                else
                {
                    if (video[3] != null)
                    {
                        if (trackBarProgress3.Value == trackBarProgress3.Maximum)
                        {
                            this.video[3].Stop();
                            this.video[3].Play();
                            this.VideoOn[3] = 1;
                            this.TimeForVideo[3] = 0;
                            this.trackBarProgress3.Value = 0;
                            this.timer3.Start();
                            this.PlayPanel3.Visible = false;
                            this.PausePanel3.Visible = true;
                        }
                        else
                        {
                            this.video[3].Play();
                            this.PlayPanel3.Visible = false;
                            this.PausePanel3.Visible = true;
                            this.VideoOn[3] = 1;
                            this.trackBarProgress3.Value = (int)video[3].CurrentPosition;
                            this.timer3.Start();
                        }
                    }
                }
            }
            else if (VideoOn[3] == 1)
            {
                this.PlayPanel3.Visible = true;
                this.PausePanel3.Visible = false;
                if (video[3] != null) this.video[3].Pause();
                this.VideoOn[3] = 0;
            }
        }

        private void PausePanel3_Click(object sender, EventArgs e)
        {
            this.PlayPanel3.Visible = true;
            this.PausePanel3.Visible = false;
            if (this.VideoOn[3] == 1)
            {
                if (this.video[3] != null) this.video[3].Pause();
                this.VideoOn[3] = 0;
            }
        }

        private void StopPanel3_Click(object sender, EventArgs e)
        {
            if (VideoStarts[3] == 1)
            {
                if (video[3] != null)
                {
                    this.PlayPanel3.Visible = true;
                    this.PausePanel3.Visible = false;
                    this.TimeForVideo[3] = 0;
                    this.trackBarProgress3.Value = 0;
                    this.trackBarProgress3.Maximum = (int)video[3].Duration;
                    this.video[3].Stop();
                }
                this.VideoOn[3] = 0;
            }
        }

        private void TrackBarVolume3_Scroll(object sender, EventArgs e)
        {
            if (trackBarVolume3.Value > -5000)
            {
                this.video[3].Audio.Volume = trackBarVolume3.Value;
            }
            else
            {
                this.video[3].Audio.Volume = -10000;
            }
        }

        private void TrackBarProgress3_Scroll(object sender, EventArgs e)
        {
            video[3].CurrentPosition = trackBarProgress3.Value;
            if (trackBarProgress3.Value == trackBarProgress3.Maximum)
            {
                this.VideoOn[3] = 0;
                this.video[3].Pause();
                this.TimeForVideo[3] = 0;
                this.PlayPanel3.Visible = true;
                this.PausePanel3.Visible = false;
            }
        }

        private void FullscreenPanel3_Click(object sender, EventArgs e)
        {
            if (video[3] != null)
            {
                formState = this.WindowState;
                this.fullscreen = 1;
                this.AllInt = 3;
                this.video[3].Owner = this;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (VideoOn[3] == 1)
            {
                this.TimeForVideo[3] += 1;
                if (TimeForVideo[3] == 9)
                {
                    if (trackBarProgress3.Maximum != trackBarProgress3.Value)
                    {
                        this.trackBarProgress3.Value += 1;
                        this.TimeForVideo[3] = 0;
                    }
                    else if (trackBarProgress3.Maximum == trackBarProgress3.Value)
                    {
                        this.video[3].Pause();
                        this.timer3.Stop();
                        this.PlayPanel3.Visible = true;
                        this.PausePanel3.Visible = false;
                    }
                }
            }
        }

        private void labelFloating_Click(object sender, EventArgs e)
        {

        }

        //////////////////////333333//////////////
    }
}
