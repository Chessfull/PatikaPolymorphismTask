using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaPolymorphismTask
{
    public class RightTriangle : BaseGeometricShape
    {
        // ▼ Constructor of RigthTriangle ▼
        public RightTriangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        // ▼ Overriding BaseClass virtual method ▼
        public override void CalculateArea()
        {
            double area = (Width * Length) / 2;
            Console.WriteLine("Area of right triangle: "+area);
        }
    }
}
