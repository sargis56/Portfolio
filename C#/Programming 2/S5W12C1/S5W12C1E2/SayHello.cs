using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S5W12C1E2
{
    public partial class SayHello : Form
    {
        public SayHello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                lblGretting.Text = "You have not input the name.";
            }
            else
            {
                lblGretting.Text = "Hello, " + name + "!";
            } 
        }
    }
}
