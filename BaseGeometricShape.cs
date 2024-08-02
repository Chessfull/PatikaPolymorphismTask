using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaPolymorphismTask
{
    // ▼ Base Class ▼
    public class BaseGeometricShape
    {
        // ▼ Props ▼
        public double Width { get; set; }
        public double Length { get; set; }

        // ▼ Virtual Calculation method for override at derived classes ▼
        public virtual void CalculateArea()
        {
            Console.WriteLine("BaseClass area...");
        }
    }
}
