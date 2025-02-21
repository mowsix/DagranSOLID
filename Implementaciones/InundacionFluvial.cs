using Interfaces;
namespace Implementaciones{
public class InundacionFluvial : ITipoInundacion
{
    private readonly int umbralDistanciaRios;

    public InundacionFluvial(int umbralDistanciaRios)
    {
        this.umbralDistanciaRios = umbralDistanciaRios;
    }

    public bool Aplica(Zona zona)
    {
        return zona.distanciaRios < umbralDistanciaRios;
    }

    public string ObtenerTipo()
    {
        return "Fluvial";
    }
}
}
