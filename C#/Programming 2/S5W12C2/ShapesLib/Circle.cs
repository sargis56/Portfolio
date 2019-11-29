using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double rad) :base(0)
        {
            radius = rad;
        }

        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
