using System.Collections.Generic;
using Interfaces;
namespace Implementaciones
{
    public static class ReglasDeNegocio
    {
        private static readonly int UmbralNivelDelMar = 10;
        private static readonly int UmbralDistanciaRios = 50;
        private static readonly int UmbralDensidad = 100;

        public static IAnalizadorDeRiesgo CrearAnalizadorDeRiesgo(ICalculadorDensidad calculadorDensidad)
        {
            List<ITipoInundacion> tiposInundacion = new List<ITipoInundacion>
            {
                new InundacionCostera(UmbralNivelDelMar),
                new InundacionFluvial(UmbralDistanciaRios),
                new InundacionUrbana(UmbralDensidad, calculadorDensidad)
            };

            return new AnalizadorDeRiesgoImplementacion(calculadorDensidad, tiposInundacion);
        }
    }
}
