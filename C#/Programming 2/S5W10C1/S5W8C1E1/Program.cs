using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLib;

namespace S5W10C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[4];

            shape[0] = new Triangle(10, 10);
            Console.WriteLine(shape[0].GetArea());
            //shape[1].GetArea();
            //shape[2].GetArea();
            //shape[3].GetArea();
            //shape[4].GetArea();

        }
    }
}
