using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BIHelper.lib;

namespace BIHelper.forms
{
    /// <summary>
    /// Formulario para dar de alta y actualizar una conexión con un servidor de metadata de Artus
    /// </summary>
    public partial class ConexionMetadataArtusForm : GradientForms.BaseFormGradient
    {
        #region Construtors

        /// <summary>
        /// Crea una instancia de la clase <see cref="ConexionMetaDaraArtusForm"/>
        /// </summary>
        public ConexionMetadataArtusForm()
        {
            InitializeComponent();

        } // end ConexionArtusForm

        #endregion

        #region Properties

        /// <summary>
        /// La conexión a la metadata de Artus representada en la forma
        /// </summary>
        public lib.ConexionMetaDataArtus Conexion { get; set; }

        /// <summary>
        /// Indica si se esta dando de alta una nueva conexión
        /// </summary>
        public bool EsNueva { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Liga los datos a los controles
        /// </summary>
        public void BindData()
        {
            //  Si la conexión es nueva
            if (EsNueva)
            {
                //  Agregamos una conexión en la fuente de datos
                this.conexionArtusBindingSource.AddNew();
            }
            else // Si no
            {
                //  Verificamos que la conexión está establecida
                if (this.Conexion == null)
                    throw new ArgumentNullException("La conexión no ha sido especificada");

                //  Configuramos la conexión a la fuente de datos
                this.conexionArtusBindingSource.DataSource = this.Conexion;

            } // end else

        } // end BindDate

        /// <summary>
        /// Configura una conexión a un servidor de metadata de Artus
        /// </summary>
        /// <returns></returns>
        private ConexionMetaDataArtus SetConn()
        {
            //  Obtenemos el objeto de conexión de la fuente de datos
            ConexionMetaDataArtus conn =
                    (ConexionMetaDataArtus)this.conexionArtusBindingSource.Current;

            //  Instanciamos un asistente de sql
            //  que prueba la conexión al instancia la clase
            SqlServerHelper sqlDB =
                new SqlServerHelper(
                    conn.Servidor,
                    conn.BaseDatos,
                    conn.Usuario,
                    conn.Password
                );

            //  Regresamos la conexión
            return conn;

        } // end SetConn

        #endregion

        #region Events

        /// <summary>
        /// Maneja el evento "Click" del control "ProbarConexionButton"
        /// </summary>
        /// <param name="sender">El control "ProbarConexionButton"</param>
        /// <param name="e">Los eventos del argumento</param>
        private void ProbarConexionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Configuramos una conexión
                SetConn();

                //  Si no hay error, informamos de éxito
                MessageBox.Show(
                    "¡Conexión Exitosa!",
                    "INFO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            } // end catch

        } // end ProbarConexionButton_Click

        /// <summary>
        /// Maneja el evento "Click" del control "CancelarButton"
        /// </summary>
        /// <param name="sender">El control "CancelarButton"</param>
        /// <param name="e">Los eventos del argumento</param>
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            //  Cerramos la forma
            this.Close();
        }

        /// <summary>
        /// Maneja el evento "Click" del control "GuardarButton"
        /// </summary>
        /// <param name="sender">El control "GuardarButton"</param>
        /// <param name="e">Los eventos del argumento</param>
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Abrir conexiones
                //  Agregar conexion
                //  Guardar conexiones
                //  Salir

                //  Instanciamos el administrador de conexiones
                AdminConexiones admin = new AdminConexiones();

                //  Cargamos las conexiones actuales
                admin.CargarConexiones();

                //  Agregamos las nueva conexión
                admin.Conexiones.ConexionesMetaDataArtus.Add(SetConn());

                //  Guardamos las conexiones
                admin.Guardar();

                //  Informamos de éxito
                MessageBox.Show(
                    "Conexión guardada exitosamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                //  Recargamos las conexiones
                MyForms.Conexiones.CargarConexionesArtus();

                //  Por si se abre en modal
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                //  Cerramos la forma
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            } // end catch

        } // end GuardarButton_Click

        /// <summary>
        /// Maneja el evento "Click" del control "AyudaButton"
        /// </summary>
        /// <param name="sender">El control "AyudaButton"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void AyudaButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Despliega a ayuda
                System.Diagnostics.Process.Start("help\\AltaArtusMetaData.htm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

            } // end catch

        } // end AyudaButton_Click


        #endregion

    } // end class ConexionArtusForm

} // end namespace BIHelper.forms
