using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{
        
    //Creation of the child of the Shape Class
    public abstract class TwoDimensionalShape : Shape
    {
        //The new method area is created for this child class
        public TwoDimensionalShape(int height, int width, int radius) : base(height, width, radius)
        { }

        public override string ToString()
        {
            return string.Format("{0} {1} Sides: {2}",
                Height, Width, Sides);
        }

        public abstract decimal area();

    }
    
}
