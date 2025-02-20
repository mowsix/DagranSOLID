using System;
using Interfaces;
using Implementaciones;
public class GeneradorDeZonas
{
    private readonly IGeneradorAleatorio _generadorAleatorio;
    private readonly IAnalizadorDeRiesgo _analizadorDeRiesgo;

    // Rango de valores
    private static readonly double minNivelDelMar = 1.0, maxNivelDelMar = 3000.0;
    private static readonly int minHabitantes = 1000, maxHabitantes = 1000000;
    private static readonly double minDistanciaRios = 1.0, maxDistanciaRios = 2000.0;
    private static readonly double minArea = 1.0, maxArea = 500.0;
    private static readonly string[] ubicaciones = { "Rural", "Urbana" };
    private static readonly string[] geografias = { "Montañosa", "Costera" };

    public GeneradorDeZonas(IGeneradorAleatorio generadorAleatorio, IAnalizadorDeRiesgo analizadorDeRiesgo)
    {
        _generadorAleatorio = generadorAleatorio;
        _analizadorDeRiesgo = analizadorDeRiesgo;
    }

    public List<Zona> GenerarZonas(int cantidad)
    {
        List<Zona> zonas = new List<Zona>();

        for (int i = 0; i < cantidad; i++)
        {
            Zona zona = new Zona(
                _generadorAleatorio.GenerarNumeroDecimal(minNivelDelMar, maxNivelDelMar),
                _generadorAleatorio.GenerarNumeroEntero(minHabitantes, maxHabitantes),
                _generadorAleatorio.GenerarNumeroDecimal(minDistanciaRios, maxDistanciaRios),
                _generadorAleatorio.GenerarNumeroDecimal(minArea, maxArea),
                _generadorAleatorio.SeleccionarElementoAleatorio(ubicaciones),
                _generadorAleatorio.SeleccionarElementoAleatorio(geografias)
            );

            zona.ActualizarRiesgo(_analizadorDeRiesgo.EstaEnRiesgo(zona));
            zonas.Add(zona);
        }

        return zonas;
    }
}
