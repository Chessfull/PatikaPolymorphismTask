using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaPolymorphismTask
{
    public class Square : BaseGeometricShape
    {
        // ▼ Constructor of Square ▼
        public Square(double width, double length)
        {
            Width = width;
            Length = length;
        }
        // ▼ Overriding BaseClass virtual method ▼
        public override void CalculateArea()
        {
            double area = Width * Length;
            Console.WriteLine("Area of right square: " + area);
        }
    }
}
