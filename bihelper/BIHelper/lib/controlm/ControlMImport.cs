using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace BIHelper.lib.controlm
{
    /// <summary>
    /// Clase que importa información de un archivo draft
    /// de control M en xml
    /// </summary>
    class ControlMImport
    {
        #region Constructors
        #endregion

        #region Properties

        /// <summary>
        /// Esta variable contendrá los predecesores de Jobs
        /// obtenidos del draft
        /// </summary>
        private List<Jobs_Predecesors> jobs_predecesors = new List<Jobs_Predecesors>();

        /// <summary>
        /// El constructor de cadenas utilizado para generar
        /// los reportes de salida
        /// </summary>
        private StringBuilder sb = new StringBuilder();

        /// <summary>
        /// El documento XML a utilizar, que contiene las descripciones de las tablas
        /// de control M
        /// </summary>
        private XmlDocument xdoc { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Establece el archivo XML de draft de Control-M a utilizar
        /// </summary>
        /// <param name="xmlFilePath"></param>
        public void SetXmlFile(string xmlFilePath)
        {
            //Load xml
            xdoc = new XmlDocument();
            xdoc.XmlResolver = null;
            xdoc.Load(xmlFilePath);
        }

        /// <summary>
        /// Obtiene la definción de los jobs del archivo XML
        /// </summary>
        /// <returns></returns>
        public List<JobDefinition> GetJobsDefinitions()
        {
            //  Esta variable contendrá las definiciones de jobs
            List<JobDefinition> jobsDefinitions = new List<JobDefinition>();

            //  Obtenemos los nodos de jobs
            XmlNodeList jobsNodes = xdoc.SelectNodes("/DEFTABLE/SCHED_TABLE/JOB");

            //  Para cada nodo
            foreach (XmlNode jobNode in jobsNodes)
            {
                //  Instanciamos una nueva definición de Job
                JobDefinition jobDefinition = new JobDefinition();

                //  Obtenemos sus propiedades
                //  del nodo

                //  Application
                jobDefinition.Application =
                    (jobNode.Attributes.GetNamedItem("APPLICATION") == null) ? "" : jobNode.Attributes.GetNamedItem("APPLICATION").Value;

                //  Group
                jobDefinition.Group =
                    (jobNode.Attributes.GetNamedItem("GROUP") == null) ? "" : jobNode.Attributes.GetNamedItem("GROUP").Value;

                //  MemName
                jobDefinition.MemName =
                    (jobNode.Attributes.GetNamedItem("MEMNAME") == null) ? "" : jobNode.Attributes.GetNamedItem("MEMNAME").Value;

                //  JobName
                jobDefinition.JobName =
                    (jobNode.Attributes.GetNamedItem("JOBNAME") == null) ? "" : jobNode.Attributes.GetNamedItem("JOBNAME").Value;

                //  Agregamos el job al listado
                jobsDefinitions.Add(jobDefinition);

            } // end foreach

            //  Devolvemos el listado
            return jobsDefinitions;
        }

        /// <summary>
        /// Obtiene los predecesores de una lista de Jobs y los exporta en dos documentos
        /// </summary>
        /// <param name="jobsNames"></param>
        public void GetJobsPredecesors(List<string> jobsNames)
        {
            //  Esta variable contiene la ruta del primer archivo
            //  que especifica las dependencias, job por job
            string jobByJobFileName = Path.Combine(Path.GetTempPath(), "PrecedesoresPorJob.doc");

            //  Esta variable contiene la ruta dle segundo archivo
            //  que especifica el listado de las distintas depedencias
            //  necesarias para el listado de jobs
            string dependenciasJobsFileName = Path.Combine(Path.GetTempPath(), "PredecesoresJobs.doc");

            //  Para cada job
            foreach (string jobName in jobsNames)
            {
                //  Obtenemos sus predecesores
                GetListPred(jobName, jobName);
            }

            //  Construimos el primer reporte en formato html

            //  Los encabezasos
            sb.AppendLine("<html>");
            sb.AppendLine("\t<head><title>Listado de Tareas Proyecto ROPA</title></head>");
            sb.AppendLine("\t<body style=\"font-family: 'Segoe UI';\">");
            sb.AppendLine("<h1>Listado de Jobs y sus dependencias en Control M</h1>");
            sb.AppendLine("<br/>");

            //  Para cada job
            foreach (string jobName in jobsNames)
            {
                //  imprimimos su nombre
                sb.AppendLine("<br/>");
                sb.AppendLine("<h2>Job: " + jobName + "</h2>");
                sb.AppendLine("<h4>Predecesores</h4>");                

                //  Obtenemos sus predecesores
                var preds = (from JP in jobs_predecesors
                             where JP.Job == jobName
                             select JP.Predecesor).Distinct();

                //  Si no existen predecesores
                if (preds.Count() == 0)
                {
                    //  Imprimimos el mensaje
                    sb.AppendLine("\t<p>No tiene predecesores.</p>");
                }
                else // Si no, si existen predecesores
                {
                    //  Creamos un listado con los mismos

                    sb.AppendLine("<ul>");

                    //  Para cada predecesor
                    foreach (var pred in preds)
                    {
                        //  Lo imprimimos en el listado
                        sb.AppendLine("\t<li>" + pred + "</li>");

                    } // end foreach preds

                    sb.AppendLine("</ul>");

                } // end else

            } // end foreach dict

            //  Cerramos el html
            sb.AppendLine("</body></html>");

            //  Escribimos el archivo a disco
            File.WriteAllText(jobByJobFileName, sb.ToString());

            //  Creamos el segundo reporte

            //  Re-instanciamos el constructor de cadenas
            sb = new StringBuilder();

            //  Configuramos los encabezados del reporte
            sb.AppendLine("<html>");
            sb.AppendLine("\t<head><title>Listado de Tareas Proyecto ROPA</title></head>");
            sb.AppendLine("\t<body style=\"font-family: 'Segoe UI';\">");
            sb.AppendLine("\t\t<h1>Listado de Jobs y sus dependencias en Control M</h1>");
            sb.AppendLine("\t\t<br/>");

            //  Creamos una tabla, para mostrar los jobs
            sb.AppendLine("\t\t<table>");
            sb.AppendLine("\t\t\t<tr><th>JOB</th></tr>");

            //  Para caja job
            foreach (string jobName in jobsNames)
            {
                //  Lo agregamos a la tabla
                sb.AppendLine("\t\t\t<tr><td>" + jobName + "</td></tr>");
            }

            //  Cerramos la tabla
            sb.AppendLine("\t\t</table>");

            //  Ahora imprimiremos las dependencias
            sb.AppendLine("\t\t<h2>Dependencias Necesarias (Predecesores)</h2>");
            sb.AppendLine("\t\t<br/>");

            //  Obtenemos las distintas dependencias de los jobs
            var distinctJobs = (from JP in jobs_predecesors
                                select JP.Predecesor).Distinct();

            //  Creamos un listado para mostrarlas
            sb.AppendLine("\t\t<ul>");

            //  Para cada dependencia (predecesor)
            foreach (var pred in distinctJobs)
            {
                //  La agregamos al listado
                sb.AppendLine("\t\t\t<li>" + pred + "</li>");

            } // end foreach preds

            //  Cerramos el listado
            sb.AppendLine("\t\t</ul>");

            //  Escribimos el archivo
            File.WriteAllText(dependenciasJobsFileName, sb.ToString());
  
            //  Abrimos los archivos creados
            Process.Start(jobByJobFileName);
            Process.Start(dependenciasJobsFileName);
        }
        
        /// <summary>
        /// Establece la lista de predecesores de un job en particular
        /// </summary>
        /// <param name="jobName">El nombre del job</param>
        /// <param name="root">El nombre del job raíz</param>
        public void GetListPred(string jobName, string root)
        {
            //  Obtenemos el nodo del job del documento XML
            XmlNode jobNode = xdoc.SelectSingleNode("/DEFTABLE/SCHED_TABLE/JOB[@JOBNAME='" + jobName + "']");

            //  Si no existe, salimos de la función
            if (jobNode == null)
                return;

            //  Obtenemos las condiciones de entrada del job,
            //  es decir, sus dependencias
            XmlNodeList incondsNodes = jobNode.SelectNodes("INCOND");

            //  Para cada nodo dependencia
            foreach (XmlNode incondNode in incondsNodes)
            {
                //  Obtenemos el nombre del predecesor
                string jobPredName =
                    (incondNode.Attributes.GetNamedItem("NAME") == null) ? "" : incondNode.Attributes.GetNamedItem("NAME").Value;

                //  Obtenemos los nodos donde la dependencia es condición de salida
                //  es decir, los predecesores del predecesor
                XmlNodeList jobsPredNodes =
                    xdoc.SelectNodes("/DEFTABLE/SCHED_TABLE/JOB/OUTCOND[@NAME='" + jobPredName + "']");

                //  Para cada nodo predecesor
                foreach (XmlNode jobPredNode in jobsPredNodes)
                {
                    //  Obtenemos su padre
                    XmlNode jobPredParentNode = jobPredNode.SelectSingleNode("..");

                    //  Obtenemos su nombre
                    string jobPrednodeName =
                    (jobPredParentNode.Attributes.GetNamedItem("JOBNAME") == null) ? "" : jobPredParentNode.Attributes.GetNamedItem("JOBNAME").Value;

                    //  Instanciamos una variable de tipo Jobs_Predecesors
                    Jobs_Predecesors jobPredecesor = new Jobs_Predecesors();

                    //  Configuramos el nodo raíz
                    jobPredecesor.Job = root;

                    //  Configuramos el nodo predecesor
                    jobPredecesor.Predecesor = jobPrednodeName;

                    //  Si no está ya en la lista
                    if (!jobs_predecesors.Contains(jobPredecesor))
                    {
                        //  Lo agregamos a la lista
                        jobs_predecesors.Add(jobPredecesor);
                        
                        //  Efectuamos la función de manera recursiva, 
                        //  sobre el nodo predecesor
                        GetListPred(jobPrednodeName, root);

                    } // end if

                } // end foreach jobPredNode

            } // end foreach incondNode

        } // end GetPredecesors()

        #endregion

    } // end class ControlMImport

} // end namespace MetaAtenea.lib