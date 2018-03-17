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
        public Cylinder(int height, int width, int radius, int cylHeight) : base(height, width, radius)
        {
            Name = "Cylinder";
            this.cylinderRadius = radius;
            this.cylinderHeight = cylHeight;

        }

        public override decimal area()
        {
            // formula to calculate surface area of a cylinder
            // A = 2πrh + 2πr^2 
            double radius = Convert.ToDouble(cylinderRadius);
            double height = Convert.ToDouble(cylinderHeight);
            double square = 2;
            return Convert.ToDecimal((2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, square)));
        }

        public override decimal volume()
        {

            // formula to calculate volume of a cylinder
            // V = π r^2 h
            double radius = Convert.ToDouble(cylinderRadius);
            double height = Convert.ToDouble(cylinderHeight);
            double square = 2;
            return Convert.ToDecimal(Math.PI * Math.Pow(radius, square) * height);

        }

        public override string ToString()
        {
            return string.Format("{0}: [{1} {2}] Radius : {3}\tHeight : {4}\n{0}'s Area is {5}\n{0}'s Volume is {6}",
                Name, Height, Width, Sides, cylinderHeight, area(), volume());
        }
    }
}
