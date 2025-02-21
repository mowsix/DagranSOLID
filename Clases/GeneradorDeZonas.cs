using System;
using Interfaces;
using Implementaciones;
using System;
using System.Collections.Generic;

public class GeneradorDeZonas
{
    private readonly IGeneradorAleatorio _generadorAleatorio;
    private readonly IAnalizadorDeRiesgo _analizadorDeRiesgo;
    public double MinNivelDelMar { get; }
    public double MaxNivelDelMar { get; }
    public int MinHabitantes { get; }
    public int MaxHabitantes { get; }
    public double MinDistanciaRios { get; }
    public double MaxDistanciaRios { get; }
    public double MinArea { get; }
    public double MaxArea { get; }
    public string[] Ubicaciones { get; }
    public string[] Geografias { get; }

    public GeneradorDeZonas(IGeneradorAleatorio generadorAleatorio, IAnalizadorDeRiesgo analizadorDeRiesgo)
    {
        _generadorAleatorio = generadorAleatorio;
        _analizadorDeRiesgo = analizadorDeRiesgo;
        
        MinNivelDelMar = 1.0;
        MaxNivelDelMar = 3000.0;
        MinHabitantes = 1000;
        MaxHabitantes = 1000000;
        MinDistanciaRios = 1.0;
        MaxDistanciaRios = 200.0;
        MinArea = 1.0;
        MaxArea = 500.0;
        Ubicaciones = new string[] { "Rural", "Urbana" };
        Geografias = new string[] { "Montañosa", "Costera" };
    }

    public List<Zona> GenerarZonas(int cantidad)
    {
        List<Zona> zonas = new List<Zona>();

        for (int i = 0; i < cantidad; i++)
        {
            Zona zona = new Zona(
                _generadorAleatorio.GenerarNumeroDecimal(MinNivelDelMar, MaxNivelDelMar),
                _generadorAleatorio.GenerarNumeroEntero(MinHabitantes, MaxHabitantes),
                _generadorAleatorio.GenerarNumeroDecimal(MinDistanciaRios, MaxDistanciaRios),
                _generadorAleatorio.GenerarNumeroDecimal(MinArea, MaxArea),
                _generadorAleatorio.SeleccionarElementoAleatorio(Ubicaciones),
                _generadorAleatorio.SeleccionarElementoAleatorio(Geografias)
            );

            bool riesgo = _analizadorDeRiesgo.EstaEnRiesgo(zona);
            string tipoInundacion = _analizadorDeRiesgo.DeterminarTipoInundacion(zona);

            zona.ActualizarRiesgo(riesgo, tipoInundacion);
            zonas.Add(zona);
        }

        return zonas;
    }
}