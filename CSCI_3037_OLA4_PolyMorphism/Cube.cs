using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{

    public class Cube : ThreeDimensionalShape
    {
        public decimal cubeSide;
        public string Name;
        public decimal Radius
        {
            get
            {
                return cubeSide;
            }
            set
            {
                if (value > 0)
                    cubeSide = value;
            }
        }

        public Cube(int height, int width, int side) : base(height, width, side)
        {
            Name = "Cube";
            cubeSide = side;

        }

        public override decimal area()
        {
            double sides = Convert.ToDouble(cubeSide);
            double squared = 2;
            return Convert.ToDecimal(6 * Math.Pow(sides, squared));
        }
        public override decimal volume()
        {
            double sides = Convert.ToDouble(cubeSide);
            double cubed = 3;
            return Convert.ToDecimal(Math.Pow(sides, cubed));
        }

        public override string ToString()
        {
            return string.Format("{0}: [{1} {2}] Sides: {3}\n{0}'s Area is {4}\n{0}'s Volume is {5}\n",
                 Name, Height, Width, Sides, area(), volume());
        }

    }

}
