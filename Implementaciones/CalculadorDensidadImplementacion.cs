using System;
using Interfaces;
namespace Implementaciones{

public class CalculadorDensidadImplementacion : ICalculadorDensidad
{
    public double CalcularDensidad(int habitantes, double area)
    {
        return area > 0 ? habitantes / area : 0; 
    }
}
}