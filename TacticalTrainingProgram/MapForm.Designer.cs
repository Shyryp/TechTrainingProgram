namespace TacticalTrainingProgram
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.MainPanelMap = new System.Windows.Forms.TableLayoutPanel();
            this.panelForElemets = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelMap = new System.Windows.Forms.Panel();
            this.MainPanelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanelMap
            // 
            this.MainPanelMap.ColumnCount = 2;
            this.MainPanelMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.MainPanelMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanelMap.Controls.Add(this.panelForElemets, 0, 1);
            this.MainPanelMap.Controls.Add(this.PanelMap, 1, 1);
            this.MainPanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelMap.Location = new System.Drawing.Point(0, 0);
            this.MainPanelMap.Name = "MainPanelMap";
            this.MainPanelMap.RowCount = 3;
            this.MainPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.MainPanelMap.Size = new System.Drawing.Size(932, 555);
            this.MainPanelMap.TabIndex = 0;
            // 
            // panelForElemets
            // 
            this.panelForElemets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForElemets.Location = new System.Drawing.Point(3, 28);
            this.panelForElemets.Name = "panelForElemets";
            this.panelForElemets.Size = new System.Drawing.Size(206, 465);
            this.panelForElemets.TabIndex = 0;
            // 
            // PanelMap
            // 
            this.PanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMap.Location = new System.Drawing.Point(215, 28);
            this.PanelMap.Name = "PanelMap";
            this.PanelMap.Size = new System.Drawing.Size(714, 465);
            this.PanelMap.TabIndex = 1;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 555);
            this.Controls.Add(this.MainPanelMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapForm_FormClosing);
            this.MainPanelMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanelMap;
        private System.Windows.Forms.FlowLayoutPanel panelForElemets;
        private System.Windows.Forms.Panel PanelMap;
    }
}