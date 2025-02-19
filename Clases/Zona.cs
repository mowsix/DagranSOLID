using System;

public class Zona
{
    // Atributos de la clase
    public double nivelDelMar{ get; set; }
    public int habitantes{ get; set; }
    public double distanciaRios{ get; set; }
    public double area{ get; set; }
    public string ubicacion { get; set; }
    public string geografia { get; set; }
    

    // Constructor de la clase
    public Zona(double nivelDelMar, int habitantes, double distanciaRios, double area, String ubicacion, String geografia)
    {
        this.nivelDelMar = nivelDelMar;
        this.habitantes = habitantes;
        this.distanciaRios = distanciaRios;
        this.area=area;
        this.ubicacion=ubicacion;
        this.geografia=geografia;
    }

}