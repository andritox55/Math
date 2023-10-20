using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Rektangel : Geometri
    {

        // Egenskaperna för att räkna ut rektangeln
        public double Length {  get; set; }

        public double Width { get; set; }


        //Ge egenskaperna värde
        public Rektangel() 
        {
            Length = 3;
            Width = 4;
        }

        //Returnerar arean på rektangeln
        public override double Area()
        {
            return Length * Width;
        }
    }
}
