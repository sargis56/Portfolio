using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S5W12C2E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Index: " + lsbShapes.SelectedIndex.ToString() + " Item: " + lsbShapes.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbShapes.Items.Add("Circle");
            lsbShapes.Items.Add("Triangle");
            lsbShapes.Items.Add("Rectengale");
        }

        private void lblSelection_Click(object sender, EventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string shapeName = txtShapeName.Text;
            if (shapeName == "")
                return;
            lsbShapes.Items.Add(shapeName);
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            lsbShapes.Items.RemoveAt(lsbShapes.SelectedIndex);
        }
    }
}
