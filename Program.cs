using System;
using System.Collections.Generic;
using Interfaces;
using Implementaciones;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de zonas a generar: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidadZonas) || cantidadZonas <= 0)
        {
            Console.WriteLine("Error: Ingrese un número entero positivo.");
            return;
        }

        // Usa los nombres correctos de las clases
        IGeneradorAleatorio generadorAleatorio = new GeneradorAleatorioImplementacion();
        ICalculadorDensidad calculadorDensidad = new CalculadorDensidadImplementacion();
        IAnalizadorDeRiesgo analizadorDeRiesgo = new AnalizadorDeRiesgoImplementacion(calculadorDensidad);
        GeneradorDeZonas generadorDeZonas = new GeneradorDeZonas(generadorAleatorio, analizadorDeRiesgo);

        // Generamos zonas
        List<Zona> zonas = generadorDeZonas.GenerarZonas(cantidadZonas);

        // Imprimimos las zonas
        Console.WriteLine("\nZonas generadas:");
        foreach (var zona in zonas)
        {
            Console.WriteLine(zona);
        }
    }
}
