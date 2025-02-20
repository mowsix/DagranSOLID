using System;
using Interfaces;
using Implementaciones;
public class Zona
{

    public double nivelDelMar { get; set; }
    public int habitantes { get; set; }
    public double distanciaRios { get; set; }
    public double area { get; set; }
    public string ubicacion { get; set; }
    public string geografia { get; set; }
    public bool enRiesgo { get; private set; }


    public Zona(double nivelDelMar, int habitantes, double distanciaRios, double area, string ubicacion, string geografia)
    {
        this.nivelDelMar = nivelDelMar;
        this.habitantes = habitantes;
        this.distanciaRios = distanciaRios;
        this.area = area;
        this.ubicacion = ubicacion;
        this.geografia = geografia;
    }


    public void ActualizarRiesgo(bool enRiesgo)
    {
        this.enRiesgo = enRiesgo;
    }

 
    public override string ToString()
    {
        return $"Nivel del Mar: {nivelDelMar}, Habitantes: {habitantes}, " +
               $"Distancia a Ríos: {distanciaRios}, Área: {area}, " +
               $"Ubicación: {ubicacion}, Geografía: {geografia}, " +
               $"En Riesgo: {(enRiesgo ? "Sí" : "No")}" + "\n";
    }


}
