using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Representa la tabla SI_INDICADOR de la base de datos de metadata de Artus
    /// </summary>
    public class SI_INDICADOR
    {

        #region Constructors

        public SI_INDICADOR()
        {
        }

        public SI_INDICADOR(
            int cla_indicador,
            int? cla_concepto,
            int? cla_padre,
            string nom_indicador,
            string formula_usr,
            string formula_bd,
            string nom_tabla,
            string llaves,
            string tipo_agrupacion,
            string formato,
            int? tipo_indicador,
            int? cla_usuario,
            int? reexpresados,
            string descripcion,
            Int16? filtro,
            Int16? paretto,
            string tablas,
            string donde,
            string dimensiones,
            int? no_ejecutivo,
            int? es_atributo,
            int? nivel_jerarquia,
            int? es_divisor,
            string dim_depend,
            string dim_alarm,
            int? actual,
            int? cla_periodo,
            int? decremental,
            int? id_cpto_atrib,
            int? cla_owner,
            string filter_sql,
            string niveles,
            string kpivalue,
            int? only_last_period,
            int? notnumeric,
            string nonemptybehavior,
            int? in_aggregation)
        {
            this.CLA_INDICADOR = cla_indicador;
            this.CLA_CONCEPTO = cla_concepto;
            this.CLA_PADRE = cla_padre;
            this.NOM_INDICADOR = nom_indicador;
            this.FORMULA_USR = formula_usr;
            this.FORMULA_BD = formula_bd;
            this.NOM_TABLA = nom_tabla;
            this.LLAVES = llaves;
            this.TIPO_AGRUPACION = tipo_agrupacion;
            this.FORMATO = formato;
            this.TIPO_INDICADOR = tipo_indicador;
            this.CLA_USUARIO = cla_usuario;
            this.REEXPRESADOS = reexpresados;
            this.DESCRIPCION = descripcion;
            this.FILTRO = filtro;
            this.PARETTO = paretto;
            this.TABLAS = tablas;
            this.DONDE = donde;
            this.DIMENSIONES = dimensiones;
            this.NO_EJECUTIVO = no_ejecutivo;
            this.ES_ATRIBUTO = es_atributo;
            this.NIVEL_JERARQUIA = nivel_jerarquia;
            this.ES_DIVISOR = es_divisor;
            this.DIM_DEPEND = dim_depend;
            this.DIM_ALARM = dim_alarm;
            this.ACTUAL = actual;
            this.CLA_PERIODO = cla_periodo;
            this.DECREMENTAL = decremental;
            this.ID_CPTO_ATRIB = id_cpto_atrib;
            this.CLA_OWNER = cla_owner;
            this.FILTER_SQL = filter_sql;
            this.NIVELES = niveles;
            this.KPIVALUE = kpivalue;
            this.ONLY_LAST_PERIOD = only_last_period;
            this.NOTNUMERIC = notnumeric;
            this.NONEMPTYBEHAVIOR = nonemptybehavior;
            this.IN_AGGREGATION = in_aggregation;
        }

        #endregion

        #region Properties

        /// <summary>
        /// La instancia del asistente a datos
        /// </summary>
        public lib.SqlServerHelper SqlDB { get; set; }

        private int _CLA_INDICADOR;
        public int CLA_INDICADOR
        {
            get { return _CLA_INDICADOR; }
            set { _CLA_INDICADOR = value; }
        }

        private int? _CLA_CONCEPTO;
        public int? CLA_CONCEPTO
        {
            get { return _CLA_CONCEPTO; }
            set { _CLA_CONCEPTO = value; }
        }

        private int? _CLA_PADRE;
        public int? CLA_PADRE
        {
            get { return _CLA_PADRE; }
            set { _CLA_PADRE = value; }
        }

        private string _NOM_INDICADOR;
        public string NOM_INDICADOR
        {
            get { return _NOM_INDICADOR; }
            set { _NOM_INDICADOR = value; }
        }

        private string _FORMULA_USR;
        public string FORMULA_USR
        {
            get { return _FORMULA_USR; }
            set { _FORMULA_USR = value; }
        }

        private string _FORMULA_BD;
        public string FORMULA_BD
        {
            get { return _FORMULA_BD; }
            set { _FORMULA_BD = value; }
        }

        private string _NOM_TABLA;
        public string NOM_TABLA
        {
            get { return _NOM_TABLA; }
            set { _NOM_TABLA = value; }
        }

        private string _LLAVES;
        public string LLAVES
        {
            get { return _LLAVES; }
            set { _LLAVES = value; }
        }

        private string _TIPO_AGRUPACION;
        public string TIPO_AGRUPACION
        {
            get { return _TIPO_AGRUPACION; }
            set { _TIPO_AGRUPACION = value; }
        }

        private string _FORMATO;
        public string FORMATO
        {
            get { return _FORMATO; }
            set { _FORMATO = value; }
        }

        private int? _TIPO_INDICADOR;
        public int? TIPO_INDICADOR
        {
            get { return _TIPO_INDICADOR; }
            set { _TIPO_INDICADOR = value; }
        }

        private int? _CLA_USUARIO;
        public int? CLA_USUARIO
        {
            get { return _CLA_USUARIO; }
            set { _CLA_USUARIO = value; }
        }

        private int? _REEXPRESADOS;
        public int? REEXPRESADOS
        {
            get { return _REEXPRESADOS; }
            set { _REEXPRESADOS = value; }
        }

        private string _DESCRIPCION;
        public string DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }

        private Int16? _FILTRO;
        public Int16? FILTRO
        {
            get { return _FILTRO; }
            set { _FILTRO = value; }
        }

        private Int16? _PARETTO;
        public Int16? PARETTO
        {
            get { return _PARETTO; }
            set { _PARETTO = value; }
        }

        private string _TABLAS;
        public string TABLAS
        {
            get { return _TABLAS; }
            set { _TABLAS = value; }
        }

        private string _DONDE;
        public string DONDE
        {
            get { return _DONDE; }
            set { _DONDE = value; }
        }

        private string _DIMENSIONES;
        public string DIMENSIONES
        {
            get { return _DIMENSIONES; }
            set { _DIMENSIONES = value; }
        }

        private int? _NO_EJECUTIVO;
        public int? NO_EJECUTIVO
        {
            get { return _NO_EJECUTIVO; }
            set { _NO_EJECUTIVO = value; }
        }

        private int? _ES_ATRIBUTO;
        public int? ES_ATRIBUTO
        {
            get { return _ES_ATRIBUTO; }
            set { _ES_ATRIBUTO = value; }
        }

        private int? _NIVEL_JERARQUIA;
        public int? NIVEL_JERARQUIA
        {
            get { return _NIVEL_JERARQUIA; }
            set { _NIVEL_JERARQUIA = value; }
        }

        private int? _ES_DIVISOR;
        public int? ES_DIVISOR
        {
            get { return _ES_DIVISOR; }
            set { _ES_DIVISOR = value; }
        }

        private string _DIM_DEPEND;
        public string DIM_DEPEND
        {
            get { return _DIM_DEPEND; }
            set { _DIM_DEPEND = value; }
        }

        private string _DIM_ALARM;
        public string DIM_ALARM
        {
            get { return _DIM_ALARM; }
            set { _DIM_ALARM = value; }
        }

        private int? _ACTUAL;
        public int? ACTUAL
        {
            get { return _ACTUAL; }
            set { _ACTUAL = value; }
        }

        private int? _CLA_PERIODO;
        public int? CLA_PERIODO
        {
            get { return _CLA_PERIODO; }
            set { _CLA_PERIODO = value; }
        }

        private int? _DECREMENTAL;
        public int? DECREMENTAL
        {
            get { return _DECREMENTAL; }
            set { _DECREMENTAL = value; }
        }

        private int? _ID_CPTO_ATRIB;
        public int? ID_CPTO_ATRIB
        {
            get { return _ID_CPTO_ATRIB; }
            set { _ID_CPTO_ATRIB = value; }
        }

        private int? _CLA_OWNER;
        public int? CLA_OWNER
        {
            get { return _CLA_OWNER; }
            set { _CLA_OWNER = value; }
        }

        private string _FILTER_SQL;
        public string FILTER_SQL
        {
            get { return _FILTER_SQL; }
            set { _FILTER_SQL = value; }
        }

        private string _NIVELES;
        public string NIVELES
        {
            get { return _NIVELES; }
            set { _NIVELES = value; }
        }

        private string _KPIVALUE;
        public string KPIVALUE
        {
            get { return _KPIVALUE; }
            set { _KPIVALUE = value; }
        }

        private int? _ONLY_LAST_PERIOD;
        public int? ONLY_LAST_PERIOD
        {
            get { return _ONLY_LAST_PERIOD; }
            set { _ONLY_LAST_PERIOD = value; }
        }

        private int? _NOTNUMERIC;
        public int? NOTNUMERIC
        {
            get { return _NOTNUMERIC; }
            set { _NOTNUMERIC = value; }
        }

        private string _NONEMPTYBEHAVIOR;
        public string NONEMPTYBEHAVIOR
        {
            get { return _NONEMPTYBEHAVIOR; }
            set { _NONEMPTYBEHAVIOR = value; }
        }

        private int? _IN_AGGREGATION;
        public int? IN_AGGREGATION
        {
            get { return _IN_AGGREGATION; }
            set { _IN_AGGREGATION = value; }
        }

        #endregion

        #region Methods
        public void Validate()
        {            
            if (this.NOM_INDICADOR.Length > 254)
            {
                throw new Exception("NOM_INDICADOR debe tener máximo 254 carateres.");
            }

            if (this.FORMULA_USR.Length > 1000)
            {
                throw new Exception("FORMULA_USR debe tener máximo 1000 carateres.");
            }

            if (this.FORMULA_BD.Length > 2147483647)
            {
                throw new Exception("FORMULA_BD debe tener máximo 2147483647 carateres.");
            }

            if (this.NOM_TABLA.Length > 254)
            {
                throw new Exception("NOM_TABLA debe tener máximo 254 carateres.");
            }

            if (this.LLAVES.Length > 254)
            {
                throw new Exception("LLAVES debe tener máximo 254 carateres.");
            }

            if (this.TIPO_AGRUPACION.Length > 15)
            {
                throw new Exception("TIPO_AGRUPACION debe tener máximo 15 carateres.");
            }

            if (this.FORMATO.Length > 30)
            {
                throw new Exception("FORMATO debe tener máximo 30 carateres.");
            }

            if (this.DESCRIPCION.Length > 254)
            {
                throw new Exception("DESCRIPCION debe tener máximo 254 carateres.");
            }

            if (this.TABLAS.Length > 254)
            {
                throw new Exception("TABLAS debe tener máximo 254 carateres.");
            }

            if (this.DONDE.Length > 2147483647)
            {
                throw new Exception("DONDE debe tener máximo 2147483647 carateres.");
            }

            if (this.DIMENSIONES.Length > 500)
            {
                throw new Exception("DIMENSIONES debe tener máximo 500 carateres.");
            }

            if (this.DIM_DEPEND.Length > 255)
            {
                throw new Exception("DIM_DEPEND debe tener máximo 255 carateres.");
            }

            if (this.DIM_ALARM.Length > 255)
            {
                throw new Exception("DIM_ALARM debe tener máximo 255 carateres.");
            }

            if (this.FILTER_SQL.Length > 2147483647)
            {
                throw new Exception("FILTER_SQL debe tener máximo 2147483647 carateres.");
            }

            if (this.NIVELES.Length > 250)
            {
                throw new Exception("NIVELES debe tener máximo 250 carateres.");
            }

            if (this.KPIVALUE.Length > 254)
            {
                throw new Exception("KPIVALUE debe tener máximo 254 carateres.");
            }

            if (this.NONEMPTYBEHAVIOR.Length > 1024)
            {
                throw new Exception("NONEMPTYBEHAVIOR debe tener máximo 1024 carateres.");
            }


        } // End Validate

        public int Create()
        {
            Hashtable m_params = new Hashtable();
            m_params.Add("CLA_INDICADOR", this.CLA_INDICADOR);
            if (!SqlDB.IsNullOrEmpty(this.CLA_CONCEPTO)) m_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            if (!SqlDB.IsNullOrEmpty(this.CLA_PADRE)) m_params.Add("CLA_PADRE", this.CLA_PADRE);
            if (!SqlDB.IsNullOrEmpty(this.NOM_INDICADOR)) m_params.Add("NOM_INDICADOR", this.NOM_INDICADOR);
            if (!SqlDB.IsNullOrEmpty(this.FORMULA_USR)) m_params.Add("FORMULA_USR", this.FORMULA_USR);
            if (!SqlDB.IsNullOrEmpty(this.FORMULA_BD)) m_params.Add("FORMULA_BD", this.FORMULA_BD);
            if (!SqlDB.IsNullOrEmpty(this.NOM_TABLA)) m_params.Add("NOM_TABLA", this.NOM_TABLA);
            if (!SqlDB.IsNullOrEmpty(this.LLAVES)) m_params.Add("LLAVES", this.LLAVES);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_AGRUPACION)) m_params.Add("TIPO_AGRUPACION", this.TIPO_AGRUPACION);
            if (!SqlDB.IsNullOrEmpty(this.FORMATO)) m_params.Add("FORMATO", this.FORMATO);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_INDICADOR)) m_params.Add("TIPO_INDICADOR", this.TIPO_INDICADOR);
            if (!SqlDB.IsNullOrEmpty(this.CLA_USUARIO)) m_params.Add("CLA_USUARIO", this.CLA_USUARIO);
            if (!SqlDB.IsNullOrEmpty(this.REEXPRESADOS)) m_params.Add("REEXPRESADOS", this.REEXPRESADOS);
            if (!SqlDB.IsNullOrEmpty(this.DESCRIPCION)) m_params.Add("DESCRIPCION", this.DESCRIPCION);
            if (!SqlDB.IsNullOrEmpty(this.FILTRO)) m_params.Add("FILTRO", this.FILTRO);
            if (!SqlDB.IsNullOrEmpty(this.PARETTO)) m_params.Add("PARETTO", this.PARETTO);
            if (!SqlDB.IsNullOrEmpty(this.TABLAS)) m_params.Add("TABLAS", this.TABLAS);
            if (!SqlDB.IsNullOrEmpty(this.DONDE)) m_params.Add("DONDE", this.DONDE);
            if (!SqlDB.IsNullOrEmpty(this.DIMENSIONES)) m_params.Add("DIMENSIONES", this.DIMENSIONES);
            if (!SqlDB.IsNullOrEmpty(this.NO_EJECUTIVO)) m_params.Add("NO_EJECUTIVO", this.NO_EJECUTIVO);
            if (!SqlDB.IsNullOrEmpty(this.ES_ATRIBUTO)) m_params.Add("ES_ATRIBUTO", this.ES_ATRIBUTO);
            if (!SqlDB.IsNullOrEmpty(this.NIVEL_JERARQUIA)) m_params.Add("NIVEL_JERARQUIA", this.NIVEL_JERARQUIA);
            if (!SqlDB.IsNullOrEmpty(this.ES_DIVISOR)) m_params.Add("ES_DIVISOR", this.ES_DIVISOR);
            if (!SqlDB.IsNullOrEmpty(this.DIM_DEPEND)) m_params.Add("DIM_DEPEND", this.DIM_DEPEND);
            if (!SqlDB.IsNullOrEmpty(this.DIM_ALARM)) m_params.Add("DIM_ALARM", this.DIM_ALARM);
            if (!SqlDB.IsNullOrEmpty(this.ACTUAL)) m_params.Add("ACTUAL", this.ACTUAL);
            if (!SqlDB.IsNullOrEmpty(this.CLA_PERIODO)) m_params.Add("CLA_PERIODO", this.CLA_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.DECREMENTAL)) m_params.Add("DECREMENTAL", this.DECREMENTAL);
            if (!SqlDB.IsNullOrEmpty(this.ID_CPTO_ATRIB)) m_params.Add("ID_CPTO_ATRIB", this.ID_CPTO_ATRIB);
            if (!SqlDB.IsNullOrEmpty(this.CLA_OWNER)) m_params.Add("CLA_OWNER", this.CLA_OWNER);
            if (!SqlDB.IsNullOrEmpty(this.FILTER_SQL)) m_params.Add("FILTER_SQL", this.FILTER_SQL);
            if (!SqlDB.IsNullOrEmpty(this.NIVELES)) m_params.Add("NIVELES", this.NIVELES);
            if (!SqlDB.IsNullOrEmpty(this.KPIVALUE)) m_params.Add("KPIVALUE", this.KPIVALUE);
            if (!SqlDB.IsNullOrEmpty(this.ONLY_LAST_PERIOD)) m_params.Add("ONLY_LAST_PERIOD", this.ONLY_LAST_PERIOD);
            if (!SqlDB.IsNullOrEmpty(this.NOTNUMERIC)) m_params.Add("NOTNUMERIC", this.NOTNUMERIC);
            if (!SqlDB.IsNullOrEmpty(this.NONEMPTYBEHAVIOR)) m_params.Add("NONEMPTYBEHAVIOR", this.NONEMPTYBEHAVIOR);
            if (!SqlDB.IsNullOrEmpty(this.IN_AGGREGATION)) m_params.Add("IN_AGGREGATION", this.IN_AGGREGATION);

            return SqlDB.Insert("SI_INDICADOR", m_params);
        } // End Create

        public List<SI_INDICADOR> Read()
        {
            List<SI_INDICADOR> list = new List<SI_INDICADOR>();
            DataTable dt = SqlDB.Select("SI_INDICADOR");
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new SI_INDICADOR(
                        Convert.ToInt32(dr["CLA_INDICADOR"]),
                        SqlDB.GetNullableInt32(dr["CLA_CONCEPTO"]),
                        SqlDB.GetNullableInt32(dr["CLA_PADRE"]),
                        Convert.ToString(dr["NOM_INDICADOR"]),
                        Convert.ToString(dr["FORMULA_USR"]),
                        Convert.ToString(dr["FORMULA_BD"]),
                        Convert.ToString(dr["NOM_TABLA"]),
                        Convert.ToString(dr["LLAVES"]),
                        Convert.ToString(dr["TIPO_AGRUPACION"]),
                        Convert.ToString(dr["FORMATO"]),
                        SqlDB.GetNullableInt32(dr["TIPO_INDICADOR"]),
                        SqlDB.GetNullableInt32(dr["CLA_USUARIO"]),
                        SqlDB.GetNullableInt32(dr["REEXPRESADOS"]),
                        Convert.ToString(dr["DESCRIPCION"]),
                        SqlDB.GetNullableInt16(dr["FILTRO"]),
                        SqlDB.GetNullableInt16(dr["PARETTO"]),
                        Convert.ToString(dr["TABLAS"]),
                        Convert.ToString(dr["DONDE"]),
                        Convert.ToString(dr["DIMENSIONES"]),
                        SqlDB.GetNullableInt32(dr["NO_EJECUTIVO"]),
                        SqlDB.GetNullableInt32(dr["ES_ATRIBUTO"]),
                        SqlDB.GetNullableInt32(dr["NIVEL_JERARQUIA"]),
                        SqlDB.GetNullableInt32(dr["ES_DIVISOR"]),
                        Convert.ToString(dr["DIM_DEPEND"]),
                        Convert.ToString(dr["DIM_ALARM"]),
                        SqlDB.GetNullableInt32(dr["ACTUAL"]),
                        SqlDB.GetNullableInt32(dr["CLA_PERIODO"]),
                        SqlDB.GetNullableInt32(dr["DECREMENTAL"]),
                        SqlDB.GetNullableInt32(dr["ID_CPTO_ATRIB"]),
                        SqlDB.GetNullableInt32(dr["CLA_OWNER"]),
                        Convert.ToString(dr["FILTER_SQL"]),
                        Convert.ToString(dr["NIVELES"]),
                        Convert.ToString(dr["KPIVALUE"]),
                        SqlDB.GetNullableInt32(dr["ONLY_LAST_PERIOD"]),
                        SqlDB.GetNullableInt32(dr["NOTNUMERIC"]),
                        Convert.ToString(dr["NONEMPTYBEHAVIOR"]),
                        SqlDB.GetNullableInt32(dr["IN_AGGREGATION"])
                    )
                );
            }

            return list;
        } // End Read

        public SI_INDICADOR Read(int cla_indicador)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_INDICADOR", cla_indicador);
            DataTable dt = SqlDB.Select("SI_INDICADOR", w_params);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("No existe SI_INDICADOR con los criterios de búsqueda especificados.");
            }
            DataRow dr = dt.Rows[0];
            return new SI_INDICADOR(
                Convert.ToInt32(dr["CLA_INDICADOR"]),
                        SqlDB.GetNullableInt32(dr["CLA_CONCEPTO"]),
                        SqlDB.GetNullableInt32(dr["CLA_PADRE"]),
                        Convert.ToString(dr["NOM_INDICADOR"]),
                        Convert.ToString(dr["FORMULA_USR"]),
                        Convert.ToString(dr["FORMULA_BD"]),
                        Convert.ToString(dr["NOM_TABLA"]),
                        Convert.ToString(dr["LLAVES"]),
                        Convert.ToString(dr["TIPO_AGRUPACION"]),
                        Convert.ToString(dr["FORMATO"]),
                        SqlDB.GetNullableInt32(dr["TIPO_INDICADOR"]),
                        SqlDB.GetNullableInt32(dr["CLA_USUARIO"]),
                        SqlDB.GetNullableInt32(dr["REEXPRESADOS"]),
                        Convert.ToString(dr["DESCRIPCION"]),
                        SqlDB.GetNullableInt16(dr["FILTRO"]),
                        SqlDB.GetNullableInt16(dr["PARETTO"]),
                        Convert.ToString(dr["TABLAS"]),
                        Convert.ToString(dr["DONDE"]),
                        Convert.ToString(dr["DIMENSIONES"]),
                        SqlDB.GetNullableInt32(dr["NO_EJECUTIVO"]),
                        SqlDB.GetNullableInt32(dr["ES_ATRIBUTO"]),
                        SqlDB.GetNullableInt32(dr["NIVEL_JERARQUIA"]),
                        SqlDB.GetNullableInt32(dr["ES_DIVISOR"]),
                        Convert.ToString(dr["DIM_DEPEND"]),
                        Convert.ToString(dr["DIM_ALARM"]),
                        SqlDB.GetNullableInt32(dr["ACTUAL"]),
                        SqlDB.GetNullableInt32(dr["CLA_PERIODO"]),
                        SqlDB.GetNullableInt32(dr["DECREMENTAL"]),
                        SqlDB.GetNullableInt32(dr["ID_CPTO_ATRIB"]),
                        SqlDB.GetNullableInt32(dr["CLA_OWNER"]),
                        Convert.ToString(dr["FILTER_SQL"]),
                        Convert.ToString(dr["NIVELES"]),
                        Convert.ToString(dr["KPIVALUE"]),
                        SqlDB.GetNullableInt32(dr["ONLY_LAST_PERIOD"]),
                        SqlDB.GetNullableInt32(dr["NOTNUMERIC"]),
                        Convert.ToString(dr["NONEMPTYBEHAVIOR"]),
                        SqlDB.GetNullableInt32(dr["IN_AGGREGATION"])
                    );
        } // End Read

        public DataTable ReadDataTable()
        {
            return SqlDB.Select("SI_INDICADOR");
        } // End Read

        public DataTable ReadDataTable(int cla_indicador)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_INDICADOR", cla_indicador);
            return SqlDB.Select("SI_INDICADOR", w_params);
        } // End Read

        public int Update()
        {
            Hashtable m_params = new Hashtable();
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_INDICADOR", this.CLA_INDICADOR);
            if (!SqlDB.IsNullOrEmpty(this.CLA_CONCEPTO)) m_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            if (!SqlDB.IsNullOrEmpty(this.CLA_PADRE)) m_params.Add("CLA_PADRE", this.CLA_PADRE);
            if (!SqlDB.IsNullOrEmpty(this.NOM_INDICADOR)) m_params.Add("NOM_INDICADOR", this.NOM_INDICADOR);
            if (!SqlDB.IsNullOrEmpty(this.FORMULA_USR)) m_params.Add("FORMULA_USR", this.FORMULA_USR);
            if (!SqlDB.IsNullOrEmpty(this.FORMULA_BD)) m_params.Add("FORMULA_BD", this.FORMULA_BD);
            if (!SqlDB.IsNullOrEmpty(this.NOM_TABLA)) m_params.Add("NOM_TABLA", this.NOM_TABLA);
            if (!SqlDB.IsNullOrEmpty(this.LLAVES)) m_params.Add("LLAVES", this.LLAVES);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_AGRUPACION)) m_params.Add("TIPO_AGRUPACION", this.TIPO_AGRUPACION);
            if (!SqlDB.IsNullOrEmpty(this.FORMATO)) m_params.Add("FORMATO", this.FORMATO);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_INDICADOR)) m_params.Add("TIPO_INDICADOR", this.TIPO_INDICADOR);
            if (!SqlDB.IsNullOrEmpty(this.CLA_USUARIO)) m_params.Add("CLA_USUARIO", this.CLA_USUARIO);
            if (!SqlDB.IsNullOrEmpty(this.REEXPRESADOS)) m_params.Add("REEXPRESADOS", this.REEXPRESADOS);
            if (!SqlDB.IsNullOrEmpty(this.DESCRIPCION)) m_params.Add("DESCRIPCION", this.DESCRIPCION);
            if (!SqlDB.IsNullOrEmpty(this.FILTRO)) m_params.Add("FILTRO", this.FILTRO);
            if (!SqlDB.IsNullOrEmpty(this.PARETTO)) m_params.Add("PARETTO", this.PARETTO);
            if (!SqlDB.IsNullOrEmpty(this.TABLAS)) m_params.Add("TABLAS", this.TABLAS);
            if (!SqlDB.IsNullOrEmpty(this.DONDE)) m_params.Add("DONDE", this.DONDE);
            if (!SqlDB.IsNullOrEmpty(this.DIMENSIONES)) m_params.Add("DIMENSIONES", this.DIMENSIONES);
            if (!SqlDB.IsNullOrEmpty(this.NO_EJECUTIVO)) m_params.Add("NO_EJECUTIVO", this.NO_EJECUTIVO);
            if (!SqlDB.IsNullOrEmpty(this.ES_ATRIBUTO)) m_params.Add("ES_ATRIBUTO", this.ES_ATRIBUTO);
            if (!SqlDB.IsNullOrEmpty(this.NIVEL_JERARQUIA)) m_params.Add("NIVEL_JERARQUIA", this.NIVEL_JERARQUIA);
            if (!SqlDB.IsNullOrEmpty(this.ES_DIVISOR)) m_params.Add("ES_DIVISOR", this.ES_DIVISOR);
            if (!SqlDB.IsNullOrEmpty(this.DIM_DEPEND)) m_params.Add("DIM_DEPEND", this.DIM_DEPEND);
            if (!SqlDB.IsNullOrEmpty(this.DIM_ALARM)) m_params.Add("DIM_ALARM", this.DIM_ALARM);
            if (!SqlDB.IsNullOrEmpty(this.ACTUAL)) m_params.Add("ACTUAL", this.ACTUAL);
            if (!SqlDB.IsNullOrEmpty(this.CLA_PERIODO)) m_params.Add("CLA_PERIODO", this.CLA_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.DECREMENTAL)) m_params.Add("DECREMENTAL", this.DECREMENTAL);
            if (!SqlDB.IsNullOrEmpty(this.ID_CPTO_ATRIB)) m_params.Add("ID_CPTO_ATRIB", this.ID_CPTO_ATRIB);
            if (!SqlDB.IsNullOrEmpty(this.CLA_OWNER)) m_params.Add("CLA_OWNER", this.CLA_OWNER);
            if (!SqlDB.IsNullOrEmpty(this.FILTER_SQL)) m_params.Add("FILTER_SQL", this.FILTER_SQL);
            if (!SqlDB.IsNullOrEmpty(this.NIVELES)) m_params.Add("NIVELES", this.NIVELES);
            if (!SqlDB.IsNullOrEmpty(this.KPIVALUE)) m_params.Add("KPIVALUE", this.KPIVALUE);
            if (!SqlDB.IsNullOrEmpty(this.ONLY_LAST_PERIOD)) m_params.Add("ONLY_LAST_PERIOD", this.ONLY_LAST_PERIOD);
            if (!SqlDB.IsNullOrEmpty(this.NOTNUMERIC)) m_params.Add("NOTNUMERIC", this.NOTNUMERIC);
            if (!SqlDB.IsNullOrEmpty(this.NONEMPTYBEHAVIOR)) m_params.Add("NONEMPTYBEHAVIOR", this.NONEMPTYBEHAVIOR);
            if (!SqlDB.IsNullOrEmpty(this.IN_AGGREGATION)) m_params.Add("IN_AGGREGATION", this.IN_AGGREGATION);

            return SqlDB.Update("SI_INDICADOR", m_params, w_params);
        } // End Update

        public int Delete()
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_INDICADOR", this.CLA_INDICADOR);

            return SqlDB.Delete("SI_INDICADOR", w_params);
        } // End Delete


        #endregion
    } //End Class SI_INDICADOR
}
