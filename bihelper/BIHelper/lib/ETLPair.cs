using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIHelper.lib
{
    /// <summary>
    /// Representa un par de transformaciones relacionadas en un mapeo,
    /// fuente y destino
    /// </summary>
    class ETLPair
    {
        /// <summary>
        /// El nombre del mapeo
        /// </summary>
        public string Mapeo { get; set; }

        /// <summary>
        /// El orden consecutivo
        /// </summary>
        public int Orden { get; set; }

        /// <summary>
        /// El tipo de destino
        /// </summary>
        public string TipoDestino { get; set; }

        /// <summary>
        /// El nombre de la transformación destino
        /// </summary>
        public string Destino { get; set; }

        /// <summary>
        /// El tipo de fuente
        /// </summary>
        public string TipoFuente { get; set; }

        /// <summary>
        /// El nombre de la transformación fuente
        /// </summary>
        public string Fuente { get; set; }

        /// <summary>
        /// Devuelve una cadena representando la instancia actual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(
                " | ",
                new string[] 
                    { 
                        Mapeo,
                        Orden.ToString(),
                        Destino,
                        TipoDestino,
                        Fuente,
                        TipoFuente
                    }
            );

        } // end ToString()

    } // end class ETLPair

} // end BIHelper.lib