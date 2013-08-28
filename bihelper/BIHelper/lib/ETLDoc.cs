using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIHelper.lib
{
    /// <summary>
    /// Representa un documento de mapeo ETL, entre campos origen y destino
    /// </summary>
    class ETLDoc
    {
        /// <summary>
        /// El nombre del mapeo
        /// </summary>
        public string Mapeo { get; set; }

        /// <summary>
        /// El consecutivo del mapeo
        /// </summary>
        public int Orden { get; set; }

        /// <summary>
        /// El nombre de la tabla destino
        /// </summary>
        public string Destino_Tabla { get; set; }

        /// <summary>
        /// El nombre del campo destino
        /// </summary>
        public string Destino_Campo { get; set; }

        /// <summary>
        /// El tipo de datos destino
        /// </summary>
        public string Destino_TipoDatos { get; set; }

        /// <summary>
        /// El tamaño de los datos destino
        /// </summary>
        public string Destino_Tamano { get; set; }

        /// <summary>
        /// El tipo de transformación
        /// </summary>
        public string Transformacion_Tipo { get; set; }

        /// <summary>
        /// El detalle de la transformación
        /// </summary>
        public string Transformacion_Detalle { get; set; }

        /// <summary>
        /// Los atributos de la transformación
        /// </summary>
        public string Transformacion_Atributos { get; set; }

        /// <summary>
        /// El nombre de la tabla fuente
        /// </summary>
        public string Fuente_Tabla { get; set; }

        /// <summary>
        /// El nombre de campo fuente
        /// </summary>
        public string Fuente_Campo { get; set; }

        /// <summary>
        /// El tipo de datos del campo fuente
        /// </summary>
        public string Fuente_TipoDatos { get; set; }

        /// <summary>
        /// El tamaño de campo fuente
        /// </summary>
        public string Fuente_Tamano { get; set; }

        /// <summary>
        /// Devuelve una cadena representando la instancia actual de la clase
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(
                " | ",
                new string[] { 
                        Mapeo,
                        Orden.ToString(),
                        Destino_Tabla,
                        Destino_Campo,
                        Destino_TipoDatos,
                        Destino_Tamano,
                        Transformacion_Tipo,
                        Transformacion_Detalle,
                        Transformacion_Atributos,
                        Fuente_Tabla,
                        Fuente_Campo,
                        Fuente_TipoDatos,
                        Fuente_Tamano
                    }
            );

        } // end ToString()

    } // end class ETLDoc

} // end namespace BIHelper.lib
