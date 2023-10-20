using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Cirkel : Geometri
    {

        // Egenskap
        public double Radius { get; set; }

        // Ge värde till egenskapen
        public Cirkel()
        {
            Radius = 4;
        }

        // Räkna ut arean på en cirkel och rundar decimal till 1
        public override double Area()
        {
            double CirkleArea = Math.PI * Radius * Radius;
            double rounded = Math.Round(CirkleArea, 1);
            return rounded;
        }

    }
}
