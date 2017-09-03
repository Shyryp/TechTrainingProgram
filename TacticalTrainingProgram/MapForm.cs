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
    public partial class MapForm : Form
    {
        MainForm parentForm;
        public MapForm(MainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void MapForm_FormClosing(object sender, CancelEventArgs e)
        {
            parentForm.Visible = true;
        }
    }
}
