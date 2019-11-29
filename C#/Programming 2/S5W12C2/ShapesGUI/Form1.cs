using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLib;
namespace ShapesGUI
{
    public partial class Form1 : Form
    {
        ShapeRepository sr;
        public Form1()
        {
            InitializeComponent();
            sr = new ShapeRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbShapes.Items.AddRange(sr.Shapes.ToArray());
        }

        private void lsbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shape aShape = (Shape)lsbShapes.SelectedItem;
            lblArea.Text = "Area for " + aShape.GetType() + " is " + aShape.GetArea();
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            AddShapeForm frmAddShape = new AddShapeForm();
            frmAddShape.ShowDialog(this);
        }
    }
}
