using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaPolymorphismTask
{
    public class Rectangle:BaseGeometricShape
    {
        // ▼ Constructor of Reactangle ▼
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        // ▼ Overriding BaseClass virtual method ▼
        public override void CalculateArea()
        {
            double area = Width * Length;
            Console.WriteLine("Area of right reactangle: " + area);
        }
    }
}
