using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_3037_OLA4_PolyMorphism
{

    public abstract class Shape : IComparable
    {
        // Base Class called Shape
        // All of it's methods will be inherited by its children and grandchildren
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Sides { get; private set; }
        public Shape(int height, int width, int sides)
        {

            Height = height;
            Width = width;
            Sides = sides;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Sides: {2}",
                Height, Width, Sides);
        }

        public int CompareTo(object obj)
        {
            //car c=(car)obj;
            //return String.Compare(this.make, c.make);
            return 1;
        }
    }

}
