using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIHelper.lib
{
    /// <summary>
    /// Contiene información sobre los workflows y objetos de Informatica
    /// </summary>
    class WorkFlowViewerData
    {
        #region Constructors
        #endregion

        #region Properties

        /// <summary>
        /// Listado de Workflows en los datos
        /// </summary>
        public List<WorkFlow> Workflows
        {
            get
            {
                if (_workflows == null)
                    _workflows = new List<WorkFlow>();

                return _workflows;
            }
            set
            {
                _workflows = value;
            }
        }

        /// <summary>
        /// Variable que contiene los workflows de los datos
        /// </summary>
        private List<WorkFlow> _workflows;
        #endregion

        #region InnerClasses

        /// <summary>
        /// Representa un Workflow de Informatica PC
        /// </summary>
        public class WorkFlow
        {
            #region Constructors


            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Workflow
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// El listado de Sessiones dentro del Workflow
            /// </summary>
            public List<Session> Sessions
            {
                get
                {
                    if (_sessions == null)
                        _sessions = new List<Session>();

                    return _sessions;
                }
                set
                {
                    _sessions = value;
                }
            }

            /// <summary>
            /// Variable que contiene el listado de sesiones
            /// </summary>
            private List<Session> _sessions;

            #endregion

            #region Methods
            #endregion
        }

        /// <summary>
        /// Representa una Session de Informatica PC
        /// </summary>
        public class Session
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre de la session
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// El Mapping de la Session
            /// </summary>
            public Mapping Mapping { get; set; }

            /// <summary>
            /// Indica si una session es o nó reusable
            /// </summary>
            public bool IsReusable { get; set; }

            #endregion

            #region Methods
            
            /// <summary>
            /// Devuelve una cadena representando a la clase
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                if (IsReusable)
                    return Name + " (Reusable)";
                else
                    return Name;
            }

            #endregion
        }

        /// <summary>
        /// Representa un Mapping de Informatica PC
        /// </summary>
        public class Mapping
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Mapping
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Listado de Sources del Mapping
            /// </summary>
            public List<Source> Sources
            {
                get
                {
                    if (_sources == null)
                        _sources = new List<Source>();

                    return _sources;
                }
                set
                {
                    _sources = value;
                }
            }

            /// <summary>
            /// La variable que contiene el listado de Sources del Mapping
            /// </summary>
            private List<Source> _sources;

            /// <summary>
            /// Listado de Targets del Mapping
            /// </summary>
            public List<Target> Targets
            {
                get
                {
                    if (_targets == null)
                        _targets = new List<Target>();

                    return _targets;
                }
                set
                {
                    _targets = value;
                }
            }

            /// <summary>
            /// Variable que contiene el listado de Targets del Mapping
            /// </summary>
            private List<Target> _targets;

            /// <summary>
            /// Listado de Transformations del Mapping
            /// </summary>
            public List<Transformation> Transformations
            {
                get
                {
                    if (_transformations == null)
                        _transformations = new List<Transformation>();

                    return _transformations;
                }
                set
                {
                    _transformations = value;
                }
            }

            private List<Transformation> _transformations;
            #endregion

            #region Methods
            #endregion
        }

        /// <summary>
        /// Representa una Source de Informatica PC
        /// </summary>
        public class Source
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Source
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Variable que contiene los campos de Source
            /// </summary>
            private List<SourceField> _sourceFields;

            /// <summary>
            /// Listado de campos de Source
            /// </summary>
            public List<SourceField> SourceFields
            {
                get
                {
                    if (_sourceFields == null)
                        _sourceFields = new List<SourceField>();

                    return _sourceFields;
                }
                set
                {
                    _sourceFields = value;
                }
            }

            #endregion

            #region Methods
            #endregion
        }

        /// <summary>
        /// Representa un Target de Informatica PC
        /// </summary>
        public class Target
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Target
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Variable que contiene el listado de campos de Target
            /// </summary>
            private List<TargetField> _targetFields;

            /// <summary>
            /// Listado de campos de Target
            /// </summary>
            public List<TargetField> TargetFields
            {
                get
                {
                    if (_targetFields == null)
                        _targetFields = new List<TargetField>();

                    return _targetFields;
                }
                set
                {
                    _targetFields = value;
                }
            }

            #endregion

            #region Methods
            #endregion
        }

        /// <summary>
        /// Representa una Tranformation de Informatica PC
        /// </summary>
        public class Transformation
        {

            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre de la transformacion
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// El tipo de la transformacion
            /// </summary>
            public string Type { get; set; }

            /// <summary>
            /// Variable que contiene el listado de campos de transformaciones
            /// </summary>
            private List<TransformField> _transformFields;

            /// <summary>
            /// Listado de campos de transformaciones
            /// </summary>
            public List<TransformField> TransformFields
            {
                get
                {
                    if (_transformFields == null)
                        _transformFields = new List<TransformField>();

                    return _transformFields;
                }
                set
                {
                    _transformFields = value;
                }
            }

            #endregion

            #region Methods

            /// <summary>
            /// Devuelve una cadena representando a la clase
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name + " (" + Type + ")";
            }

            #endregion

        }

        /// <summary>
        /// Representa el campo de una transformación
        /// </summary>
        public class TransformField
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Target
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// El tipo de dato
            /// </summary>
            public string DataType { get; set; }

            /// <summary>
            /// La presicion
            /// </summary>
            public string Precision { get; set; }

            #endregion

            #region Methods

            /// <summary>
            /// Devuelve una cadena representando a la clase
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name + ", " + DataType + ", " + Precision;
            }

            #endregion

        } // end class TransformField

        /// <summary>
        /// Representa un campo de una Source
        /// </summary>
        public class SourceField
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Target
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// El tipo de dato
            /// </summary>
            public string DataType { get; set; }

            /// <summary>
            /// La presicion
            /// </summary>
            public string Precision { get; set; }

            #endregion

            #region Methods

            /// <summary>
            /// Devuelve una cadena representando a la clase
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name + ", " + DataType + ", " + Precision;
            }

            #endregion
        } // end class SourceField

        /// <summary>
        /// Representa un campo de un Target
        /// </summary>
        public class TargetField
        {
            #region Constructors
            #endregion

            #region Properties

            /// <summary>
            /// El nombre del Target
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// El tipo de dato
            /// </summary>
            public string DataType { get; set; }

            /// <summary>
            /// La presicion
            /// </summary>
            public string Precision { get; set; }

            #endregion

            #region Methods

            /// <summary>
            /// Devuelve una cadena representando a la clase
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name + ", " + DataType + ", " + Precision;
            }

            #endregion
        }

        #endregion

        #region Methods
        #endregion

    } // end class WorkFlowViewerData

} // end namespace BIHelper.lib