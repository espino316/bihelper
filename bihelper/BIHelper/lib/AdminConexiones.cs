using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BIHelper.lib
{
    /// <summary>
    /// Administra las conexiones a servidores
    /// </summary>
    public class AdminConexiones
    {
        #region Constructors

        /// <summary>
        /// Constructor de Config_ViewModel
        /// </summary>
        public AdminConexiones()
        {
            des = new TripleDESCryptoServiceProvider();
            ASCIIEncoding textConverter = new ASCIIEncoding();
            key = textConverter.GetBytes("U1sv2I6qs5f5up7y1q9vkVsZ");
            IV = textConverter.GetBytes("5db7C7b32A609rwEo92854l3");
        }

        #endregion

        #region Properties

        /// <summary>
        /// El objeto de modelo de conexiones
        /// </summary>
        private Conexiones conexiones;
        public Conexiones Conexiones
        {
            get
            {
                return conexiones;
            }
            set
            {
                conexiones = value;
            }
        }

        /// <summary>
        /// La ruta al archivo de configuración
        /// </summary>
        private string ConexionesFile
        {
            get
            {
                return
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\\bihelper\\biconex.dat";
            }
        }

        /// <summary>
        /// La ruta a la carpeta de configuración
        /// </summary>
        private string ConexionesFolder
        {
            get
            {
                return
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\\bihelper";
            }
        }

        /// <summary>
        /// Proveedor de encriptación
        /// </summary>
        private TripleDESCryptoServiceProvider des;

        /// <summary>
        /// Llave para ecriptar
        /// </summary>
        private byte[] key;

        /// <summary>
        /// Factor de encriptación
        /// </summary>
        private byte[] IV;

        #endregion

        #region Methods

        /// <summary>
        /// Determina si el archivo de conexiones existe
        /// </summary>
        /// <returns></returns>
        public bool FileExists()
        {
            if (Directory.Exists(this.ConexionesFolder))
            {
                return File.Exists(ConexionesFile);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Guarda las conexiones en el archivo de conexiones, encriptados
        /// </summary>
        public void Guardar()
        {
            //  Creamos el directorio si no existe
            if (!Directory.Exists(ConexionesFolder))
            {
                Directory.CreateDirectory(ConexionesFolder);
            }

            //  Serializamos y encriptamos
            using (FileStream fs = File.Open(ConexionesFile, FileMode.Create))
            {
                using (CryptoStream cs = new CryptoStream(fs, des.CreateEncryptor(key, IV), CryptoStreamMode.Write))
                {
                    BinaryFormatter bformatter = new BinaryFormatter();
                    bformatter.Serialize(cs, this.Conexiones);
                }
            }
        }

        /// <summary>
        /// Lee el archivo de conexiones y crea una instancia de la clase
        /// <see cref="Conexiones"/> a partir de los datos
        /// </summary>
        public void CargarConexiones()
        {
            //  Si el archivo existe
            if (FileExists())
            {
                //  Lo leemos
                using (FileStream fs = File.Open(ConexionesFile, FileMode.Open))
                {
                    //  Lo desencriptamos
                    using (CryptoStream cs = new CryptoStream(fs, des.CreateDecryptor(key, IV), CryptoStreamMode.Read))
                    {
                        //  Lo des-serializamos
                        BinaryFormatter bformatter = new BinaryFormatter();

                        //  Obtenemos el objeto "Conexiones"
                        this.Conexiones = (Conexiones)bformatter.Deserialize(cs);

                    } // end using

                } // end using

            } // end if
            else
            {
                //  Establecemos un nueva instancia de Conexiones
                //  en blanco
                this.Conexiones = new Conexiones();

            } // end else
             
        } // end CargarConexiones

        #endregion

    } // end class 

} // end BIHelper.lib