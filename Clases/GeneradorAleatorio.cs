using System;

public abstract class GeneradorAleatorio
{
    private static readonly Random random = new Random();

    public static double GenerarNumeroDecimal(double min, double max) =>
        Math.Round(min + (random.NextDouble() * (max - min)), 2);

    public static int GenerarNumeroEntero(int min, int max) =>
        random.Next(min, max);

    public static string SeleccionarElementoAleatorio(string[] opciones) =>
        opciones[random.Next(opciones.Length)];
}
