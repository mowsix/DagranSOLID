using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;

namespace Implementaciones
{
    public class AnalizadorDeRiesgoImplementacion : IAnalizadorDeRiesgo
    {
        private readonly List<ITipoInundacion> _tiposInundacion;
        private readonly ICalculadorDensidad _calculadorDensidad;

        // Umbrales con los mismos nombres y tipos de datos que en la interfaz
        public int UmbralNivelDelMar { get; }
        public int UmbralDistanciaRios { get; }
        public int UmbralDensidad { get; }

        public AnalizadorDeRiesgoImplementacion(ICalculadorDensidad calculadorDensidad)
        {
            _calculadorDensidad = calculadorDensidad;

            // Inicializar umbrales con los tipos de datos correctos
            UmbralNivelDelMar = 10;
            UmbralDistanciaRios = 50;
            UmbralDensidad = 100;

            _tiposInundacion = new List<ITipoInundacion>
            {
                new InundacionCostera(UmbralNivelDelMar),
                new InundacionUrbana(UmbralDensidad, _calculadorDensidad),
                new InundacionFluvial(UmbralDistanciaRios)
            };
        }

        public bool EstaEnRiesgo(Zona zona)
        {
            return _tiposInundacion.Any(tipo => tipo.Aplica(zona));
        }

        public string DeterminarTipoInundacion(Zona zona)
        {
            var tipo = _tiposInundacion.FirstOrDefault(t => t.Aplica(zona));
            return tipo != null ? tipo.ObtenerTipo() : "Ninguno";
        }
    }
}
