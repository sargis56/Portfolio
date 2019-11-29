using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Rectangle : Shape
    {
        private double sizeOfSideA;
        private double sizeOfSideB;

        public Rectangle(double sideA, double sideB):base(4)
        {
            sizeOfSideA = sideA;
            sizeOfSideB = sideB;
        }



        public override double GetArea()
        {
            return sizeOfSideA * sizeOfSideB;
        }
    }
}
