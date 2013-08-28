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
    /// Formulario para administrar las conexiones
    /// </summary>
    public partial class ConexionesForm : baseForm
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia del formulairo <see cref="ConexionesForm"/>
        /// </summary>
        public ConexionesForm()
        {
            InitializeComponent();

        } // end ConexionesForm

        #endregion

        #region Properties

        /// <summary>
        /// Los listados de conexiones
        /// </summary>
        AdminConexiones AdminConexiones { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Carga las conexiones de Artus
        /// </summary>
        public void CargarConexionesArtus()
        {
            AdminConexiones = new AdminConexiones();
            AdminConexiones.CargarConexiones();
            this.conexionArtusBindingSource.DataSource = AdminConexiones.Conexiones.ConexionesMetaDataArtus;
        }

        #endregion


        /// <summary>
        /// Maneja el evento "LinkClicked" del control "NuevaConexionArtusLinkLabel"
        /// </summary>
        /// <param name="sender">El control "NuevaConexionArtusLinkLabel"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void NuevaConexionArtusLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //  Abrimos la pantalla para capturar una nueva conexión a metadata de Artus

                //  Establecemos que la conexión será nueva
                MyForms.ConexionMetadataArtus.EsNueva = true;

                //  Ligamos los datos a los controles
                MyForms.ConexionMetadataArtus.BindData();

                //  Mostramos el formulario
                MyForms.ConexionMetadataArtus.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );

            } // end try catch

        } // end NuevaConexionArtusLinkLabel_LinkClicked

        /// <summary>
        /// Maneja el evento "Load" del formulario "ConexionesForm"
        /// </summary>
        /// <param name="sender">El formulario "CoonexionesForm"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void ConexionesForm_Load(object sender, EventArgs e)
        {
            try
            {
                //  Cargamos las conexiones a Artus
                CargarConexionesArtus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        /// <summary>
        /// Maneja el evento "CellClick" del control "conexionArtusDataGridView"
        /// </summary>
        /// <param name="sender">El control "conexionArtusDataGridView"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void conexionArtusDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //  Dependiendo de la celda seleccionada
                DataGridViewColumn columna = this.conexionArtusDataGridView.Columns[e.ColumnIndex];

                //  Si es la columna de eliminar la conexión
                if (columna.Name.Equals("EliminarConexion"))
                {
                    //  Mensaje a mostrar al usuario, para confirmar la eliminación
                    string msg = @"¿Realmente desea eliminar la conexión?";

                    //  Instanciamos un dialogo de confirmación
                    DialogResult dialogResult = 
                        MessageBox.Show(
                            msg, 
                            "Confirmación", 
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question
                        );

                    //  Si el usuario confirmó la eliminación
                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        //  Obtenemos el dato de la conexión de Artus
                        //  del renglón seleccionado
                        ConexionMetaDataArtus artusConn =
                        (ConexionMetaDataArtus)this.conexionArtusDataGridView.Rows[e.RowIndex].DataBoundItem;

                        //  Inicializamos el administrador de conexiones
                        //  Eliminamos la conexión
                        //  Guardamos
                        AdminConexiones adminConexiones = new AdminConexiones();
                        adminConexiones.CargarConexiones();
                        adminConexiones.Conexiones.ConexionesMetaDataArtus.Remove(artusConn);
                        adminConexiones.Guardar();

                        //  Recargamos las conexiones de artus
                        MyForms.Conexiones.CargarConexionesArtus();
                    }
                }
                else if (columna.Name.Equals("EditConexion")) // si la columna es la de actualización
                {
                    //  Obtenemos el dato de la conexión de Artus
                    //  del renglón seleccionado
                    ConexionMetaDataArtus artusConn =
                        (ConexionMetaDataArtus)this.conexionArtusDataGridView.Rows[e.RowIndex].DataBoundItem;

                    //  Abrimosla pantalla para actualizar la conexión

                    //  Establecemos que la conexión NO es nueva
                    MyForms.ConexionMetadataArtus.EsNueva = false;

                    //  Establecemos la conexión a modificar
                    MyForms.ConexionMetadataArtus.Conexion = artusConn;

                    //  Mostramos la forma
                    MyForms.ConexionMetadataArtus.Show();

                } // end else if                
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

        } // end NuevaConexionArtusLinkLabel_LinkClicked

    } // end ConexionesForm

} // end BIHelper.forms