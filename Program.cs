using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaPolymorphismTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(10,15);
            square.CalculateArea();

            Rectangle rectangle = new Rectangle(20,25);
            rectangle.CalculateArea();

            RightTriangle triangle = new RightTriangle(30,35);
            triangle.CalculateArea();
        }
    }
}
