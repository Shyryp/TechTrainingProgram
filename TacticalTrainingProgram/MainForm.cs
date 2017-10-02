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

namespace TacticalTrainingProgram
{
    public partial class MainForm : Form
    {
        private int[] VideoOn = new int[10];
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
                VideoAreaX[i] = 0;
                VideoAreaY[i] = 0;
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
                    
                    video[0] = new Video(videoPaths[0], false);
                    this.Cursor = Cursors.Default;
                    video[0].Owner = panelVideo1;
                    this.PlayPanel1.Visible = false;
                    this.PausePanel1.Visible = true;
                    VideoStarts[0] = 1;
                    VideoOn[0] = 1;
                }
                catch (Exception ex)
                {
                    video[0] = null;
                }
                if (video[0] != null) video[0].Play();
                
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
                        VideoStarts[0] = 1;
                        VideoOn[0] = 1;
                    }
                    catch (Exception ex)
                    {
                        video[0] = null;
                    }
                    if (video[0] != null) video[0].Play();

                }
                else {
                    if (video[0] != null) video[0].Play();
                    this.PlayPanel1.Visible = false;
                    this.PausePanel1.Visible = true;
                    VideoOn[0] = 1;
                }
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
            if (VideoOn[0] == 1)
            {
                this.PlayPanel1.Visible = true;
                this.PausePanel1.Visible = false;
                if (video[0] != null) video[0].Stop();
                VideoOn[0] = 0;
            }
        }
        private Size maxSize;
        private void FullscreenPanel1_Click(object sender, EventArgs e)
        {
            if (video[0] != null)
            {
                fullscreen = 1;
                

                maxSize = video[0].Size;
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
                    

                    video[0].Size = maxSize;
                    video[0].Owner = panelVideo1;
                    
                    fullscreen = 0;
                }
            }
        }


    }
}
