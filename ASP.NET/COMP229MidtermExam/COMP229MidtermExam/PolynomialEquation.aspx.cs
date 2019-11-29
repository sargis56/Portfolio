using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229MidtermExam
{
    public partial class PolynomialEquation : System.Web.UI.Page
    {
        double x1;
        double x2;
        double a;
        double b;
        double c;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBoxA.Text);
            b = Convert.ToDouble(TextBoxB.Text);
            c = Convert.ToDouble(TextBoxC.Text);

            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            TextBoxAnswer1.Text = Convert.ToString(x1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBoxA.Text);
            b = Convert.ToDouble(TextBoxB.Text);
            c = Convert.ToDouble(TextBoxC.Text);

            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            TextBoxAnswer2.Text = Convert.ToString(x2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBoxA.Text);
            b = Convert.ToDouble(TextBoxB.Text);
            c = Convert.ToDouble(TextBoxC.Text);

            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            TextBoxAnswer1.Text = Convert.ToString(x1);
            TextBoxAnswer2.Text = Convert.ToString(x2);
        }
    }
}