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
            //▼ Instance of square and using override method of BaseClass ( GeometricShape )
            Square square = new Square(10,15);
            square.CalculateArea();

            //▼ Instance of square and using override method of BaseClass ( GeometricShape )
            Rectangle rectangle = new Rectangle(20,25);
            rectangle.CalculateArea();

            //▼ Instance of square and using override method of BaseClass ( GeometricShape )
            RightTriangle triangle = new RightTriangle(30,35);
            triangle.CalculateArea();
        }
    }
}
