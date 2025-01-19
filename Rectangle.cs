using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : Shape
{
    
    public Rectangle(double ancho, double alto) : base(ancho, alto)
    {
    }

    
    public override double CalculateSurface()
    {
        return Ancho * Alto; 
    }
}
