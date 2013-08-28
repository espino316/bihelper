using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BIHelper.lib
{
    /// <summary>
    /// Contiene las conexiones utilizadas en el sistema. Es una clase serializable.    
    /// </summary>
    [Serializable()]
    public class Conexiones : ISerializable
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="Conexiones"/>
        /// </summary>
        public Conexiones()
        {
            //  Establecemos un buena instancia del listado
            this.ConexionesMetaDataArtus = new List<ConexionMetaDataArtus>();
        }

        /// <summary>
        /// Crea un nueva instancia de la clase <see cref="Conexiones"/>
        /// </summary>
        /// <param name="info">Información de la serialización</param>
        /// <param name="ctxt">Contexto de streamng</param>
        public Conexiones(SerializationInfo info, StreamingContext ctxt)
        {
            //  Obtenemos las conexiones de los datos serializados
            this.ConexionesMetaDataArtus = 
                (List<lib.ConexionMetaDataArtus>)info.GetValue(
                    "ConexionesMetaDataArtus", 
                    typeof(List<lib.ConexionMetaDataArtus>)
                );

            //  Si no hay conexiones, establecemos una nueva instancia del listado
            if (this.ConexionesMetaDataArtus == null)
                this.ConexionesMetaDataArtus = new List<ConexionMetaDataArtus>();
        }

        #endregion


        #region Properties

        /// <summary>
        /// Listado de conexiones a servidores de metadata de Artus
        /// </summary>
        public List<ConexionMetaDataArtus> ConexionesMetaDataArtus
        {
            get
            {
                return conexionesMetaDataArtus;
            }
            set
            {
                conexionesMetaDataArtus = value;
            }

        } // end ConexionesMetaDataArtus

        private List<ConexionMetaDataArtus> conexionesMetaDataArtus;

        #endregion


        #region Methods

        /// <summary>
        /// Obtiene el dato del objeto
        /// </summary>
        /// <param name="info">Información de la serialización</param>
        /// <param name="ctxt">Contexto de streamng</param>
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("ConexionesMetaDataArtus", this.ConexionesMetaDataArtus);
        }

        #endregion

    } // end class Conexiones

} // end namespace BIHelper.lib
