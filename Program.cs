using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 10),    
            new Triangle(6, 4),      
            new Circle(3)            
        };

        double[] areas = new double[shapes.Length];

        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
            Console.WriteLine($"El área de la {shapes[i].GetType().Name} es: {areas[i]}");
        }
    }
}
