using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S5W12C2E4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbtnHappy_CheckedChanged(object sender, EventArgs e)
        {
            lblFeel.Text = "You are " + (cbtnHappy.Checked ? "" : "not ") + "happy";
            groupBox1.Visible = cbtnHappy.Checked;
            lblHow.Visible = cbtnHappy.Checked;
        }

        private void rbtnExcellent_CheckedChanged(object sender, EventArgs e)
        {
            //lblHow.Text = rbtnExcellent.Checked ? "Excellent" : "";
            //lblHow.Text = rbtnGood.Checked ? "Good" : "";
            //lblHow.Text = rbtnCouldBeBetter.Checked ? "Could be better" : "";
            if (rbtnExcellent.Checked)
            {
                lblHow.Text = "Excellent";
            }
            else if (rbtnGood.Checked)
            {
                lblHow.Text = "Good";
            }
            else
            {
                lblHow.Text = "Could be better";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
