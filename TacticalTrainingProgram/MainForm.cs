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
            this.tacticalTablePanel.Visible = false;
            this.checkKnowlengePanel.Visible = false;
            this.theoryPanel.Visible = false;
            this.techPanel.Visible = false;
        }


        private void bTactical_Click(object sender, EventArgs e)
        {
            this.tacticalTablePanel.Visible = true;
            this.mainTableLayoutPanel.Visible = false;
            
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            AboutAuthor aboutA = new AboutAuthor();
            aboutA.ShowDialog();
        }


        private void bCheckKnowlenge_Click(object sender, EventArgs e)
        {
            this.checkKnowlengePanel.Visible = true;
            this.tacticalTablePanel.Visible = false;
            
        }

        private void bBackToMain_Click(object sender, EventArgs e)
        {
            this.mainTableLayoutPanel.Visible = true;
            this.tacticalTablePanel.Visible = false;
            
        }

        private void bBackToTactical_Click(object sender, EventArgs e)
        {
            this.tacticalTablePanel.Visible = true;
            this.checkKnowlengePanel.Visible = false;
        }

        private void bTheory_Click(object sender, EventArgs e)
        {
            this.theoryPanel.Visible = true;
            this.tacticalTablePanel.Visible = false;
        }

        private void bBackToTacticalThe_Click(object sender, EventArgs e)
        {
            this.tacticalTablePanel.Visible = true;
            this.theoryPanel.Visible = false;
        }

        private void bTech_Click(object sender, EventArgs e)
        {
            this.techPanel.Visible = true;
            this.mainTableLayoutPanel.Visible = false;  
        }

        private void bBackToMainTech_Click(object sender, EventArgs e)
        {
            this.mainTableLayoutPanel.Visible = true;
            this.techPanel.Visible = false;
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
    }
}
