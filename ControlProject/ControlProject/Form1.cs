using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorSelection1_ColorSelected(object sender, CustomControls.ColorSelectionEventArgs e)
        {
            label1.Text = e.SelectedColor.R.ToString();
            label1.Text += ", " + e.SelectedColor.G.ToString();
            label1.Text += ", " + e.SelectedColor.B.ToString();
        }
    }
}
