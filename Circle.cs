using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle : Shape
{
    public Circle(double radio) : base(radio, radio) 
    {
    }

    public override double CalculateSurface()
    {
        return Math.PI * Ancho * Ancho; 
    }
}
