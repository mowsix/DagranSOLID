using Interfaces;
namespace Implementaciones{
public class InundacionUrbana : ITipoInundacion
{
    private readonly int umbralDensidad;
    private readonly ICalculadorDensidad _calculadorDensidad;

    public InundacionUrbana(int umbralDensidad, ICalculadorDensidad calculadorDensidad)
    {
        this.umbralDensidad = umbralDensidad;
        this._calculadorDensidad = calculadorDensidad;
    }

    public bool Aplica(Zona zona)
    {
        double densidad = _calculadorDensidad.CalcularDensidad(zona.habitantes, zona.area);
        return zona.geografia == "Urbana" && densidad >= umbralDensidad;
    }

    public string ObtenerTipo()
    {
        return "Urbana";
    }
}
}