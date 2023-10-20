using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Parallellogram : Geometri
    {

        // två egenskaper för att räkna ut arean
        public double BaseLenght {  get; set; }

        public double Height { get; set; }

        // ger egenskaperna värde
        public Parallellogram()
        {
            BaseLenght = 10;
            Height = 20;
        }

        // Räknar ut arean
        public override double Area()
        {
            return BaseLenght * Height;
        }
    }
}
