using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BIHelper.lib.controlm;

namespace BIHelper.forms
{
    /// <summary>
    /// Formulario para obtener la documentación de dependencias de Jobs de Control-M
    /// </summary>
    public partial class ControlMDependenciasForm : baseForm
    {
        #region

        /// <summary>
        /// Crea una nueva instancia de la clase 
        /// </summary>
        public ControlMDependenciasForm()
        {
            InitializeComponent();

            //  Instanciamos el importador de control M
            controlMImport = new ControlMImport();

            //  Inicializamos el listado de trabajos seleccionados
            //  como una nueva lista
            SelectedJobs = new List<JobDefinition>();

        } // end ControlMDependenciasForm

        #endregion

        #region Properties        

        /// <summary>
        /// Importador de Control M
        /// </summary>
        private ControlMImport controlMImport;

        /// <summary>
        /// Los jobs seleccionados
        /// </summary>
        private List<JobDefinition> SelectedJobs;

        #endregion

        #region

        /// <summary>
        /// Agrega un job al listado seleccionado
        /// </summary>
        /// <param name="jobDefinition"></param>
        private void AddSelectedJob(JobDefinition jobDefinition)
        {
            //  Si no se encuentra el job seleccionado
            if (!this.SelectedJobs.Contains(jobDefinition))
            {
                //  Lo agregamos a la selección
                this.SelectedJobs.Add(jobDefinition);

                //  Actualizamos la fuente de datos
                this.jobDefinitionBindingSource.DataSource = this.SelectedJobs;
                this.jobDefinitionBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Elimina un job del listado seleccionado
        /// </summary>
        /// <param name="jobDefinition"></param>
        private void DeleteSelectedJob(JobDefinition jobDefinition)
        {
            //  Si el job está seleccionado
            if (this.SelectedJobs.Contains(jobDefinition))
            {
                //  Lo quitamos de la lista
                this.SelectedJobs.Remove(jobDefinition);

                //  Actualizamos la fuente de datos
                this.jobDefinitionBindingSource.DataSource = this.SelectedJobs;
                this.jobDefinitionBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Pobla el arbol con las definiciones de los jobs
        /// </summary>
        private void PopulateTree()
        {
            /*
             * El control TreeView tiene asignada una lista de imágenes
             * para poder asignar una imágen a los nodos, 
             * por medio de un índice
             */

            //  Obtenemos los jobs de control M
            List<JobDefinition> jobsDefinitions = controlMImport.GetJobsDefinitions();

            //  Si no hay jobs
            if (jobsDefinitions.Count == 0)
            {
                //  Lanzamos la excepción
                throw new Exception("No hay jobs en el archivo");
            }

            //  Inicializamos el nodo raíz
            TreeNode root = new TreeNode("Desktop");

            //  Le configuramos su imagen, es la 0
            root.ImageIndex = 0;

            //  Consultamos las aplicaciones
            //  de la definición de jobs
            var applications = (from JD in jobsDefinitions
                                select JD.Application).Distinct();

            //  Cada aplicación será un "carpeta" en el árbol

            //  Para cada aplicación
            foreach (var application in applications)
            {
                //  Creamos un nodo de aplicación
                TreeNode applicationTreeNode = new TreeNode(application);

                //  Le configuramos su imágen, es la 1
                applicationTreeNode.ImageIndex = 1;

                //  Consultamos los grupos que tiene la aplicación
                //  de la definición de jobs
                var groups = (from JD in jobsDefinitions
                              where JD.Application == application
                              select JD.Group).Distinct();

                //  Cada grupo será un sub-carpeta dentro de la carpeta de aplicación

                //  Para cada grupo
                foreach (var g in groups)
                {
                    //  Creamos un nodo
                    TreeNode groupTreeNode = new TreeNode(g);

                    //  Le asignamos su imágen, es la 2
                    groupTreeNode.ImageIndex = 2;

                    //  Consultamos los jobs que tiene el grupo
                    //  de la definición de jobs
                    var jobs = (from JD in jobsDefinitions
                                where JD.Application == application
                                && JD.Group == g
                                select JD);

                    //  Cada job será un nodo en el árbol

                    //  Para cada job
                    foreach (var job in jobs)
                    {
                        //  Creamos un nodo
                        TreeNode jobTreeNode = new TreeNode(job.MemName);

                        //  Le asignamos su imágen, es la 3
                        jobTreeNode.ImageIndex = 3;

                        //  Obtenemos un objeto JobDefinition
                        //  del job
                        JobDefinition jobDefinition = (JobDefinition)job;

                        //  Se lo asignamos a la propiedad "Tag" del nodo
                        jobTreeNode.Tag = jobDefinition;

                        //  Agregamos el nodo al nodo de grupo
                        groupTreeNode.Nodes.Add(jobTreeNode);

                    } // end foreach jobs

                    //  Agregamos el nodo de grupo al de aplicaciones
                    applicationTreeNode.Nodes.Add(groupTreeNode);

                } // end foreach groups

                //  Agregamos el nodo de aplicaciones al nodo raíz
                root.Nodes.Add(applicationTreeNode);

            } // end foreach applications

            //  Agregamos el nodo raíz al árbol
            this.jobsTreeView.Nodes.Add(root);

            //  Expandimos el nodo raíz
            this.jobsTreeView.Nodes[0].Expand();

            //  Re-instanciamos el objeto de jobs seleccionados
            //  como una nueva lista
            this.SelectedJobs = new List<JobDefinition>();

        } // end PopulateTree

        /// <summary>
        /// "Des-checa" un nodo correspondiente a un JobDefinition
        /// </summary>
        /// <param name="jobDefinition">El <see cref="JobDefinition"/> a buscar</param>
        private void UnCheck(JobDefinition jobDefinition)
        {
            //  Las aplicaciones
            foreach (TreeNode applicationNode in this.jobsTreeView.Nodes[0].Nodes)
            {
                //  Los grupos
                foreach (TreeNode groupNode in applicationNode.Nodes)
                {
                    //  Los jobs
                    foreach (TreeNode jobNode in groupNode.Nodes)
                    {
                        //  Si el job es el seleccionado
                        if (((JobDefinition)jobNode.Tag) == jobDefinition)
                        {
                            //  Lo "des-checamos"
                            jobNode.Checked = false;
                        } // end if

                    } // end foreach

                } // end foreach

            } // end foreach

        } // end UnCheck

        #endregion

        #region Events

        /// <summary>
        /// Maneja el evento "Click" del control "ExplorarArchivoXmlButton"
        /// </summary>
        /// <param name="sender">El control "ExplorarArchivoXmlButton"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void ExplorarArchivoXmlButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Congelamos la pantalla y el puntero de mouse
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                //  Abrimos un cuadro de diálogo para abrir archivos xml
                OpenFileDialog openFileDlg = new OpenFileDialog();
                openFileDlg.DefaultExt = ".xml";
                openFileDlg.Filter = "XML Files (.xml)|*.xml";

                //  Si se eligió correctamente un archivo
                if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //  Mostramos el archivo en la caja de texto
                    this.FileNameTextBox.Text = openFileDlg.FileName;

                    //  Configuramos el archivo de control M
                    this.controlMImport.SetXmlFile(openFileDlg.FileName);

                    //  Llenamos el arbol
                    PopulateTree();

                }
                else // Si no
                {
                    //  Lanzamos un error
                    throw new Exception("Debe seleccionar un archivo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // end try / catch
            finally
            {
                //  Des-congelamos la pantalla y el puntero de mouse
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Maneja el evento "AfterCheck" del control "jobsTreeView"
        /// </summary>
        /// <param name="sender">El control "jobsTreeView"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void jobsTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                //  Si el nodo ha sido "palomeado"
                if (e.Node.Checked)
                {
                    //  Si tiene asignado un objeto en su "tag"
                    if(e.Node.Tag != null)
                    {
                        //  Obtenemos el job
                        JobDefinition jobDefinition = (JobDefinition)e.Node.Tag;

                        //  Lo agregamos como seleccionado
                        this.AddSelectedJob(jobDefinition);
                    }
                }
                else // si no ha sido "palomeado"
                {
                    //  Si tiene asignado un objeto en su "tag"
                    if (e.Node.Tag != null)
                    {
                        //  Obtenemos el job
                        JobDefinition jobDefinition = (JobDefinition)e.Node.Tag;

                        //  Lo eliminamos del listado de jobs seleccionados
                        this.DeleteSelectedJob(jobDefinition);

                    } // end if

                } // end else

            } // end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // end try / catch

        } // end jobsTreeView_AfterCheck

        /// <summary>
        /// Maneja el evento "CellClick" del control "jobDefinitionDataGridView"
        /// </summary>
        /// <param name="sender">El control "jobDefinitionDataGridView"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void jobDefinitionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //  Si se dió clic en la columna "Eliminar"
                if (jobDefinitionDataGridView.Columns[e.ColumnIndex].Name == "EliminarColumn")
                {
                    //  Obtenemos el Job del renglón
                    JobDefinition jobDefinition = 
                        (JobDefinition)jobDefinitionDataGridView.Rows[e.RowIndex].DataBoundItem;

                    //  Lo "des-palomeamos"
                    this.UnCheck(jobDefinition);

                    //  Eliminamos el job de la lista de Jobs seleccionados
                    this.DeleteSelectedJob(jobDefinition);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // end try / catch
        }

        /// <summary>
        /// Maneja el evento "Click" del control "DocumentarButton"
        /// </summary>
        /// <param name="sender">El control "DocumentarButton"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void DocumentarButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Congelamos la forma
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                //  Si no hay jobs seleccionados
                if (this.SelectedJobs.Count == 0)
                {
                    //  Lanzamos un error
                    throw new Exception("Seleccione al menos un job, por favor");
                }

                //  Esta variable contendrá los nombres de los jobs
                List<string> jobNames = new List<string>();

                //  Para cada job seleccionado
                foreach (JobDefinition jobDefinition in this.SelectedJobs)
                {
                    //  Lo agregamos a la lista
                    jobNames.Add(jobDefinition.JobName);
                }

                //  Obtenemos sus predecesores,
                //  este proceso lanzará automáticamente
                //  los reportes de salida
                controlMImport.GetJobsPredecesors(jobNames);

                //  Informamos éxito
                MessageBox.Show(
                    "Documentos generados",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // end try / catch
            finally
            {
                //  Descongelamos la forma
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            } // end finally

        } // end DocumentarButton_Click

        #endregion

    } // end class ControlMDependenciasForm

} // end namespace BIHelper.forms