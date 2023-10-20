using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Ellips : Geometri
    {

        //Egenskaperna
        public double FirstAxis { get; set; }

        public double SecondAxis { get; set; }

        // ger värde till egenskaperna
        public Ellips()
        {
            FirstAxis = 2;
            SecondAxis = 4;
        }

        //räknar ut arean på en Ellips och rundar decimal till 2
        public override double Area()
        {
            double EllipsArea = Math.Round((Math.PI * FirstAxis * SecondAxis), 2);

            return EllipsArea;
        }
    }
}
