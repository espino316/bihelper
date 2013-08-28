using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BIHelper.lib
{
    /// <summary>
    /// Esta clase representa una conexión a Artus. Es un clase serializable.
    /// </summary>
    [Serializable()]
    public class ConexionMetaDataArtus : ISerializable
    {
        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="ConexionMetaDataArtus"/>
        /// </summary>
        public ConexionMetaDataArtus()
        {
            // TODO
        }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="ConexionMetaDataArtus"/>
        /// </summary>
        /// <param name="nombre">El nombre de la conexión</param>
        /// <param name="servidor">Servidor donde se encuentra la base de datos de metadata de Artus</param>
        /// <param name="basedatos">Base de datos de metadata de Artus</param>
        /// <param name="usuario">Usuario con acceso a la base de datos de metadata de Artus</param>
        /// <param name="password">El password del usuario con acceso a la base de datos de metadata de Artus</param>
        public ConexionMetaDataArtus(string nombre, string servidor, string basedatos, string usuario, string password)
        {
            this.Nombre = nombre;
            this.Servidor = servidor;
            this.BaseDatos = basedatos;
            this.Usuario = usuario;
            this.Password = password;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="ConexionMetaDataArtus"/>
        /// </summary>
        /// <param name="info"Información de la serialización></param>
        /// <param name="ctxt">Contexto de trasmisión de datos</param>
        public ConexionMetaDataArtus(SerializationInfo info, StreamingContext ctxt)
        {
            this.Nombre = (string)info.GetValue("Nombre", typeof(System.String));
            this.Servidor = (string)info.GetValue("Servidor", typeof(System.String));
            this.BaseDatos = (string)info.GetValue("BaseDatos", typeof(System.String));
            this.Usuario = (string)info.GetValue("Usuario", typeof(System.String));
            this.Password = (string)info.GetValue("Password", typeof(System.String));
        }

        /// <summary>
        /// El nombre de la conexión
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Servidor donde se encuentra la base de datos de metadata de Artus</param>
        /// <param name="basedatos">Base de datos de metadata de Artus</param>
        /// </summary>
        public string Servidor { get; set; }

        /// <summary>
        /// Base de datos de metadata de Artus
        /// </summary>
        public string BaseDatos { get; set; }

        /// <summary>
        /// Usuario con acceso a la base de datos de metadata de Artus
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// El password del usuario con acceso a la base de datos de metadata de Artus
        /// </summary>
        public string Password { get; set; }


        #region Methods

        /// <summary>
        /// Obtiene la información de los objetos
        /// </summary>
        /// <param name="info"Información de la serialización></param>
        /// <param name="ctxt">Contexto de trasmisión de datos</param>
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Nombre", this.Nombre);
            info.AddValue("Servidor", this.Servidor);
            info.AddValue("BaseDatos", this.BaseDatos);
            info.AddValue("Usuario", this.Usuario);
            info.AddValue("Password", this.Password);
        }

        /// <summary>
        /// Compara la instancia actual con un objeto
        /// </summary>
        /// <param name="obj">El objeto con el que se compara la instancia actual</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!Convert.IsDBNull(obj) && obj != null)
            {
                ConexionMetaDataArtus instance =
                    (ConexionMetaDataArtus)obj;
                
                return (
                    (this.Nombre == instance.Nombre) &&
                    (this.Servidor == instance.Servidor) &&
                    (this.BaseDatos ==instance.BaseDatos) &&
                    (this.Usuario == instance.Usuario) &&
                    (this.Password == instance.Password)
                );
            }
            else
            {
                return base.Equals(obj);
            }
        } // end Equals

        /// <summary>
        /// Devuelve un hash de la instancia actual
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    } // end class ConexionArtus

} // end namespace BIHelper.lib