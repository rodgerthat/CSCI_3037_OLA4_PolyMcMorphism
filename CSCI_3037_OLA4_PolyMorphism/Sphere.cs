using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{

    public class Sphere : ThreeDimensionalShape
    {
        public decimal sphereRadius;
        public string Name;
        public decimal Radius
        {
            get
            {
                return sphereRadius;
            }
            set
            {
                if (value > 0)
                    sphereRadius = value;
            }
        }

        public Sphere(int height, int width, int side) : base(height, width, side)
        {
            Name = "Sphere";
            sphereRadius = side;

        }

        public override decimal area()
        {
            double radius = Convert.ToDouble(sphereRadius);
            double square = 2;
            return Convert.ToDecimal(4 * (Math.PI) * (Math.Pow(radius, square)));
        }
        public override decimal volume()
        {
            double radius = Convert.ToDouble(sphereRadius);
            double cubed = 3;
            return Convert.ToDecimal((4 / 3) * Math.PI * Math.Pow(radius, cubed));
        }

        public override string ToString()
        {
            return string.Format("{0}: [{1} {2}] Radius: {3}\n{0}'s Area is {4}\n{0}'s Volume is {5}\n",
                 Name, Height, Width, Sides, area(), volume());
        }
    }
}
