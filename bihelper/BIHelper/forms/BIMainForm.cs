using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BIHelper.lib;
using System.Diagnostics;

namespace BIHelper.forms
{
    /// <summary>
    /// Pantalla principal del sistema
    /// </summary>
    public partial class BIMainForm : Form
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="BIMainForm"/>
        /// </summary>
        public BIMainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Representa las diferentes opcines de la aplicación
        /// </summary>
        private enum Opciones
        {
            blank,
            DocMapeo,
            DocCubo,
            DocJobs,
            AdminConexiones
        }

        /// <summary>
        /// Representa la opción actul en la aplicación
        /// </summary>
        private Opciones OpcionActual { get; set; }

        #endregion

        /// <summary>
        /// Maneja el evento "Load" del formulario "BIMainForm"
        /// </summary>
        /// <param name="sender">El formulario "BIMainForm"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void BIMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //  Establecemos la pantalla y la opción en blank
                this.DockForm(MyForms.blank);
                this.OpcionActual = Opciones.blank;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        } // end BIMainForm_Load

        /// <summary>
        /// Establece un formulario dentro del panel principal del formulario de administración
        /// </summary>
        /// <param name="forma"></param>
        public void DockForm(Form forma)
        {
            //  Establecemos las propiedades de la forma

            //  Sin borde
            forma.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //  El tamaño del panel
            forma.Size = this.DockPanel.Size;

            //  Esta propiedad nos permite incrustar el formulario en otro
            forma.TopLevel = false;

            //  Agregamos la forma al  panel
            this.DockPanel.Controls.Add(forma);            

            //  Mostramos la forma
            forma.Show();

            //  La enviamos al frente de la pantalla
            this.DockPanel.Controls[forma.Name].BringToFront();

        } // end DockForm

        /// <summary>
        /// Maneja el evento "Click" del control "DocumentacionMapeoButton"
        /// </summary>
        /// <param name="sender">El control DocumentacionMapeobutton</param>
        /// <param name="e">Los argumentos del evento</param>
        private void DocumentacionMapeoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Establecemos la pantalla y la opción en Documentación de Mapeos

                this.DockForm(MyForms.DocMapeo);
                this.TitleLabel.Text = "BI-Helper :: Documentación de Mapeo de Informatica";
                this.OpcionActual = Opciones.DocMapeo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Maneja el evento "Click" del control "ConexionesButton"
        /// </summary>
        /// <param name="sender">El control ConexionesButton</param>
        /// <param name="e">Los argumentos del evento</param>
        private void ConexionesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Establecemos la pantalla y la opción en Administrador de Conexiones

                this.DockForm(MyForms.Conexiones);
                this.TitleLabel.Text = "BI-Helper :: Administración de Conexiones";
                this.OpcionActual = Opciones.AdminConexiones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Maneja el evento "Click" del control "DocCuboButton"
        /// </summary>
        /// <param name="sender">El control DocCuboButton</param>
        /// <param name="e">Los argumentos del evento</param>
        private void DocCuboButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Establecemos la pantalla y la opción en Documentación de Cubos

                this.DockForm(MyForms.AnalisisCubo);
                this.TitleLabel.Text = "BI-Helper :: Documentación de Cubo de Artus";
                this.OpcionActual = Opciones.DocCubo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Maneja el evento "Click" del control "DocJobsButton"
        /// </summary>
        /// <param name="sender">El control DocJobsButton</param>
        /// <param name="e">Los argumentos del evento</param>
        private void DocJobsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Establecemos la pantalla y la opción en Documentación de Jobs

                this.DockForm(MyForms.ControlMDependencias);
                this.TitleLabel.Text = "BI-Helper :: Documentación de Jobs de Control-M";
                this.OpcionActual = Opciones.DocJobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Maneja el evento "Click" del control "AyudaButton"
        /// </summary>
        /// <param name="sender">El control "AyudaButton"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void AyudaButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Dependiendo de la opción actual,
                //  mostramos la ayuda

                switch (this.OpcionActual)
                {
                    case Opciones.DocMapeo:
                        
                        Process.Start("help\\Mapeo.htm");                    
                        
                        break;

                    case Opciones.DocCubo:

                        Process.Start("help\\Cubo.htm");

                        break;

                    case Opciones.DocJobs:

                        Process.Start("help\\Job.htm");

                        break;

                    case Opciones.AdminConexiones:

                        Process.Start("help\\AltaArtusMetaData.htm");

                        break;

                    default:
                        
                        MessageBox.Show(
                            "Lo siento, no hay ayuda para esta opción", 
                            "Info", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information
                        );
                        
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        } // end DocCuboButton_Click

    } // end class BIMainForm

} // end namespace BIHelper.forms