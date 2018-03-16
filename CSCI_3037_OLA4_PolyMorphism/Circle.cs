using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{

    public class Circle : TwoDimensionalShape
    {
        public decimal circleRadius;
        public string Name;
        public decimal Radius
        {
            get
            {
                return circleRadius;
            }
            set
            {
                if (value > 0)
                    circleRadius = value;
            }
        }
        public override decimal area()
        {
            double radius = Convert.ToDouble(circleRadius);
            double square = 2;
            return Convert.ToDecimal((Math.PI * Math.Pow(radius, square)));
        }

        public Circle(int height, int width, int radius) : base(height, width, radius)
        {
            Name = "Circle";
            circleRadius = radius;

        }

        public override string ToString()
        {
            return string.Format("{0}: [{1} {2}] Radius : {3}\n{0}'s Area is {4}\n",
                Name, Height, Width, Sides, area());
        }

    }

}
