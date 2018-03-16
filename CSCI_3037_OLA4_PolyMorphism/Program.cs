// Joel R. Norris
// CSCI_3037
// OLA4 ~ PolyMorphism
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSCI_3037_OLA4_PolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creations of an shapes classes
            Shape[] shapes = new Shape[5];
            shapes[0] = new Circle(22, 88, 4);
            shapes[1] = new Square(71, 96, 10);
            shapes[2] = new Sphere(22, 87, 2);
            shapes[3] = new Cube(79, 61, 8);
            shapes[5] = new Cylinder(38, 61, 8, 12);


            Console.Write("Shapes processed polymorphically:\n\n\n");
            foreach (Shape currentShape in shapes)
            {
                //calls each to display its contents
                Console.WriteLine(currentShape);

            }//end of foreach loop
            Console.ReadKey();
        }
    }

}
