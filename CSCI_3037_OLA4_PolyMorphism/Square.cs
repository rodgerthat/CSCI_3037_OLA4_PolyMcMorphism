using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{

    public class Square : TwoDimensionalShape
    {
        public decimal squareSide;
        public string Name;
        public decimal Sides
        {
            get
            {
                return squareSide;
            }
            set
            {
                if (value > 0)
                    squareSide = value;
            }
        }
        public override decimal area()
        {
            double radius = Convert.ToDouble(squareSide);
            double square = 2;
            return Convert.ToDecimal(Math.Pow(radius, square));
        }


        public Square(int height, int width, int side) : base(height, width, side)
        {
            Name = "Square";
            squareSide = side;

        }

        public override string ToString()
        {
            return string.Format("{0}: [{1} {2}] Sides: {3}\n{0}'s Area is {4}\n",
                 Name, Height, Width, Sides, area());
        }
    }

}
