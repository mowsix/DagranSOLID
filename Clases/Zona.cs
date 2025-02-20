using System;

public class Zona
{
    public double NivelDelMar { get; set; }
    public int Habitantes { get; set; }
    public double DistanciaRios { get; set; }
    public double Area { get; set; }
    public string Ubicacion { get; set; }
    public string Geografia { get; set; }
    public bool EnRiesgo { get; private set; } 

    public Zona(double nivelDelMar, int habitantes, double distanciaRios, double area, string ubicacion, string geografia)
    {
        NivelDelMar = nivelDelMar;
        Habitantes = habitantes;
        DistanciaRios = distanciaRios;
        Area = area;
        Ubicacion = ubicacion;
        Geografia = geografia;
    }

    public void ActualizarRiesgo(bool riesgo)
    {
        EnRiesgo = riesgo;
    }
}
