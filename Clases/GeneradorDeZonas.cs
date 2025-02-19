using System;
using System.Collections.Generic;

public class GeneradorDeZonas
{
    private static readonly double minNivelDelMar = -50.0, maxNivelDelMar = 4000.0;
    private static readonly int minHabitantes = 100, maxHabitantes = 1000000;
    private static readonly double minDistanciaRios = 0.1, maxDistanciaRios = 100.0;
    private static readonly double minArea = 1.0, maxArea = 5000.0;

    private static readonly string[] ubicaciones = { "Rural", "Urbana",};
    private static readonly string[] geografias = { "Montañosa","Costera" };

    public static List<Zona> GenerarZonas(int cantidad)
    {
        List<Zona> zonas = new List<Zona>();

        for (int i = 0; i < cantidad; i++)
        {
            zonas.Add(new Zona(
                GeneradorAleatorio.GenerarNumeroDecimal(minNivelDelMar, maxNivelDelMar),
                GeneradorAleatorio.GenerarNumeroEntero(minHabitantes, maxHabitantes),
                GeneradorAleatorio.GenerarNumeroDecimal(minDistanciaRios, maxDistanciaRios),
                GeneradorAleatorio.GenerarNumeroDecimal(minArea, maxArea),
                GeneradorAleatorio.SeleccionarElementoAleatorio(ubicaciones),
                GeneradorAleatorio.SeleccionarElementoAleatorio(geografias)
            ));
        }

        return zonas;
    }
}
