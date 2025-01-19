using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }
    public abstract double CalculateSurface();
}
