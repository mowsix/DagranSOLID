using Interfaces;

namespace Implementaciones{
public class InundacionCostera : ITipoInundacion
{
    private readonly int umbralNivelDelMar;

    public InundacionCostera(int umbralNivelDelMar)
    {
        this.umbralNivelDelMar = umbralNivelDelMar;
    }

    public bool Aplica(Zona zona)
    {
        return zona.geografia == "Costera" && zona.nivelDelMar < umbralNivelDelMar;
    }

    public string ObtenerTipo()
    {
        return "Costera";
    }
}
}
