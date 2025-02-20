public class AnalizadorDeRiesgoImplementacion : IAnalizadorDeRiesgo
{
    private readonly ICalculadorDensidad _calculadorDensidad;

    public AnalizadorDeRiesgo(ICalculadorDensidad calculadorDensidad)
    {
        _calculadorDensidad = calculadorDensidad;
    }

    public bool EstaEnRiesgo(Zona zona)
    {
        double densidad = _calculadorDensidad.CalcularDensidad(zona.habitantes, zona.area);
        return zona.nivelDelMar < 10 && zona.distanciaRios < 50 && densidad >= 100;
    }
}
