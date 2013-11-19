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
    /// Formulario para la visualización de elementos de un archivo XML exportado de Informatica
    /// </summary>
    public partial class WorkFlowViewerForm : baseForm
    {
        #region Constructors

        public WorkFlowViewerForm()
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
        /// Maneja el evento "Click" del control "ExplorarArchivoXmlIPCButton"
        /// </summary>
        /// <param name="sender">El control  "ExplorarArchivoXmlIPCButton"</param>
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

                    //  Obtenemos la informacion del workflow
                    this.GenerarArbolWorkFlows(this.Infa.GetWorkFlowData());

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
        }

        #endregion

        #region

        /// <summary>
        /// Genera el arbol de workflows
        /// </summary>
        private void GenerarArbolWorkFlows(lib.WorkFlowViewerData wflData)
        {
            //  Limpiamos los nodos del arbol
            this.WorkflowsTreeView.Nodes.Clear();

            //  Cremos el nodo raiz
            TreeNode root = new TreeNode("Workflows");

            //  Le asignamos la imagen de la carpeta
            root.ImageIndex = 3;

            //  Recorremos los workflows
            //  Para cada workflow
            foreach (lib.WorkFlowViewerData.WorkFlow workflow in wflData.Workflows)
            {
                //  Creamos un nodo de workflow
                TreeNode workflowTreeNode = new TreeNode(workflow.Name);

                //  Asignamos la imagen
                workflowTreeNode.ImageIndex = 0;

                //  Recorremos las sessions
                //  Para cada session
                foreach (lib.WorkFlowViewerData.Session session in workflow.Sessions)
                {
                    //  Creamos un nodo para la session
                    TreeNode sessionTreeNode = new TreeNode(session.ToString());

                    //  Asignamos la imagen
                    sessionTreeNode.ImageIndex = 1;


                    //  Creamos un nodo para el mapping
                    TreeNode mappingTreeNode = new TreeNode(session.Mapping.Name);

                    //  Asignamos la imagen
                    mappingTreeNode.ImageIndex = 2;


                    //  Creamos un nodo que contendrá las fuentes
                    //  del mapping
                    TreeNode sourcesTreeNode = new TreeNode("Sources");

                    //  Asignamos la imagen
                    sourcesTreeNode.ImageIndex = 3;

                    //  Recorremos las fuentes del mapeo
                    //  Para cada fuente
                    foreach (lib.WorkFlowViewerData.Source source in session.Mapping.Sources)
                    {
                        //  Creamos un nodo para la source
                        TreeNode sourceTreeNode = new TreeNode(source.Name);

                        //  Asignamos la imagen
                        sourceTreeNode.ImageIndex = 4;

                        //  Recoremos sus campos
                        //  Para cada campo
                        foreach (lib.WorkFlowViewerData.SourceField sourceField in source.SourceFields)
                        {
                            //  Creamos un nodo para el campo de la fuente
                            TreeNode sourceFieldTreeNode = new TreeNode(sourceField.ToString());

                            //  Asignamos la imagen
                            sourceFieldTreeNode.ImageIndex = 6;

                            //  Lo agregamos a los campos de la fuente
                            sourceTreeNode.Nodes.Add(sourceFieldTreeNode);
                        }

                        //  Agregamos la fuente al nodo de fuentes
                        sourcesTreeNode.Nodes.Add(sourceTreeNode);
                    }

                    //  Agregamos la fuente al mapeo
                    mappingTreeNode.Nodes.Add(sourcesTreeNode);


                    //  Creamos un nodo para contener los targets
                    TreeNode targetsTreeNode = new TreeNode("Targets");

                    //  Asignamos la imagen
                    targetsTreeNode.ImageIndex = 3;

                    //  Recorremos los targets
                    //  Para cada target
                    foreach (lib.WorkFlowViewerData.Target target in session.Mapping.Targets)
                    {
                        //  Creamos un nodo para los targets
                        TreeNode targetTreeNode = new TreeNode(target.Name);

                        //  Asignamos la imagen
                        targetTreeNode.ImageIndex = 5;

                        //  Recorremos los campos de los targets
                        //  para cada campo
                        foreach(lib.WorkFlowViewerData.TargetField targetField in target.TargetFields)
                        {
                            //  Creamos un nodo
                            TreeNode targetFieldTreeNode = new TreeNode(targetField.ToString());

                            //  Asignamos la imagen
                            targetFieldTreeNode.ImageIndex = 6;

                            //  Lo agregamos al target
                            targetTreeNode.Nodes.Add(targetFieldTreeNode);
                        }

                        //  Agregamos el target al contenedor
                        targetsTreeNode.Nodes.Add(targetTreeNode);
                    }

                    //  Agregamos el contenedor de targets al mapping
                    mappingTreeNode.Nodes.Add(targetsTreeNode);


                    //  Creamos un nodo para contener las transformations
                    TreeNode transformationsTreeNode = new TreeNode("Transformations");

                    //  Asignamos la imagen
                    transformationsTreeNode.ImageIndex = 3;


                    //  Recorremos las transformations
                    //  Para cada transformation                   
                    foreach (lib.WorkFlowViewerData.Transformation transformation in session.Mapping.Transformations)
                    {
                        //  Creamos un nodo
                        TreeNode transformationTreeNode = new TreeNode(transformation.ToString());

                        //  Asignamos la imagen
                        transformationTreeNode.ImageIndex = 7;

                        //  Recorremos los campos
                        //  Para cada campo
                        foreach (lib.WorkFlowViewerData.TransformField transformField in transformation.TransformFields)
                        {
                            //  Creamos un nodo
                            TreeNode transformFieldTreeNode = new TreeNode(transformField.ToString());

                            //  Asignamos la imagen
                            transformFieldTreeNode.ImageIndex = 6;

                            //  Agregamos el campo a la transformacion
                            transformationTreeNode.Nodes.Add(transformFieldTreeNode);
                        }

                        //  Agregamos la transformacion al contenedor
                        transformationsTreeNode.Nodes.Add(transformationTreeNode);
                    }

                    //  Agregamos el contendedor de transformaciones
                    //  al nodo del ampping
                    mappingTreeNode.Nodes.Add(transformationsTreeNode);

                    //  Agregamos el nodo del mapping a la session
                    sessionTreeNode.Nodes.Add(mappingTreeNode);

                    //  Agregamos la session al workflow
                    workflowTreeNode.Nodes.Add(sessionTreeNode);

                } // end foreach Session

                //  Agregamos el workflow al nodo raiz
                root.Nodes.Add(workflowTreeNode);

            } // end foreach Workflows

            //  Agregamos el nodo raíz al arbol
            WorkflowsTreeView.Nodes.Add(root);

        } // end void GenerarArbolWorkFlows

        #endregion

    } // end class WorkFlowViewerForm

} // end namespace BIHelper.forms
