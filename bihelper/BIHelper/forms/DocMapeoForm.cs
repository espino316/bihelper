using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIHelper.forms
{
    /// <summary>
    /// Formulario para documentar los mapos de Informatica Power Center
    /// </summary>
    public partial class DocMapeoForm : baseForm
    {
        #region Constructors

        /// <summary>
        /// Crea un nueva instancia de la clase <see cref="DocMapeoForm"/>
        /// </summary>
        public DocMapeoForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Clase importadora de Informatica
        /// </summary>
        private lib.InfaImport Infa;

        #endregion


        #region Events

        /// <summary>
        /// Maneja el evento "Click" del control "GenerarDocumentacionButton"
        /// </summary>
        /// <param name="sender">El control "GenerarDocumentacionButton"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void GenerarDocumentacionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  "Congelamos" la pantalla y el puntero del mouse
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                //  Obtenemos el nombre del mapeo
                string mapeo = this.MapeosComboBox.SelectedValue.ToString();

                //  Lo configuramos como fuente de datos
                this.ETLDocBindingSource.DataSource = Infa.GetETLDoc(mapeo);

                //  "Refresacamos" el reporte
                this.DocumentadorReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //  "Des-congelamos" la pantalla y el puntero del mouse
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

        } // end GenerarDocumentacionButton_Click

        /// <summary>
        /// Maneja el evento "Click" del control "ExplorarArchivoXMLIPCButton"
        /// </summary>
        /// <param name="sender">El control "ExplorarArchivoXMLIPCButton"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void ExplorarArchivoXmlIPCButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Abrimos una ventana de diálogo para buscar
                //  archivos xml
                OpenFileDialog openFileDlg = new OpenFileDialog();
                openFileDlg.DefaultExt = ".xml";
                openFileDlg.Filter = "XML Files (.xml)|*.xml";

                //  Si el usuario eligió un archivo
                if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //  Congelamos la forma
                    this.Enabled = false;
                    this.Cursor = Cursors.WaitCursor;

                    //  Mostramos el nombre del archivo
                    this.FileNameTextBox.Text = openFileDlg.FileName;

                    //  Instanciamos el importador de Informatica PC
                    this.Infa = new lib.InfaImport(openFileDlg.FileName);

                    //  Obtenemos los mapeos
                    List<string> mapeos = Infa.GetMapeos();

                    //  Si no hay algún mapeo
                    if (mapeos.Count == 0)
                    {
                        //  Lanzamos excepción
                        throw new Exception("No hay mapeos en el documento XML");

                    } // end if

                    //  Los asignamos a la caja de lista deplegable
                    this.MapeosComboBox.DataSource = mapeos;

                } // end if
                else
                {
                    throw new Exception("Debe seleccionar un archivo");

                } // end else

            } // end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // end try / catch
            finally
            {
                //  Descongelamos la forma
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

        } // end ExplorarArchivoXmlIPCButton_Click

        #endregion

    } // end class

} // end namespace