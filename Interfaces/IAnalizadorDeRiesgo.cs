namespace Interfaces{
public interface IAnalizadorDeRiesgo
{
    bool EstaEnRiesgo(Zona zona);
    string DeterminarTipoInundacion(Zona zona);
}
}