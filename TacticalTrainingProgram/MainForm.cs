using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TacticalTrainingProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.mainTableLayoutPanel.Visible = true;
            this.typesTablePanel.Visible = false;
            this.checkKnowlengePanel.Visible = false;
            this.theoryPanel.Visible = false;
            this.floatingPanel.Visible = false;
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
    }
}
