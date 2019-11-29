using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S5W12C2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Index: " + lsbShape.SelectedIndex.ToString() + " Item: " + lsbShape.SelectedItem;
        }
    }
}
