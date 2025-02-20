using System;
using Interfaces;


namespace Implementaciones{


public class GeneradorAleatorioImplementacion : IGeneradorAleatorio
{
    private readonly Random _random = new Random();

    public double GenerarNumeroDecimal(double min, double max)
    {
        return min + (_random.NextDouble() * (max - min));
    }

    public int GenerarNumeroEntero(int min, int max)
    {
        return _random.Next(min, max + 1);
    }

    public string SeleccionarElementoAleatorio(string[] opciones)
    {
        return opciones[_random.Next(opciones.Length)];
    }
}
}