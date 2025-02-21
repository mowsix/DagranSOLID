public class Zona
{
    public double nivelDelMar { get; }
    public int habitantes { get; }
    public double distanciaRios { get; }
    public double area { get; }
    public string geografia { get; }
    public string ubicacion { get; }
    public bool enRiesgo { get; private set; }
    public string tipoInundacion { get; private set; }

    public Zona(double nivelDelMar, int habitantes, double distanciaRios, double area, string ubicacion, string geografia)
    {
        this.nivelDelMar = nivelDelMar;
        this.habitantes = habitantes;
        this.distanciaRios = distanciaRios;
        this.area = area;
        this.ubicacion = ubicacion;
        this.geografia = geografia;
        this.enRiesgo = false;
        this.tipoInundacion = "Ninguna";
    }

    public void ActualizarRiesgo(bool riesgo, string tipoInundacion)
    {
        this.enRiesgo = riesgo;
        this.tipoInundacion = tipoInundacion;
    }

    public override string ToString()
    {
        return $"Zona {ubicacion} ({geografia}) - Nivel del Mar: {nivelDelMar}m, Habitantes: {habitantes}, " +
               $"Distancia a Ríos: {distanciaRios}m, Área: {area}km², " +
               $"Riesgo: {(enRiesgo ? "Sí" : "No")} - Tipo de Inundación: {tipoInundacion}" + "\n";
    }
}
