using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{

    //Creation of the another child of the Shape Class
    public abstract class ThreeDimensionalShape : Shape
    {
        //two methods are created for this child class, namely volume and area
        public ThreeDimensionalShape(int height, int width, int radius) : base(height, width, radius)
        { }

        public override string ToString()
        {
            return string.Format("{0} {1} Sides: {2}",
                Height, Width, Sides);
        }

        public abstract decimal area();
        public abstract decimal volume();
    }

}
