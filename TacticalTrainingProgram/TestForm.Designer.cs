namespace TacticalTrainingProgram
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bNext = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.panelTest = new System.Windows.Forms.Panel();
            this.labelText1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bNext);
            this.panel1.Controls.Add(this.bStop);
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 62);
            this.panel1.TabIndex = 0;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bNext.Location = new System.Drawing.Point(674, 5);
            this.bNext.Margin = new System.Windows.Forms.Padding(4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(236, 53);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "Продолжить";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bStop
            // 
            this.bStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bStop.Location = new System.Drawing.Point(372, 5);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(232, 53);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Завершить";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBack.Location = new System.Drawing.Point(79, 5);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(221, 53);
            this.bBack.TabIndex = 0;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // panelTest
            // 
            this.panelTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelTest.AutoScroll = true;
            this.panelTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTest.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.wallpaper2;
            this.panelTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTest.Controls.Add(this.labelText1);
            this.panelTest.Location = new System.Drawing.Point(63, 1);
            this.panelTest.Margin = new System.Windows.Forms.Padding(4);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(850, 590);
            this.panelTest.TabIndex = 1;
            // 
            // labelText1
            // 
            this.labelText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelText1.AutoSize = true;
            this.labelText1.BackColor = System.Drawing.Color.Transparent;
            this.labelText1.Font = new System.Drawing.Font("Tahoma", 23.25F);
            this.labelText1.Location = new System.Drawing.Point(241, 11);
            this.labelText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(375, 55);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "Вариант 1 Вопрос 1";
            this.labelText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelText1.UseCompatibleTextRendering = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.wallpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTest);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Label labelText1;
    }
}