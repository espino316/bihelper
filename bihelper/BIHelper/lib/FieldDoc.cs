using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIHelper.lib
{
    /// <summary>
    /// Representa la información de documentación de un campo
    /// </summary>
    public class FieldDoc
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="FieldDoc"/>
        /// </summary>
        public FieldDoc()
        {

        }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="FieldDoc"/>
        /// </summary>
        /// <param name="tipoMapeo">Tipo de Mapeo en el que se encuentra el campo</param>
        /// <param name="nombre">Nombre del mapeo en el que se encuentra el campo</param>
        /// <param name="transformacion">Nombre de la transformación en la que está presente el campo</param>
        /// <param name="tipoTransformacion">Tipo de transformación en la que está presente el campo</param>
        /// <param name="campo">El nombre del campo</param>
        /// <param name="tipoDato">El tipo de dato del campo</param>
        /// <param name="longitud">La longitud del campo</param>
        public FieldDoc(
            string tipoMapeo,
            string nombre,
            string transformacion,
            string tipoTransformacion,
            string campo,
            string tipoDato,
            string longitud
            )
        {
            this.TipoMapeo = tipoMapeo;
            this.Nombre = nombre;
            this.Transformacion = transformacion;
            this.TipoTransformacion = tipoTransformacion;
            this.Campo = campo;
            this.TipoDato = tipoDato;
            this.Longitud = longitud;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Indica el tipo de mapeo, si es Mapping o Mapplet
        /// </summary>
        public string TipoMapeo { get; set; }

        /// <summary>
        /// El nombre del mapeo
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// El nombre de la transformación donde se encuentra el campo
        /// </summary>
        public string Transformacion { get; set; }

        /// <summary>
        /// El tipo de transformación del campo
        /// </summary>
        public string TipoTransformacion { get; set; }

        /// <summary>
        /// El nombre del campo
        /// </summary>
        public string Campo { get; set; }

        /// <summary>
        /// El tipo de dato del campo
        /// </summary>
        public string TipoDato { get; set; }

        /// <summary>
        /// La longitud del campo
        /// </summary>
        public string Longitud { get; set; }

        #endregion



    } // end class FieldDoc

} // end namespace BIHelper.lib
