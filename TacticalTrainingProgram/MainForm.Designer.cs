using System.Drawing;

namespace TacticalTrainingProgram
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.Panel();
            this.bTech = new System.Windows.Forms.Button();
            this.bTactical = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.checkKnowlengePanel = new System.Windows.Forms.Panel();
            this.bVarRandom = new System.Windows.Forms.Button();
            this.bMap = new System.Windows.Forms.Button();
            this.bVar5 = new System.Windows.Forms.Button();
            this.bBackToTactical = new System.Windows.Forms.Button();
            this.bVar4 = new System.Windows.Forms.Button();
            this.bVar3 = new System.Windows.Forms.Button();
            this.bVar2 = new System.Windows.Forms.Button();
            this.bVar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tacticalTablePanel = new System.Windows.Forms.Panel();
            this.bBackToMain = new System.Windows.Forms.Button();
            this.bCheckKnowlenge = new System.Windows.Forms.Button();
            this.labelTactical = new System.Windows.Forms.Label();
            this.bTheory = new System.Windows.Forms.Button();
            this.techPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTech = new System.Windows.Forms.Label();
            this.bBackToMainTech = new System.Windows.Forms.Button();
            this.theoryPanel = new System.Windows.Forms.Panel();
            this.labelTheory = new System.Windows.Forms.Label();
            this.bBackToTacticalThe = new System.Windows.Forms.Button();
            this.theoryPanelChild = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.checkKnowlengePanel.SuspendLayout();
            this.tacticalTablePanel.SuspendLayout();
            this.techPanel.SuspendLayout();
            this.theoryPanel.SuspendLayout();
            this.theoryPanelChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.fon3;
            this.mainTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTableLayoutPanel.Controls.Add(this.bTech);
            this.mainTableLayoutPanel.Controls.Add(this.bTactical);
            this.mainTableLayoutPanel.Controls.Add(this.bAbout);
            this.mainTableLayoutPanel.Controls.Add(this.mainLabel);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(736, 484);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // bTech
            // 
            this.bTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTech.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bTech.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bTech.Location = new System.Drawing.Point(541, 410);
            this.bTech.Name = "bTech";
            this.bTech.Size = new System.Drawing.Size(126, 35);
            this.bTech.TabIndex = 2;
            this.bTech.Text = "Тех. часть";
            this.bTech.UseCompatibleTextRendering = true;
            this.bTech.UseVisualStyleBackColor = false;
            this.bTech.Click += new System.EventHandler(this.bTech_Click);
            // 
            // bTactical
            // 
            this.bTactical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTactical.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bTactical.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bTactical.Location = new System.Drawing.Point(313, 410);
            this.bTactical.Name = "bTactical";
            this.bTactical.Size = new System.Drawing.Size(192, 35);
            this.bTactical.TabIndex = 1;
            this.bTactical.Text = "О водных преградах";
            this.bTactical.UseCompatibleTextRendering = true;
            this.bTactical.UseVisualStyleBackColor = false;
            this.bTactical.Click += new System.EventHandler(this.bTactical_Click);
            // 
            // bAbout
            // 
            this.bAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAbout.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bAbout.Location = new System.Drawing.Point(50, 410);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(130, 35);
            this.bAbout.TabIndex = 0;
            this.bAbout.Text = "Об авторах";
            this.bAbout.UseCompatibleTextRendering = true;
            this.bAbout.UseVisualStyleBackColor = false;
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Tahoma", 28F);
            this.mainLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.mainLabel.Location = new System.Drawing.Point(70, 119);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(656, 188);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "ГОУ ВО \"Омский Государственный \r\nтехнический университет\r\nВоенная кафедра\r\n\"Техни" +
    "ческая подготовка\" \r\n";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.UseCompatibleTextRendering = true;
            // 
            // checkKnowlengePanel
            // 
            this.checkKnowlengePanel.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.fon3;
            this.checkKnowlengePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkKnowlengePanel.Controls.Add(this.bVarRandom);
            this.checkKnowlengePanel.Controls.Add(this.bMap);
            this.checkKnowlengePanel.Controls.Add(this.bVar5);
            this.checkKnowlengePanel.Controls.Add(this.bBackToTactical);
            this.checkKnowlengePanel.Controls.Add(this.bVar4);
            this.checkKnowlengePanel.Controls.Add(this.bVar3);
            this.checkKnowlengePanel.Controls.Add(this.bVar2);
            this.checkKnowlengePanel.Controls.Add(this.bVar1);
            this.checkKnowlengePanel.Controls.Add(this.label2);
            this.checkKnowlengePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkKnowlengePanel.Location = new System.Drawing.Point(0, 0);
            this.checkKnowlengePanel.Name = "checkKnowlengePanel";
            this.checkKnowlengePanel.Size = new System.Drawing.Size(736, 484);
            this.checkKnowlengePanel.TabIndex = 5;
            // 
            // bVarRandom
            // 
            this.bVarRandom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVarRandom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVarRandom.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bVarRandom.Location = new System.Drawing.Point(118, 413);
            this.bVarRandom.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bVarRandom.Name = "bVarRandom";
            this.bVarRandom.Size = new System.Drawing.Size(200, 40);
            this.bVarRandom.TabIndex = 5;
            this.bVarRandom.Text = "Случайный набор";
            this.bVarRandom.UseCompatibleTextRendering = true;
            this.bVarRandom.UseVisualStyleBackColor = false;
            this.bVarRandom.Click += new System.EventHandler(this.bVarRandom_Click);
            // 
            // bMap
            // 
            this.bMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bMap.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.bMap.Image = global::TacticalTrainingProgram.Properties.Resources.map;
            this.bMap.Location = new System.Drawing.Point(421, 186);
            this.bMap.Margin = new System.Windows.Forms.Padding(60, 80, 3, 80);
            this.bMap.Name = "bMap";
            this.bMap.Size = new System.Drawing.Size(220, 208);
            this.bMap.TabIndex = 1;
            this.bMap.Text = "Карта";
            this.bMap.UseCompatibleTextRendering = true;
            this.bMap.UseVisualStyleBackColor = true;
            this.bMap.Click += new System.EventHandler(this.bMap_Click);
            // 
            // bVar5
            // 
            this.bVar5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVar5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVar5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bVar5.Location = new System.Drawing.Point(118, 354);
            this.bVar5.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bVar5.Name = "bVar5";
            this.bVar5.Size = new System.Drawing.Size(200, 40);
            this.bVar5.TabIndex = 4;
            this.bVar5.Text = "Вариант 5";
            this.bVar5.UseCompatibleTextRendering = true;
            this.bVar5.UseVisualStyleBackColor = false;
            this.bVar5.Click += new System.EventHandler(this.bVar5_Click);
            // 
            // bBackToTactical
            // 
            this.bBackToTactical.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBackToTactical.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.bBackToTactical.Location = new System.Drawing.Point(3, 3);
            this.bBackToTactical.Name = "bBackToTactical";
            this.bBackToTactical.Size = new System.Drawing.Size(120, 45);
            this.bBackToTactical.TabIndex = 0;
            this.bBackToTactical.Text = "<- Назад";
            this.bBackToTactical.UseCompatibleTextRendering = true;
            this.bBackToTactical.UseVisualStyleBackColor = false;
            this.bBackToTactical.Click += new System.EventHandler(this.bBackToTactical_Click);
            // 
            // bVar4
            // 
            this.bVar4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVar4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVar4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bVar4.Location = new System.Drawing.Point(118, 296);
            this.bVar4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bVar4.Name = "bVar4";
            this.bVar4.Size = new System.Drawing.Size(200, 40);
            this.bVar4.TabIndex = 3;
            this.bVar4.Text = "Вариант 4";
            this.bVar4.UseCompatibleTextRendering = true;
            this.bVar4.UseVisualStyleBackColor = false;
            this.bVar4.Click += new System.EventHandler(this.bVar4_Click);
            // 
            // bVar3
            // 
            this.bVar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVar3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVar3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bVar3.Location = new System.Drawing.Point(118, 238);
            this.bVar3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bVar3.Name = "bVar3";
            this.bVar3.Size = new System.Drawing.Size(200, 40);
            this.bVar3.TabIndex = 2;
            this.bVar3.Text = "Вариант 3";
            this.bVar3.UseCompatibleTextRendering = true;
            this.bVar3.UseVisualStyleBackColor = false;
            this.bVar3.Click += new System.EventHandler(this.bVar3_Click);
            // 
            // bVar2
            // 
            this.bVar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVar2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bVar2.Location = new System.Drawing.Point(118, 180);
            this.bVar2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bVar2.Name = "bVar2";
            this.bVar2.Size = new System.Drawing.Size(200, 40);
            this.bVar2.TabIndex = 1;
            this.bVar2.Text = "Вариант 2";
            this.bVar2.UseCompatibleTextRendering = true;
            this.bVar2.UseVisualStyleBackColor = false;
            this.bVar2.Click += new System.EventHandler(this.bVar2_Click);
            // 
            // bVar1
            // 
            this.bVar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVar1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bVar1.Location = new System.Drawing.Point(118, 122);
            this.bVar1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.bVar1.Name = "bVar1";
            this.bVar1.Size = new System.Drawing.Size(200, 40);
            this.bVar1.TabIndex = 0;
            this.bVar1.Text = "Вариант 1";
            this.bVar1.UseCompatibleTextRendering = true;
            this.bVar1.UseVisualStyleBackColor = false;
            this.bVar1.Click += new System.EventHandler(this.bVar1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.Location = new System.Drawing.Point(237, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проверка знаний";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // tacticalTablePanel
            // 
            this.tacticalTablePanel.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.fon3;
            this.tacticalTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tacticalTablePanel.Controls.Add(this.bBackToMain);
            this.tacticalTablePanel.Controls.Add(this.bCheckKnowlenge);
            this.tacticalTablePanel.Controls.Add(this.labelTactical);
            this.tacticalTablePanel.Controls.Add(this.bTheory);
            this.tacticalTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tacticalTablePanel.Location = new System.Drawing.Point(0, 0);
            this.tacticalTablePanel.Name = "tacticalTablePanel";
            this.tacticalTablePanel.Size = new System.Drawing.Size(736, 484);
            this.tacticalTablePanel.TabIndex = 4;
            // 
            // bBackToMain
            // 
            this.bBackToMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBackToMain.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.bBackToMain.Location = new System.Drawing.Point(3, 3);
            this.bBackToMain.Name = "bBackToMain";
            this.bBackToMain.Size = new System.Drawing.Size(120, 45);
            this.bBackToMain.TabIndex = 0;
            this.bBackToMain.Text = "<- Назад";
            this.bBackToMain.UseCompatibleTextRendering = true;
            this.bBackToMain.UseVisualStyleBackColor = false;
            this.bBackToMain.Click += new System.EventHandler(this.bBackToMain_Click);
            // 
            // bCheckKnowlenge
            // 
            this.bCheckKnowlenge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheckKnowlenge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCheckKnowlenge.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bCheckKnowlenge.Location = new System.Drawing.Point(511, 410);
            this.bCheckKnowlenge.Name = "bCheckKnowlenge";
            this.bCheckKnowlenge.Size = new System.Drawing.Size(158, 35);
            this.bCheckKnowlenge.TabIndex = 1;
            this.bCheckKnowlenge.Text = "Проверка знаний";
            this.bCheckKnowlenge.UseCompatibleTextRendering = true;
            this.bCheckKnowlenge.UseVisualStyleBackColor = false;
            this.bCheckKnowlenge.Click += new System.EventHandler(this.bCheckKnowlenge_Click);
            // 
            // labelTactical
            // 
            this.labelTactical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTactical.AutoSize = true;
            this.labelTactical.BackColor = System.Drawing.Color.Transparent;
            this.labelTactical.Font = new System.Drawing.Font("Tahoma", 25F);
            this.labelTactical.Location = new System.Drawing.Point(208, 93);
            this.labelTactical.Name = "labelTactical";
            this.labelTactical.Size = new System.Drawing.Size(340, 41);
            this.labelTactical.TabIndex = 0;
            this.labelTactical.Text = "О водных преградах";
            this.labelTactical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bTheory
            // 
            this.bTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bTheory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bTheory.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.bTheory.Location = new System.Drawing.Point(50, 410);
            this.bTheory.Name = "bTheory";
            this.bTheory.Size = new System.Drawing.Size(130, 35);
            this.bTheory.TabIndex = 0;
            this.bTheory.Text = "Теория";
            this.bTheory.UseCompatibleTextRendering = true;
            this.bTheory.UseVisualStyleBackColor = false;
            this.bTheory.Click += new System.EventHandler(this.bTheory_Click);
            // 
            // techPanel
            // 
            this.techPanel.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.fon3;
            this.techPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.techPanel.Controls.Add(this.panel1);
            this.techPanel.Controls.Add(this.labelTech);
            this.techPanel.Controls.Add(this.bBackToMainTech);
            this.techPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techPanel.Location = new System.Drawing.Point(0, 0);
            this.techPanel.Name = "techPanel";
            this.techPanel.Size = new System.Drawing.Size(736, 484);
            this.techPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(70, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 358);
            this.panel1.TabIndex = 2;
            // 
            // labelTech
            // 
            this.labelTech.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTech.AutoSize = true;
            this.labelTech.BackColor = System.Drawing.Color.Transparent;
            this.labelTech.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.labelTech.Location = new System.Drawing.Point(208, 20);
            this.labelTech.Name = "labelTech";
            this.labelTech.Size = new System.Drawing.Size(312, 41);
            this.labelTech.TabIndex = 1;
            this.labelTech.Text = "Техническая часть";
            // 
            // bBackToMainTech
            // 
            this.bBackToMainTech.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBackToMainTech.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.bBackToMainTech.Location = new System.Drawing.Point(3, 3);
            this.bBackToMainTech.Name = "bBackToMainTech";
            this.bBackToMainTech.Size = new System.Drawing.Size(120, 45);
            this.bBackToMainTech.TabIndex = 0;
            this.bBackToMainTech.Text = "<- Назад";
            this.bBackToMainTech.UseCompatibleTextRendering = true;
            this.bBackToMainTech.UseVisualStyleBackColor = false;
            this.bBackToMainTech.Click += new System.EventHandler(this.bBackToMainTech_Click);
            // 
            // theoryPanel
            // 
            this.theoryPanel.BackgroundImage = global::TacticalTrainingProgram.Properties.Resources.fon3;
            this.theoryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theoryPanel.Controls.Add(this.labelTheory);
            this.theoryPanel.Controls.Add(this.bBackToTacticalThe);
            this.theoryPanel.Controls.Add(this.theoryPanelChild);
            this.theoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theoryPanel.Location = new System.Drawing.Point(0, 0);
            this.theoryPanel.Name = "theoryPanel";
            this.theoryPanel.Size = new System.Drawing.Size(736, 484);
            this.theoryPanel.TabIndex = 6;
            // 
            // labelTheory
            // 
            this.labelTheory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTheory.AutoSize = true;
            this.labelTheory.BackColor = System.Drawing.Color.Transparent;
            this.labelTheory.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.labelTheory.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelTheory.Location = new System.Drawing.Point(306, 30);
            this.labelTheory.Name = "labelTheory";
            this.labelTheory.Size = new System.Drawing.Size(130, 41);
            this.labelTheory.TabIndex = 1;
            this.labelTheory.Text = "Теория";
            // 
            // bBackToTacticalThe
            // 
            this.bBackToTacticalThe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBackToTacticalThe.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.bBackToTacticalThe.Location = new System.Drawing.Point(3, 3);
            this.bBackToTacticalThe.Name = "bBackToTacticalThe";
            this.bBackToTacticalThe.Size = new System.Drawing.Size(120, 45);
            this.bBackToTacticalThe.TabIndex = 0;
            this.bBackToTacticalThe.Text = "<- Назад";
            this.bBackToTacticalThe.UseCompatibleTextRendering = true;
            this.bBackToTacticalThe.UseVisualStyleBackColor = false;
            this.bBackToTacticalThe.Click += new System.EventHandler(this.bBackToTacticalThe_Click);
            // 
            // theoryPanelChild
            // 
            this.theoryPanelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.theoryPanelChild.AutoScroll = true;
            this.theoryPanelChild.BackColor = System.Drawing.SystemColors.ControlLight;
            this.theoryPanelChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theoryPanelChild.Controls.Add(this.label1);
            this.theoryPanelChild.Location = new System.Drawing.Point(67, 92);
            this.theoryPanelChild.Name = "theoryPanelChild";
            this.theoryPanelChild.Size = new System.Drawing.Size(600, 334);
            this.theoryPanelChild.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 771);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 484);
            this.Controls.Add(this.tacticalTablePanel);
            this.Controls.Add(this.techPanel);
            this.Controls.Add(this.theoryPanel);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.checkKnowlengePanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(642, 523);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техническая подготовка";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.checkKnowlengePanel.ResumeLayout(false);
            this.checkKnowlengePanel.PerformLayout();
            this.tacticalTablePanel.ResumeLayout(false);
            this.tacticalTablePanel.PerformLayout();
            this.techPanel.ResumeLayout(false);
            this.techPanel.PerformLayout();
            this.theoryPanel.ResumeLayout(false);
            this.theoryPanel.PerformLayout();
            this.theoryPanelChild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.Button bTactical;
        private System.Windows.Forms.Button bTech;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label labelTactical;
        private System.Windows.Forms.Button bBackToMain;
        private System.Windows.Forms.Button bCheckKnowlenge;
        private System.Windows.Forms.Button bTheory;
        private System.Windows.Forms.Button bBackToTactical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bVar1;
        private System.Windows.Forms.Button bVar2;
        private System.Windows.Forms.Button bVar3;
        private System.Windows.Forms.Button bVar4;
        private System.Windows.Forms.Button bVar5;
        private System.Windows.Forms.Button bMap;
        private System.Windows.Forms.Button bVarRandom;
        private System.Windows.Forms.Panel mainTableLayoutPanel;
        private System.Windows.Forms.Panel tacticalTablePanel;
        private System.Windows.Forms.Panel checkKnowlengePanel;
        private System.Windows.Forms.Panel theoryPanel;
        private System.Windows.Forms.Button bBackToTacticalThe;
        private System.Windows.Forms.Panel theoryPanelChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTheory;
        private System.Windows.Forms.Panel techPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTech;
        private System.Windows.Forms.Button bBackToMainTech;
    }
}

