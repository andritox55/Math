using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Fyrkant : Geometri
    {
        // Egenskaperna
        public double Length { get; set; }

        // Ge värde till egenskaperna
        public Fyrkant()
        {
            Length = 6;
        }

        // räknar ut arean på en fyrkant
        public override double Area()
        {
            return Length * Length;
        }
    }
}
