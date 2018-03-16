using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{
    class Cylinder : ThreeDimensionalShape
    {

        public decimal cylinderRadius;
        public decimal cylinderHeight;
        public string Name;
        public decimal Radius
        {
            get
            {
                return cylinderRadius;
            }
            set
            {
                if (value > 0)
                    cylinderRadius = value;
            }
        }
        public override decimal area()
        {
            // formula to calculate surface area of a cylinder
            // A = 2πrh + 2πr^2 
            double radius = Convert.ToDouble(cylinderRadius);
            double square = 2;
            return Convert.ToDecimal((Math.PI * Math.Pow(radius, square)));
        }

        public Cylinder(int height, int width, int radius) : base(height, width, radius)
        {
            Name = "Cylinder";
            cylinderRadius = radius;

        }

        public override string ToString()
        {
            return string.Format("{0}: [{1} {2}] Radius : {3}\n{0}'s Area is {4}\n",
                Name, Height, Width, Sides, area());
        }

        public override decimal volume()
        {

            // formula to calculate volume of a cylinder
            // V = π r^2 h
            throw new NotImplementedException();
        }
    }
}
