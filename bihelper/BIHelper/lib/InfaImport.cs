using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace BIHelper.lib
{
    /// <summary>
    /// Realiza operaciones para importar información de Informatica Power Center
    /// </summary>
    class InfaImport
    {

        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="InfaImport"/>
        /// </summary>
        public InfaImport()
        {
        }

        /// <summary>
        /// Crea un nueva instancia de la clase <see cref="InfaImport"/>
        /// </summary>
        /// <param name="fileName">El nombre del archivo xml exportado de informatica</param>
        public InfaImport(string fileName)
        {
            this.INFA_XmlFilePath = fileName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Archivo xml de donde se obtiene la informacion, exportado de informática
        /// </summary>
        private string INFA_XmlFilePath { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene una lista de pares "Destino->Fuente"
        /// </summary>
        /// <param name="mappingName"></param>
        public List<ETLDoc> GetETLDoc(string mappingName)
        {
            //  Lista que contendrá los diferentes tipos de transformaciones
            List<string> transformationTypes = new List<string>();

            //  Cadena para almacenar las expresiones xPath
            string xPathExp = "";

            //  Variable local para almacenar el archivo XML importado
            //  de Informatica Power Center
            string fileName = this.INFA_XmlFilePath;

            //  Verificamos que el archivo ha sido configurado
            if (string.IsNullOrEmpty(fileName))
            {
                throw new Exception("El archivo no ha sido configurado");
            }

            //  Verificamos que el archivo existe
            if (!File.Exists(fileName))
            {
                throw new Exception("El archivo no existe.");
            }

            //  La variable que contendrá el documento XML
            XmlDocument xdoc = new XmlDocument();

            //  Eliminamos la necesidad de expecificar un XmlResolver
            xdoc.XmlResolver = null;

            //  Cargamos el archivo
            xdoc.Load(fileName);

            //  Expresión XParth para obtener los targets del mapeo
            xPathExp = "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='" + mappingName + "']/INSTANCE[@TYPE='TARGET']";

            //  Listado de nodos obtenidos
            XmlNodeList instanceTargetsNodes =
                xdoc.SelectNodes(
                    xPathExp
                );

            //  Esta variable almacenará los pares del mapeo
            List<ETLPair> mappingPairs = new List<ETLPair>();

            //  Para cada nodo "Target"
            foreach (XmlNode instanceTargetnode in instanceTargetsNodes)
            {
                //  Obtenemos el nombre de la instancia de la transformación
                string toInstance = instanceTargetnode.Attributes.GetNamedItem("NAME").Value;

                //  Obtenemos el tipo de la instancia de la transformación
                string toInstanceType = instanceTargetnode.Attributes.GetNamedItem("TRANSFORMATION_TYPE").Value;

                //  Obtenemos los pares de transformaciones
                //  del tipo "Fuente - Destino"
                this.GetPair(
                    mappingName,
                    toInstance,
                    toInstanceType,
                    xdoc,
                    ref mappingPairs
                );
            } // end foreach

            //  Regresmos la documentación a partir del listado de transformaciones obtenido
            return GetDoc(mappingPairs, xdoc);

        } // end GetPairs

        /// <summary>
        /// Obtiene un par de instancias de transformaciones en un mapeo, conectadas entre si
        /// </summary>
        /// <param name="mappingName">El nombre del mapeo</param>
        /// <param name="toInstance">El nombre de la instancia destino</param>
        /// <param name="toInstanceType">El tipo de la instancia destino</param>
        /// <param name="xdoc">El documento XML que contiene la información del mapeo</param>
        /// <param name="mappingPairs">La variable que contendrá el listado de referencias</param>
        public void GetPair(
            string mappingName,
            string toInstance,
            string toInstanceType,
            XmlDocument xdoc,
            ref List<ETLPair> mappingPairs
        )
        {
            //  Esta variable contendrá el listado de instancia para las cuales
            //  la instancia especificada "toInstance", es una transformación objetivo
            Dictionary<string, string> fromInstances = new Dictionary<string, string>();

            //  Configuramos la expresión XPath para obetener los conectores de la transformación
            string xPath = string.Format(
                "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/CONNECTOR[@TOINSTANCE='{1}' and @TOINSTANCETYPE='{2}']",
                mappingName,
                toInstance,
                toInstanceType
            );

            //  Esta lista contendrá los conectores
            XmlNodeList connectorsNodes = xdoc.SelectNodes(xPath);

            //  Para cada conector
            foreach (XmlNode connectorNode in connectorsNodes)
            {
                //  Obtenemos la instancia "Origen"
                KeyValuePair<string, string> fromInstance =
                    new KeyValuePair<string, string>(
                        connectorNode.Attributes.GetNamedItem("FROMINSTANCE").Value,
                        connectorNode.Attributes.GetNamedItem("FROMINSTANCETYPE").Value
                    );

                //  Si no está ya en la lista, agregarla
                if (!fromInstances.Contains(fromInstance))
                {
                    fromInstances.Add(fromInstance.Key, fromInstance.Value);
                } // end if

            } // end foreach

            //  Para cada instancia origen, para la cual la instancia de transformación
            //  "toInstance" es un objetivo.
            foreach (KeyValuePair<string, string> fromInstance in fromInstances)
            {
                //  Creamos un nuevo registro de par de valores ETL
                ETLPair etlpair = new ETLPair();

                //  Aumentamos el conteo en uno
                //  y lo configuramos como el orden de la transformación
                etlpair.Orden = mappingPairs.Count + 1;

                //  COnfiguramos el nombre del mapeo
                etlpair.Mapeo = mappingName;

                //  La instancia destino
                etlpair.Destino = toInstance;

                //  El tipo de la instancia destino
                etlpair.TipoDestino = toInstanceType;

                //  El nombre de la instacia funte
                etlpair.Fuente = fromInstance.Key;

                //  El tipo de la instancaia fuente
                etlpair.TipoFuente = fromInstance.Value;

                //  Agregamos el par a la lista
                mappingPairs.Add(etlpair);

            } // end foreach

            //  Para cada instancia fuente, aplico recursivamente
            //  esta misma función, lo que producirá un listado
            //  de pares de transformación del tipo Fuente - Destino.
            foreach (KeyValuePair<string, string> fromInstance in fromInstances)
            {
                GetPair(
                    mappingName,
                    fromInstance.Key,
                    fromInstance.Value,
                    xdoc,
                    ref mappingPairs
                );

            } // foreach

        } // end GetPair

        /// <summary>
        /// Obtiene la documentación del mapeo
        /// </summary>
        /// <param name="mappingName"></param>
        public List<ETLDoc> GetDoc(List<ETLPair> mappingPairs, XmlDocument xdoc)
        {
            //  Variable que contendrá las expresiones XPath
            string xpath = "";

            //  En esta lista almacenaremos todas las transformaciones,
            //  puerto por puerto
            List<ETLDoc> etldocList = new List<ETLDoc>();

            //  Recorremos la lista de pares de transformaciones
            foreach (ETLPair mappingPair in mappingPairs)
            {
                //  Construimos la expresión de los conectores
                xpath = string.Format(
                            "/POWERMART/REPOSITORY/FOLDER/" +
                            "MAPPING[@NAME='{0}']/" +
                            "CONNECTOR[@FROMINSTANCE='{1}' " +
                            "and @TOINSTANCE='{2}']",
                            mappingPair.Mapeo,
                            mappingPair.Fuente,
                            mappingPair.Destino
                        );

                //  Variable para contener los nodos obtenidos de los conectores
                XmlNodeList connectorsNodes = xdoc.SelectNodes(xpath);

                //  El nombre  de las transformaciones a usar
                //  para targets y sources
                string fuenteTransformationName, destinoTransformationName;

                //  En esta variable almacenaremos el nodo de la instancia
                XmlNode instanceNode;

                //  Obtenemos la instancia destino
                xpath = string.Format(
                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/INSTANCE[@NAME='{1}']",
                            mappingPair.Mapeo,
                            mappingPair.Destino
                        );

                instanceNode = xdoc.SelectSingleNode(xpath);

                //  Obtenemos el nombre de la transformacion destino
                destinoTransformationName = instanceNode.Attributes.GetNamedItem("TRANSFORMATION_NAME").Value;

                //  Obtenemos la instancia fuente
                xpath = string.Format(
                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/INSTANCE[@NAME='{1}']",
                            mappingPair.Mapeo,
                            mappingPair.Fuente
                        );

                instanceNode = xdoc.SelectSingleNode(xpath);

                //  Obtenemos el nombre de la transformacion fuente
                fuenteTransformationName = instanceNode.Attributes.GetNamedItem("TRANSFORMATION_NAME").Value;

                //  Recorremos los conectores
                foreach (XmlNode connectorNode in connectorsNodes)
                {
                    //  Instanciamos una variable ETLDoc, que contendrá
                    //  el mapeo de puertos
                    ETLDoc etldoc = new ETLDoc();

                    //  Configuramos sus valores: Mapeo, Orden, Table Destino y Fuente
                    etldoc.Mapeo = mappingPair.Mapeo;
                    etldoc.Orden = mappingPair.Orden;
                    etldoc.Destino_Tabla = mappingPair.Destino;
                    etldoc.Fuente_Tabla = mappingPair.Fuente;

                    //  Obtenemos el campo de puerto destino
                    string toField = connectorNode.Attributes.GetNamedItem("TOFIELD").Value; ;

                    //  Obtenemos el campo de puerto fuente
                    string fromField = connectorNode.Attributes.GetNamedItem("FROMFIELD").Value; ;

                    //  Primero obtenemos el campo destino

                    //  Si el destino es tipo "Target"
                    if (mappingPair.TipoDestino.Contains("Target Definition"))
                    {
                        //  Obtenems el target field correspondiente
                        xpath = string.Format(
                                    "/POWERMART/REPOSITORY/FOLDER/TARGET[@NAME='{0}']/TARGETFIELD[@NAME='{1}']",
                                    destinoTransformationName,
                                    toField
                                );

                        XmlNode targetNode = xdoc.SelectSingleNode(xpath);

                        //  Obtenemos y configuramos sus atributos
                        etldoc.Destino_Campo = toField;
                        etldoc.Destino_TipoDatos = targetNode.Attributes.GetNamedItem("DATATYPE").Value;
                        etldoc.Destino_Tamano = targetNode.Attributes.GetNamedItem("PRECISION").Value;
                    }
                    else // Si no, es algún tipo de transformacion
                    {
                        //  Obtenemos su campo de transformación
                        xpath = string.Format(
                                    "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TRANSFORMFIELD[@NAME='{2}']",
                                    mappingPair.Mapeo,
                                    mappingPair.Destino,
                                    toField
                                );

                        XmlNode transformationNode = xdoc.SelectSingleNode(xpath);

                        //  Configuramos sus atributos
                        etldoc.Destino_Campo = toField;
                        etldoc.Destino_TipoDatos = transformationNode.Attributes.GetNamedItem("DATATYPE").Value;
                        etldoc.Destino_Tamano = transformationNode.Attributes.GetNamedItem("PRECISION").Value;
                    }

                    //  Luego obtenemos el campo fuente

                    //  Si es de tipo "Source Definition"
                    if (mappingPair.TipoFuente.Contains("Source Definition"))
                    {
                        //  Es una fuente

                        //  Obtenemos los datos del campo fuente

                        //  Construimos la expresion para consultar
                        //  el campo especifico en el objeto de tipo fuente
                        xpath = string.Format(
                                    "/POWERMART/REPOSITORY/FOLDER/SOURCE[@NAME='{0}']/SOURCEFIELD[@NAME='{1}']",
                                    fuenteTransformationName,
                                    fromField
                                );

                        XmlNode sourceNode = xdoc.SelectSingleNode(xpath);

                        //  Configuramos sus datos
                        etldoc.Fuente_Campo = fromField;
                        etldoc.Fuente_TipoDatos = sourceNode.Attributes.GetNamedItem("DATATYPE").Value;
                        etldoc.Fuente_Tamano = sourceNode.Attributes.GetNamedItem("PRECISION").Value;

                        //  Asignamos el tipo y detalle de las transformaciones
                        //  simplemente como "Fuente"
                        etldoc.Transformacion_Detalle = "";
                        etldoc.Transformacion_Tipo = "SOURCE";
                    }
                    else // Si no, es una transformación
                    {
                        //  Construimos la expresión para consulta el campo de transformación
                        xpath = string.Format(
                                    "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TRANSFORMFIELD[@NAME='{2}']",
                                    mappingPair.Mapeo,
                                    mappingPair.Fuente,
                                    fromField
                                );

                        XmlNode transformationFieldNode = xdoc.SelectSingleNode(xpath);

                        //  Si es nulo
                        if (transformationFieldNode == null)
                        {
                            //  Entonces es un mapplet
                            xpath = string.Format(
                                    "/POWERMART/REPOSITORY/FOLDER/MAPPLET[@NAME='{0}']/CONNECTOR[@TOFIELD='{1}']",
                                    mappingPair.Fuente,
                                    fromField
                                );

                            transformationFieldNode = xdoc.SelectSingleNode(xpath);

                            //  El nombre de la instancia del mapplet
                            string toInstance = transformationFieldNode.Attributes.GetNamedItem("TOINSTANCE").Value;

                            //  Obtenemos el transformfield del mapplet
                            xpath = string.Format(
                                    "/POWERMART/REPOSITORY/FOLDER/MAPPLET[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TRANSFORMFIELD[@NAME='{2}']",                                    
                                    mappingPair.Fuente,
                                    toInstance,
                                    fromField
                                );

                            transformationFieldNode = xdoc.SelectSingleNode(xpath);

                            //  Configuramos sus datos
                            etldoc.Fuente_Campo = fromField;
                            etldoc.Fuente_TipoDatos = transformationFieldNode.Attributes.GetNamedItem("DATATYPE").Value;
                            etldoc.Fuente_Tamano = transformationFieldNode.Attributes.GetNamedItem("PRECISION").Value;
                        }
                        else // Si es transformacion
                        {
                            //  Configuramos sus datos
                            etldoc.Fuente_Campo = fromField;
                            etldoc.Fuente_TipoDatos = transformationFieldNode.Attributes.GetNamedItem("DATATYPE").Value;
                            etldoc.Fuente_Tamano = transformationFieldNode.Attributes.GetNamedItem("PRECISION").Value;
                        }
                        

                        //  El tipo de transformación lo obtenemos del tipo de fuente del par de mapeo
                        etldoc.Transformacion_Tipo = mappingPair.TipoFuente;

                        //  Contendrá los nodes de atributos de tabla de las transformaciones
                        XmlNode tableAttributeFieldNode;

                        //  Para cada tipo de transformación, agregamos el detalle
                        switch (mappingPair.TipoFuente)
                        {
                            case "Expression":

                                etldoc.Transformacion_Detalle = transformationFieldNode.Attributes.GetNamedItem("EXPRESSION").Value;

                                break;

                            case "Source Qualifier":

                                etldoc.Transformacion_Detalle = "";

                                break;

                            case "Aggregator":

                                etldoc.Transformacion_Detalle = transformationFieldNode.Attributes.GetNamedItem("EXPRESSIONTYPE").Value;
                                etldoc.Transformacion_Detalle += ", " + transformationFieldNode.Attributes.GetNamedItem("EXPRESSION").Value;

                                break;

                            case "Sorter":

                                etldoc.Transformacion_Detalle = transformationFieldNode.Attributes.GetNamedItem("ISSORTKEY").Value.Equals("YES") ? "SORT" : "";
                                etldoc.Transformacion_Detalle += ", " + transformationFieldNode.Attributes.GetNamedItem("SORTDIRECTION").Value;

                                break;

                            case "Lookup Procedure":

                                etldoc.Transformacion_Detalle = "";

                                //  Consultar los table atributes de la transformación

                                //  Construimos la expresión para consulta el campo de transformación
                                xpath = string.Format(
                                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TABLEATTRIBUTE[@NAME='Lookup table name']",
                                            mappingPair.Mapeo,
                                            mappingPair.Fuente,
                                            fromField
                                        );

                                tableAttributeFieldNode = xdoc.SelectSingleNode(xpath);

                                etldoc.Transformacion_Atributos = "Table name: " + tableAttributeFieldNode.Attributes.GetNamedItem("VALUE").Value;


                                xpath = string.Format(
                                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TABLEATTRIBUTE[@NAME='Lookup condition']",
                                            mappingPair.Mapeo,
                                            mappingPair.Fuente,
                                            fromField
                                        );

                                tableAttributeFieldNode = xdoc.SelectSingleNode(xpath);

                                etldoc.Transformacion_Atributos += ";  Condition =" + tableAttributeFieldNode.Attributes.GetNamedItem("VALUE").Value;


                                break;

                            case "Update Strategy":

                                etldoc.Transformacion_Detalle = "";

                                //  Consultar los table atributes de la transformación

                                xpath = string.Format(
                                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TABLEATTRIBUTE[@NAME='Update Strategy Expression']",
                                            mappingPair.Mapeo,
                                            mappingPair.Fuente,
                                            fromField
                                        );

                                tableAttributeFieldNode = xdoc.SelectSingleNode(xpath);

                                etldoc.Transformacion_Atributos = "Update Expression: " + tableAttributeFieldNode.Attributes.GetNamedItem("VALUE").Value;

                                break;

                            case "Filter":

                                //  Consultar los table atributes de la transformación

                                xpath = string.Format(
                                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TABLEATTRIBUTE[@NAME='Filter Condition']",
                                            mappingPair.Mapeo,
                                            mappingPair.Fuente,
                                            fromField
                                        );

                                tableAttributeFieldNode = xdoc.SelectSingleNode(xpath);

                                etldoc.Transformacion_Atributos = "Condition: " + tableAttributeFieldNode.Attributes.GetNamedItem("VALUE").Value;
                                break;

                            case "Joiner":

                                etldoc.Transformacion_Detalle = "";

                                //  Consultar los table atributes de la transformación
                                xpath = string.Format(
                                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TABLEATTRIBUTE[@NAME='Join Type']",
                                            mappingPair.Mapeo,
                                            mappingPair.Fuente,
                                            fromField
                                        );

                                tableAttributeFieldNode = xdoc.SelectSingleNode(xpath);

                                etldoc.Transformacion_Atributos = "Join Type:" + tableAttributeFieldNode.Attributes.GetNamedItem("VALUE").Value;

                                xpath = string.Format(
                                            "/POWERMART/REPOSITORY/FOLDER/MAPPING[@NAME='{0}']/TRANSFORMATION[@NAME='{1}']/TABLEATTRIBUTE[@NAME='Join Condition']",
                                            mappingPair.Mapeo,
                                            mappingPair.Fuente,
                                            fromField
                                        );

                                tableAttributeFieldNode = xdoc.SelectSingleNode(xpath);

                                etldoc.Transformacion_Atributos += "; Condition: " + tableAttributeFieldNode.Attributes.GetNamedItem("VALUE").Value;

                                break;

                            case "Custom Transformation":

                                etldoc.Transformacion_Detalle = "GROUP: " + transformationFieldNode.Attributes.GetNamedItem("PORTTYPE").Value;

                                break;

                            case "Sequence":

                                etldoc.Transformacion_Detalle = "DEFAULT: " + transformationFieldNode.Attributes.GetNamedItem("DEFAULTVALUE").Value;

                                break;

                        } // end switch

                    } // end else

                    //  Cargamos el documento
                    etldocList.Add(etldoc);

                } // end foreach

            } // end foreach

            return etldocList;

        } // end GetDoc

        /// <summary>
        /// Obtiene los nombres de los mapeos
        /// </summary>
        /// <returns></returns>
        public List<string> GetMapeos()
        {
            //  Esta variable contendrá los nombres de los mapeos
            List<string> mapeos = new List<string>();

            //  Esta variable contendrá las expresiones XPath
            string xPathExp = "";

            //  El nombre del archivo exportado de Informatica Power Center
            string fileName = this.INFA_XmlFilePath;

            //  Si el archivo esta vacio
            if (string.IsNullOrEmpty(fileName))
            {
                //  Lanzamos un error
                throw new Exception("El archivo no existe o es nulo");
            }

            //  El documento xml utilizado para procesar la información
            XmlDocument xdoc = new XmlDocument();

            //  Prevenimos la utilización de DTD's
            xdoc.XmlResolver = null;

            //  Cargamos el archivo
            xdoc.Load(fileName);

            //  Obtengo los targets que dicen el ToFind
            xPathExp = "/POWERMART/REPOSITORY/FOLDER/MAPPING";
            
            XmlNodeList mappingsNodes =
                xdoc.SelectNodes(
                    xPathExp
                );

            //  Para cada mapping
            foreach (XmlNode mappingNode in mappingsNodes)
            {
                //  Agrego el nombre del mapeo
                mapeos.Add(mappingNode.Attributes.GetNamedItem("NAME").Value);
            }

            //  Ordeno los mapeos
            mapeos.Sort();

            //  Devuelve los mapeos
            return mapeos;

        } // GetMapeos

        #endregion

    } // end class InfaImport

} // end namespace BIHelper.lib