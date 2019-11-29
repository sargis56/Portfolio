using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ShapesLib
{
    public abstract class Shape
    {
        Point[] vertecies;

        public int NoOfSides { get; private set; }

        public Shape()
        {

        }

        public Point[] Vertecies
        {
            get
            {
                return vertecies;
            }

            set
            {
                if (value.Length == NoOfSides)
                {
                    vertecies = value;
                }
                else
                {
                    throw new ArgumentException("Wrong number of vericies");
                }

            }
        }

        public Shape(int noOfSides)
        {
            this.NoOfSides = noOfSides;
        }

        public abstract double GetArea();
    }
}
