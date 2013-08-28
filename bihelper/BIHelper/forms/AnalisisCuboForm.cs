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
    /// Formulario para mostrar el analisis de un cubo
    /// </summary>
    public partial class AnalisisCuboForm : baseForm
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="AnalisisCuboForm"/>
        /// </summary>
        public AnalisisCuboForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// El asistente de acceso a datos para generar el documento
        /// </summary>
        SqlServerHelper SqlDB { get; set; }

        #endregion

        #region Methods
        
        /// <summary>
        /// Liga los datos a los controles
        /// </summary>
        public void BindData()
        {
            //  Instanciamos el Administrador de conexiones
            lib.AdminConexiones adminConexiones = new AdminConexiones();

            //  Cargamos las conexiones actuales
            adminConexiones.CargarConexiones();

            //  Si no hay conexiones de Artus
            if (adminConexiones.Conexiones.ConexionesMetaDataArtus.Count == 0)
            {
                //  No hay conexiones Artus
                //  Solicitar una nueva conexión
                string msg = @"No hay conexiones a servidores de metadata de artus disponibles.
¿Desea crear una nueva?";

                //  Si se desea crear una nueva conexión
                if (MessageBox.Show(msg, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                    System.Windows.Forms.DialogResult.Yes)
                {
                    //  Mostramos la pantalla
                    MyForms.ConexionMetadataArtus.EsNueva = true;
                    MyForms.ConexionMetadataArtus.BindData();

                    //  Si llenó una nueva forma
                    if (MyForms.ConexionMetadataArtus.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //  Volvemos a cargar las conexiónes
                        adminConexiones.CargarConexiones();

                        this.conexionMetaDataArtusBindingSource.DataSource = adminConexiones.Conexiones.ConexionesMetaDataArtus;

                        //  Cargamos los cubos
                        BindCubos();
                    }
                }
            }
            else // Si no, hay al menos una conexión
            {
                //  establecemos la fuente de datos
                this.conexionMetaDataArtusBindingSource.DataSource = adminConexiones.Conexiones.ConexionesMetaDataArtus;

                //  Cargamos los cubos
                BindCubos();
            }
        } // end ConsultarDetalle

        /// <summary>
        /// Carga los cubos seleccionables
        /// </summary>
        private void BindCubos()
        {
            //  Si un servidor de Artus esta seleccionado
            if (this.ServidorArtusComboBox.SelectedItem != null)
            {
                //  Obtenemos el servidor artus elegido
                lib.ConexionMetaDataArtus conn =
                    (lib.ConexionMetaDataArtus)this.ServidorArtusComboBox.SelectedItem;

                //  Instanciamos concepto
                lib.artus.SI_CONCEPTO si_concepto = new lib.artus.SI_CONCEPTO();

                //  Asignamos la conexión del servidor artus seleccionado
                this.SqlDB = new SqlServerHelper(
                    conn.Servidor,
                    conn.BaseDatos,
                    conn.Usuario,
                    conn.Password
                );

                //  Asignamos la conexión a la instancia de concepto
                si_concepto.SqlDB = this.SqlDB;

                //  Obtenemos los conceptos
                this.sI_CONCEPTOBindingSource.DataSource = si_concepto.Read();

            } // end if

        } // end BindCubos

        /// <summary>
        /// Consulta la información del cubo en la base de datos y la muestra en el reporte
        /// </summary>
        public void Consultar()
        {
            //  Obtenemos el concepto del cubo seleccionado
            lib.artus.SI_CONCEPTO si_concepto = (lib.artus.SI_CONCEPTO)this.CuboComboBox.SelectedItem;

            //  Obtenemos las datasources

            //  Los indicadores
            lib.artus.Vista_Indicadores_Cubo ind = new lib.artus.Vista_Indicadores_Cubo();
            ind.SqlDB = this.SqlDB;
            List<lib.artus.Vista_Indicadores_Cubo> vista_indicadores_cubo = ind.Get(si_concepto.CLA_CONCEPTO);

            //  Las dimension
            lib.artus.Vista_Dimensiones_Cubo dim = new lib.artus.Vista_Dimensiones_Cubo();
            dim.SqlDB = this.SqlDB;
            List<lib.artus.Vista_Dimensiones_Cubo> vista_dimensiones_cubo = dim.Get(si_concepto.CLA_CONCEPTO);

            //  Los periodos
            lib.artus.Vista_Periodos_Cubo per = new lib.artus.Vista_Periodos_Cubo();
            per.SqlDB = this.SqlDB;
            List<lib.artus.Vista_Periodos_Cubo> vista_periodos_cubo = per.Get(si_concepto.CLA_CONCEPTO);

            //  El cubo
            List<lib.artus.SI_CONCEPTO> si_conceptos = new List<lib.artus.SI_CONCEPTO>();
            si_conceptos.Add(si_concepto);

            //  Configuramos el reporte
            this.ReporteCuboReportViewer.LocalReport.ReportEmbeddedResource = "BIHelper.reports.DetalleCuboReport.rdlc";

            //  Eliminamos las fuentes de datos
            this.ReporteCuboReportViewer.LocalReport.DataSources.Clear();

            //  Asignamos las fuentes de datos al reporte

            //  El cubo
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "SI_CONCEPTO_DataSet",
                    si_conceptos
                )
            );

            //  Los indicadores
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "Vista_Indicadores_DataSet",
                    vista_indicadores_cubo
                )
            );

            //  Las dimesiones
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "Vista_Dimensiones_DataSet",
                    vista_dimensiones_cubo
                )
            );

            //  Los periodos
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "Vista_Periodos_DataSet",
                    vista_periodos_cubo
                )
            );

            //  Actualizamos el reporte
            this.ReporteCuboReportViewer.RefreshReport();
        }

        #endregion

        #region Events

        /// <summary>
        /// Maneja en evento "Load" del formulario "AnalisisCuboForm"
        /// </summary>
        /// <param name="sender">El formulario "AnalisisCuboForm"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void AnalisisCuboForm_Load(object sender, EventArgs e)
        {
            try
            {
                //  Ligamos los datos a los controles
                this.BindData();
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
        /// Maneja el evento "Click" del control "GenerarDocumentacionButton"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerarDocumentacionButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                //  Si hay un cubo seleccionado
                if (this.CuboComboBox.SelectedItem != null)
                {
                    //  Consultamos la información
                    this.Consultar();
                }
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
            finally
            {
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Maneja el evento "SeleccionChangeCommited" del control "ServidorArtusComboBox"
        /// </summary>
        /// <param name="sender">El control "ServidorArtusComboBox"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void ServidorArtusComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            try
            {
                //  Obtenemos los cubos
                //  y los mostramos en los controles                
                BindCubos();
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
        } // end AnalisisCuboForm_Load

        #endregion

    } // end AnalisisCuboForm

} // end BIHelper.forms
