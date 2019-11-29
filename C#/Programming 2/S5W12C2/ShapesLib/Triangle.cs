using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Triangle : Shape
    {
        private double sideSize;
        private double hight;

        public Triangle(double side, double hight):base(3)
        {
            this.sideSize = side;
            this.hight = hight;
        }

        public override double GetArea()
        {
            return sideSize * hight / 2;
        }
    }
}
