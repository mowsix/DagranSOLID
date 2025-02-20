using System;
using Interfaces;

namespace Implementaciones{

public class AnalizadorDeRiesgoImplementacion : IAnalizadorDeRiesgo
{

    private readonly ICalculadorDensidad _calculadorDensidad;
    private readonly int umbralNivelDelMar = 10;
    private readonly int umbralDistanciaRios = 50;
    private readonly int umbralDensidad = 100;

    public AnalizadorDeRiesgoImplementacion(ICalculadorDensidad calculadorDensidad)
    {
        _calculadorDensidad = calculadorDensidad;
    }

    public bool EstaEnRiesgo(Zona zona)
    {
        double densidad = _calculadorDensidad.CalcularDensidad(zona.habitantes, zona.area);
        if (zona.nivelDelMar > umbralNivelDelMar && zona.geografia=="Costera")
        {
            return true;
        } else if ( densidad >= umbralDensidad && zona.geografia=="Urbana"){
            return true;
        } else if(zona.distanciaRios < umbralDistanciaRios){
            return true;
        }
        return false;
    }
}
}
