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

        public readonly int UmbralNivelDelMar;
        public readonly int UmbralDistanciaRios;
        public readonly int UmbralDensidad;

        public AnalizadorDeRiesgoImplementacion(ICalculadorDensidad calculadorDensidad, List<ITipoInundacion> tiposInundacion)
        {
            _calculadorDensidad = calculadorDensidad ?? throw new ArgumentNullException(nameof(calculadorDensidad));
            _tiposInundacion = tiposInundacion ?? throw new ArgumentNullException(nameof(tiposInundacion));

            // Definiendo los umbrales como atributos que no se modifican
            UmbralNivelDelMar = 10;
            UmbralDistanciaRios = 50;
            UmbralDensidad = 100;
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
