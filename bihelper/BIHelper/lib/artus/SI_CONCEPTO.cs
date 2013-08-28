using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Representa la tabla SI_CONCEPTO de la base de datos de metadata de Artus
    /// </summary>
    public class SI_CONCEPTO
    {

        #region Constructors

        public SI_CONCEPTO()
        {            
        }

        public SI_CONCEPTO(
            int cla_concepto,
            int? estatus,
            string nom_concepto,
            string nom_tabla,
            string llaves,
            string fecha,
            int? capturable,
            int? tipo_cubo,
            int? cla_bd,
            string dim_periodo,
            string servidor,
            string catalogo_olap,
            string usuario,
            string password,
            string fmt_periodo,
            string fmt_fecha,
            string measuredef,
            int? reg_settings,
            int? usa_agregacion,
            int? usa_sinperiodo,
            int? show_alias,
            int? use_cache,
            int? dim_locale,
            int? dim_unicode,
            string dim_font,
            int? cla_conexion_sync,
            int? cla_cubo_sync,
            int? indicator_inpc,
            int? cla_owner,
            int? no_nulls,
            int? no_zeros,
            int? date_key,
            int? ag_new,
            int? tipo_conn,
            string service_name,
            string database_name,
            int? ldapsecurity,
            int? ri_definition,
            int? oledbprovider,
            int? config_cache)
        {
            this.CLA_CONCEPTO = cla_concepto;
            this.ESTATUS = estatus;
            this.NOM_CONCEPTO = nom_concepto;
            this.NOM_TABLA = nom_tabla;
            this.LLAVES = llaves;
            this.FECHA = fecha;
            this.CAPTURABLE = capturable;
            this.TIPO_CUBO = tipo_cubo;
            this.CLA_BD = cla_bd;
            this.DIM_PERIODO = dim_periodo;
            this.SERVIDOR = servidor;
            this.CATALOGO_OLAP = catalogo_olap;
            this.USUARIO = usuario;
            this.PASSWORD = password;
            this.FMT_PERIODO = fmt_periodo;
            this.FMT_FECHA = fmt_fecha;
            this.MEASUREDEF = measuredef;
            this.REG_SETTINGS = reg_settings;
            this.USA_AGREGACION = usa_agregacion;
            this.USA_SINPERIODO = usa_sinperiodo;
            this.SHOW_ALIAS = show_alias;
            this.USE_CACHE = use_cache;
            this.DIM_LOCALE = dim_locale;
            this.DIM_UNICODE = dim_unicode;
            this.DIM_FONT = dim_font;
            this.CLA_CONEXION_SYNC = cla_conexion_sync;
            this.CLA_CUBO_SYNC = cla_cubo_sync;
            this.INDICATOR_INPC = indicator_inpc;
            this.CLA_OWNER = cla_owner;
            this.NO_NULLS = no_nulls;
            this.NO_ZEROS = no_zeros;
            this.DATE_KEY = date_key;
            this.AG_NEW = ag_new;
            this.TIPO_CONN = tipo_conn;
            this.SERVICE_NAME = service_name;
            this.DATABASE_NAME = database_name;
            this.LDAPSECURITY = ldapsecurity;
            this.RI_DEFINITION = ri_definition;
            this.OLEDBPROVIDER = oledbprovider;
            this.CONFIG_CACHE = config_cache;
        }

        #endregion

        #region Properties

        /// <summary>
        /// La instancia de conexión a Sql Server
        /// </summary>
        public lib.SqlServerHelper SqlDB { get; set; }

        private int _CLA_CONCEPTO;
        public int CLA_CONCEPTO
        {
            get { return _CLA_CONCEPTO; }
            set { _CLA_CONCEPTO = value; }
        }

        private int? _ESTATUS;
        public int? ESTATUS
        {
            get { return _ESTATUS; }
            set { _ESTATUS = value; }
        }

        private string _NOM_CONCEPTO;
        public string NOM_CONCEPTO
        {
            get { return _NOM_CONCEPTO; }
            set { _NOM_CONCEPTO = value; }
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

        private string _FECHA;
        public string FECHA
        {
            get { return _FECHA; }
            set { _FECHA = value; }
        }

        private int? _CAPTURABLE;
        public int? CAPTURABLE
        {
            get { return _CAPTURABLE; }
            set { _CAPTURABLE = value; }
        }

        private int? _TIPO_CUBO;
        public int? TIPO_CUBO
        {
            get { return _TIPO_CUBO; }
            set { _TIPO_CUBO = value; }
        }

        private int? _CLA_BD;
        public int? CLA_BD
        {
            get { return _CLA_BD; }
            set { _CLA_BD = value; }
        }

        private string _DIM_PERIODO;
        public string DIM_PERIODO
        {
            get { return _DIM_PERIODO; }
            set { _DIM_PERIODO = value; }
        }

        private string _SERVIDOR;
        public string SERVIDOR
        {
            get { return _SERVIDOR; }
            set { _SERVIDOR = value; }
        }

        private string _CATALOGO_OLAP;
        public string CATALOGO_OLAP
        {
            get { return _CATALOGO_OLAP; }
            set { _CATALOGO_OLAP = value; }
        }

        private string _USUARIO;
        public string USUARIO
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }

        private string _PASSWORD;
        public string PASSWORD
        {
            get { return _PASSWORD; }
            set { _PASSWORD = value; }
        }

        private string _FMT_PERIODO;
        public string FMT_PERIODO
        {
            get { return _FMT_PERIODO; }
            set { _FMT_PERIODO = value; }
        }

        private string _FMT_FECHA;
        public string FMT_FECHA
        {
            get { return _FMT_FECHA; }
            set { _FMT_FECHA = value; }
        }

        private string _MEASUREDEF;
        public string MEASUREDEF
        {
            get { return _MEASUREDEF; }
            set { _MEASUREDEF = value; }
        }

        private int? _REG_SETTINGS;
        public int? REG_SETTINGS
        {
            get { return _REG_SETTINGS; }
            set { _REG_SETTINGS = value; }
        }

        private int? _USA_AGREGACION;
        public int? USA_AGREGACION
        {
            get { return _USA_AGREGACION; }
            set { _USA_AGREGACION = value; }
        }

        private int? _USA_SINPERIODO;
        public int? USA_SINPERIODO
        {
            get { return _USA_SINPERIODO; }
            set { _USA_SINPERIODO = value; }
        }

        private int? _SHOW_ALIAS;
        public int? SHOW_ALIAS
        {
            get { return _SHOW_ALIAS; }
            set { _SHOW_ALIAS = value; }
        }

        private int? _USE_CACHE;
        public int? USE_CACHE
        {
            get { return _USE_CACHE; }
            set { _USE_CACHE = value; }
        }

        private int? _DIM_LOCALE;
        public int? DIM_LOCALE
        {
            get { return _DIM_LOCALE; }
            set { _DIM_LOCALE = value; }
        }

        private int? _DIM_UNICODE;
        public int? DIM_UNICODE
        {
            get { return _DIM_UNICODE; }
            set { _DIM_UNICODE = value; }
        }

        private string _DIM_FONT;
        public string DIM_FONT
        {
            get { return _DIM_FONT; }
            set { _DIM_FONT = value; }
        }

        private int? _CLA_CONEXION_SYNC;
        public int? CLA_CONEXION_SYNC
        {
            get { return _CLA_CONEXION_SYNC; }
            set { _CLA_CONEXION_SYNC = value; }
        }

        private int? _CLA_CUBO_SYNC;
        public int? CLA_CUBO_SYNC
        {
            get { return _CLA_CUBO_SYNC; }
            set { _CLA_CUBO_SYNC = value; }
        }

        private int? _INDICATOR_INPC;
        public int? INDICATOR_INPC
        {
            get { return _INDICATOR_INPC; }
            set { _INDICATOR_INPC = value; }
        }

        private int? _CLA_OWNER;
        public int? CLA_OWNER
        {
            get { return _CLA_OWNER; }
            set { _CLA_OWNER = value; }
        }

        private int? _NO_NULLS;
        public int? NO_NULLS
        {
            get { return _NO_NULLS; }
            set { _NO_NULLS = value; }
        }

        private int? _NO_ZEROS;
        public int? NO_ZEROS
        {
            get { return _NO_ZEROS; }
            set { _NO_ZEROS = value; }
        }

        private int? _DATE_KEY;
        public int? DATE_KEY
        {
            get { return _DATE_KEY; }
            set { _DATE_KEY = value; }
        }

        private int? _AG_NEW;
        public int? AG_NEW
        {
            get { return _AG_NEW; }
            set { _AG_NEW = value; }
        }

        private int? _TIPO_CONN;
        public int? TIPO_CONN
        {
            get { return _TIPO_CONN; }
            set { _TIPO_CONN = value; }
        }

        private string _SERVICE_NAME;
        public string SERVICE_NAME
        {
            get { return _SERVICE_NAME; }
            set { _SERVICE_NAME = value; }
        }

        private string _DATABASE_NAME;
        public string DATABASE_NAME
        {
            get { return _DATABASE_NAME; }
            set { _DATABASE_NAME = value; }
        }

        private int? _LDAPSECURITY;
        public int? LDAPSECURITY
        {
            get { return _LDAPSECURITY; }
            set { _LDAPSECURITY = value; }
        }

        private int? _RI_DEFINITION;
        public int? RI_DEFINITION
        {
            get { return _RI_DEFINITION; }
            set { _RI_DEFINITION = value; }
        }

        private int? _OLEDBPROVIDER;
        public int? OLEDBPROVIDER
        {
            get { return _OLEDBPROVIDER; }
            set { _OLEDBPROVIDER = value; }
        }

        private int? _CONFIG_CACHE;
        public int? CONFIG_CACHE
        {
            get { return _CONFIG_CACHE; }
            set { _CONFIG_CACHE = value; }
        }

        #endregion

        #region Methods
        public void Validate()
        {            
            if (this.NOM_CONCEPTO.Length > 100)
            {
                throw new Exception("NOM_CONCEPTO debe tener máximo 100 carateres.");
            }

            if (this.NOM_TABLA.Length > 100)
            {
                throw new Exception("NOM_TABLA debe tener máximo 100 carateres.");
            }

            if (this.LLAVES.Length > 2147483647)
            {
                throw new Exception("LLAVES debe tener máximo 2147483647 carateres.");
            }

            if (this.FECHA.Length > 100)
            {
                throw new Exception("FECHA debe tener máximo 100 carateres.");
            }

            if (this.DIM_PERIODO.Length > 60)
            {
                throw new Exception("DIM_PERIODO debe tener máximo 60 carateres.");
            }

            if (this.SERVIDOR.Length > 60)
            {
                throw new Exception("SERVIDOR debe tener máximo 60 carateres.");
            }

            if (this.CATALOGO_OLAP.Length > 60)
            {
                throw new Exception("CATALOGO_OLAP debe tener máximo 60 carateres.");
            }

            if (this.USUARIO.Length > 60)
            {
                throw new Exception("USUARIO debe tener máximo 60 carateres.");
            }

            if (this.PASSWORD.Length > 60)
            {
                throw new Exception("PASSWORD debe tener máximo 60 carateres.");
            }

            if (this.FMT_PERIODO.Length > 60)
            {
                throw new Exception("FMT_PERIODO debe tener máximo 60 carateres.");
            }

            if (this.FMT_FECHA.Length > 60)
            {
                throw new Exception("FMT_FECHA debe tener máximo 60 carateres.");
            }

            if (this.MEASUREDEF.Length > 250)
            {
                throw new Exception("MEASUREDEF debe tener máximo 250 carateres.");
            }

            if (this.DIM_FONT.Length > 30)
            {
                throw new Exception("DIM_FONT debe tener máximo 30 carateres.");
            }

            if (this.SERVICE_NAME.Length > 255)
            {
                throw new Exception("SERVICE_NAME debe tener máximo 255 carateres.");
            }

            if (this.DATABASE_NAME.Length > 255)
            {
                throw new Exception("DATABASE_NAME debe tener máximo 255 carateres.");
            }


        } // End Validate

        public int Create()
        {
            Hashtable m_params = new Hashtable();
            m_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            if (!SqlDB.IsNullOrEmpty(this.ESTATUS)) m_params.Add("ESTATUS", this.ESTATUS);
            if (!SqlDB.IsNullOrEmpty(this.NOM_CONCEPTO)) m_params.Add("NOM_CONCEPTO", this.NOM_CONCEPTO);
            if (!SqlDB.IsNullOrEmpty(this.NOM_TABLA)) m_params.Add("NOM_TABLA", this.NOM_TABLA);
            if (!SqlDB.IsNullOrEmpty(this.LLAVES)) m_params.Add("LLAVES", this.LLAVES);
            if (!SqlDB.IsNullOrEmpty(this.FECHA)) m_params.Add("FECHA", this.FECHA);
            if (!SqlDB.IsNullOrEmpty(this.CAPTURABLE)) m_params.Add("CAPTURABLE", this.CAPTURABLE);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_CUBO)) m_params.Add("TIPO_CUBO", this.TIPO_CUBO);
            if (!SqlDB.IsNullOrEmpty(this.CLA_BD)) m_params.Add("CLA_BD", this.CLA_BD);
            if (!SqlDB.IsNullOrEmpty(this.DIM_PERIODO)) m_params.Add("DIM_PERIODO", this.DIM_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.SERVIDOR)) m_params.Add("SERVIDOR", this.SERVIDOR);
            if (!SqlDB.IsNullOrEmpty(this.CATALOGO_OLAP)) m_params.Add("CATALOGO_OLAP", this.CATALOGO_OLAP);
            if (!SqlDB.IsNullOrEmpty(this.USUARIO)) m_params.Add("USUARIO", this.USUARIO);
            if (!SqlDB.IsNullOrEmpty(this.PASSWORD)) m_params.Add("PASSWORD", this.PASSWORD);
            if (!SqlDB.IsNullOrEmpty(this.FMT_PERIODO)) m_params.Add("FMT_PERIODO", this.FMT_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.FMT_FECHA)) m_params.Add("FMT_FECHA", this.FMT_FECHA);
            if (!SqlDB.IsNullOrEmpty(this.MEASUREDEF)) m_params.Add("MEASUREDEF", this.MEASUREDEF);
            if (!SqlDB.IsNullOrEmpty(this.REG_SETTINGS)) m_params.Add("REG_SETTINGS", this.REG_SETTINGS);
            if (!SqlDB.IsNullOrEmpty(this.USA_AGREGACION)) m_params.Add("USA_AGREGACION", this.USA_AGREGACION);
            if (!SqlDB.IsNullOrEmpty(this.USA_SINPERIODO)) m_params.Add("USA_SINPERIODO", this.USA_SINPERIODO);
            if (!SqlDB.IsNullOrEmpty(this.SHOW_ALIAS)) m_params.Add("SHOW_ALIAS", this.SHOW_ALIAS);
            if (!SqlDB.IsNullOrEmpty(this.USE_CACHE)) m_params.Add("USE_CACHE", this.USE_CACHE);
            if (!SqlDB.IsNullOrEmpty(this.DIM_LOCALE)) m_params.Add("DIM_LOCALE", this.DIM_LOCALE);
            if (!SqlDB.IsNullOrEmpty(this.DIM_UNICODE)) m_params.Add("DIM_UNICODE", this.DIM_UNICODE);
            if (!SqlDB.IsNullOrEmpty(this.DIM_FONT)) m_params.Add("DIM_FONT", this.DIM_FONT);
            if (!SqlDB.IsNullOrEmpty(this.CLA_CONEXION_SYNC)) m_params.Add("CLA_CONEXION_SYNC", this.CLA_CONEXION_SYNC);
            if (!SqlDB.IsNullOrEmpty(this.CLA_CUBO_SYNC)) m_params.Add("CLA_CUBO_SYNC", this.CLA_CUBO_SYNC);
            if (!SqlDB.IsNullOrEmpty(this.INDICATOR_INPC)) m_params.Add("INDICATOR_INPC", this.INDICATOR_INPC);
            if (!SqlDB.IsNullOrEmpty(this.CLA_OWNER)) m_params.Add("CLA_OWNER", this.CLA_OWNER);
            if (!SqlDB.IsNullOrEmpty(this.NO_NULLS)) m_params.Add("NO_NULLS", this.NO_NULLS);
            if (!SqlDB.IsNullOrEmpty(this.NO_ZEROS)) m_params.Add("NO_ZEROS", this.NO_ZEROS);
            if (!SqlDB.IsNullOrEmpty(this.DATE_KEY)) m_params.Add("DATE_KEY", this.DATE_KEY);
            if (!SqlDB.IsNullOrEmpty(this.AG_NEW)) m_params.Add("AG_NEW", this.AG_NEW);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_CONN)) m_params.Add("TIPO_CONN", this.TIPO_CONN);
            if (!SqlDB.IsNullOrEmpty(this.SERVICE_NAME)) m_params.Add("SERVICE_NAME", this.SERVICE_NAME);
            if (!SqlDB.IsNullOrEmpty(this.DATABASE_NAME)) m_params.Add("DATABASE_NAME", this.DATABASE_NAME);
            if (!SqlDB.IsNullOrEmpty(this.LDAPSECURITY)) m_params.Add("LDAPSECURITY", this.LDAPSECURITY);
            if (!SqlDB.IsNullOrEmpty(this.RI_DEFINITION)) m_params.Add("RI_DEFINITION", this.RI_DEFINITION);
            if (!SqlDB.IsNullOrEmpty(this.OLEDBPROVIDER)) m_params.Add("OLEDBPROVIDER", this.OLEDBPROVIDER);
            if (!SqlDB.IsNullOrEmpty(this.CONFIG_CACHE)) m_params.Add("CONFIG_CACHE", this.CONFIG_CACHE);

            return SqlDB.Insert("SI_CONCEPTO", m_params);
        } // End Create

        public  List<SI_CONCEPTO> Read()
        { 
            List<SI_CONCEPTO> list = new List<SI_CONCEPTO>();
            DataTable dt = SqlDB.Select("SI_CONCEPTO", null, "NOM_CONCEPTO");
            
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new SI_CONCEPTO(
                        Convert.ToInt32(dr["CLA_CONCEPTO"]),
                        SqlDB.GetNullableInt32(dr["ESTATUS"]),
                        Convert.ToString(dr["NOM_CONCEPTO"]),
                        Convert.ToString(dr["NOM_TABLA"]),
                        Convert.ToString(dr["LLAVES"]),
                        Convert.ToString(dr["FECHA"]),
                        SqlDB.GetNullableInt32(dr["CAPTURABLE"]),
                        SqlDB.GetNullableInt32(dr["TIPO_CUBO"]),
                        SqlDB.GetNullableInt32(dr["CLA_BD"]),
                        Convert.ToString(dr["DIM_PERIODO"]),
                        Convert.ToString(dr["SERVIDOR"]),
                        Convert.ToString(dr["CATALOGO_OLAP"]),
                        Convert.ToString(dr["USUARIO"]),
                        Convert.ToString(dr["PASSWORD"]),
                        Convert.ToString(dr["FMT_PERIODO"]),
                        Convert.ToString(dr["FMT_FECHA"]),
                        Convert.ToString(dr["MEASUREDEF"]),
                        SqlDB.GetNullableInt32(dr["REG_SETTINGS"]),
                        SqlDB.GetNullableInt32(dr["USA_AGREGACION"]),
                        SqlDB.GetNullableInt32(dr["USA_SINPERIODO"]),
                        SqlDB.GetNullableInt32(dr["SHOW_ALIAS"]),
                        SqlDB.GetNullableInt32(dr["USE_CACHE"]),
                        SqlDB.GetNullableInt32(dr["DIM_LOCALE"]),
                        SqlDB.GetNullableInt32(dr["DIM_UNICODE"]),
                        Convert.ToString(dr["DIM_FONT"]),
                        SqlDB.GetNullableInt32(dr["CLA_CONEXION_SYNC"]),
                        SqlDB.GetNullableInt32(dr["CLA_CUBO_SYNC"]),
                        SqlDB.GetNullableInt32(dr["INDICATOR_INPC"]),
                        SqlDB.GetNullableInt32(dr["CLA_OWNER"]),
                        SqlDB.GetNullableInt32(dr["NO_NULLS"]),
                        SqlDB.GetNullableInt32(dr["NO_ZEROS"]),
                        SqlDB.GetNullableInt32(dr["DATE_KEY"]),
                        SqlDB.GetNullableInt32(dr["AG_NEW"]),
                        SqlDB.GetNullableInt32(dr["TIPO_CONN"]),
                        Convert.ToString(dr["SERVICE_NAME"]),
                        Convert.ToString(dr["DATABASE_NAME"]),
                        SqlDB.GetNullableInt32(dr["LDAPSECURITY"]),
                        SqlDB.GetNullableInt32(dr["RI_DEFINITION"]),
                        SqlDB.GetNullableInt32(dr["OLEDBPROVIDER"]),
                        SqlDB.GetNullableInt32(dr["CONFIG_CACHE"])
                    )
                );
            }

            return list;
        } // End Read

        public  SI_CONCEPTO Read(int cla_concepto)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", cla_concepto);
            DataTable dt = SqlDB.Select("SI_CONCEPTO", w_params);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("No existe SI_CONCEPTO con los criterios de búsqueda especificados.");
            }
            DataRow dr = dt.Rows[0];
            return new SI_CONCEPTO(
                Convert.ToInt32(dr["CLA_CONCEPTO"]),
                        SqlDB.GetNullableInt32(dr["ESTATUS"]),
                        Convert.ToString(dr["NOM_CONCEPTO"]),
                        Convert.ToString(dr["NOM_TABLA"]),
                        Convert.ToString(dr["LLAVES"]),
                        Convert.ToString(dr["FECHA"]),
                        SqlDB.GetNullableInt32(dr["CAPTURABLE"]),
                        SqlDB.GetNullableInt32(dr["TIPO_CUBO"]),
                        SqlDB.GetNullableInt32(dr["CLA_BD"]),
                        Convert.ToString(dr["DIM_PERIODO"]),
                        Convert.ToString(dr["SERVIDOR"]),
                        Convert.ToString(dr["CATALOGO_OLAP"]),
                        Convert.ToString(dr["USUARIO"]),
                        Convert.ToString(dr["PASSWORD"]),
                        Convert.ToString(dr["FMT_PERIODO"]),
                        Convert.ToString(dr["FMT_FECHA"]),
                        Convert.ToString(dr["MEASUREDEF"]),
                        SqlDB.GetNullableInt32(dr["REG_SETTINGS"]),
                        SqlDB.GetNullableInt32(dr["USA_AGREGACION"]),
                        SqlDB.GetNullableInt32(dr["USA_SINPERIODO"]),
                        SqlDB.GetNullableInt32(dr["SHOW_ALIAS"]),
                        SqlDB.GetNullableInt32(dr["USE_CACHE"]),
                        SqlDB.GetNullableInt32(dr["DIM_LOCALE"]),
                        SqlDB.GetNullableInt32(dr["DIM_UNICODE"]),
                        Convert.ToString(dr["DIM_FONT"]),
                        SqlDB.GetNullableInt32(dr["CLA_CONEXION_SYNC"]),
                        SqlDB.GetNullableInt32(dr["CLA_CUBO_SYNC"]),
                        SqlDB.GetNullableInt32(dr["INDICATOR_INPC"]),
                        SqlDB.GetNullableInt32(dr["CLA_OWNER"]),
                        SqlDB.GetNullableInt32(dr["NO_NULLS"]),
                        SqlDB.GetNullableInt32(dr["NO_ZEROS"]),
                        SqlDB.GetNullableInt32(dr["DATE_KEY"]),
                        SqlDB.GetNullableInt32(dr["AG_NEW"]),
                        SqlDB.GetNullableInt32(dr["TIPO_CONN"]),
                        Convert.ToString(dr["SERVICE_NAME"]),
                        Convert.ToString(dr["DATABASE_NAME"]),
                        SqlDB.GetNullableInt32(dr["LDAPSECURITY"]),
                        SqlDB.GetNullableInt32(dr["RI_DEFINITION"]),
                        SqlDB.GetNullableInt32(dr["OLEDBPROVIDER"]),
                        SqlDB.GetNullableInt32(dr["CONFIG_CACHE"])
                    );
        } // End Read
        
        public  DataTable ReadDataTable()
        {
            return SqlDB.Select("SI_CONCEPTO");
        } // End Read

        public  DataTable ReadDataTable(int cla_concepto)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", cla_concepto);
            return SqlDB.Select("SI_CONCEPTO", w_params);
        } // End Read

        public int Update()
        {
            Hashtable m_params = new Hashtable();
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            if (!SqlDB.IsNullOrEmpty(this.ESTATUS)) m_params.Add("ESTATUS", this.ESTATUS);
            if (!SqlDB.IsNullOrEmpty(this.NOM_CONCEPTO)) m_params.Add("NOM_CONCEPTO", this.NOM_CONCEPTO);
            if (!SqlDB.IsNullOrEmpty(this.NOM_TABLA)) m_params.Add("NOM_TABLA", this.NOM_TABLA);
            if (!SqlDB.IsNullOrEmpty(this.LLAVES)) m_params.Add("LLAVES", this.LLAVES);
            if (!SqlDB.IsNullOrEmpty(this.FECHA)) m_params.Add("FECHA", this.FECHA);
            if (!SqlDB.IsNullOrEmpty(this.CAPTURABLE)) m_params.Add("CAPTURABLE", this.CAPTURABLE);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_CUBO)) m_params.Add("TIPO_CUBO", this.TIPO_CUBO);
            if (!SqlDB.IsNullOrEmpty(this.CLA_BD)) m_params.Add("CLA_BD", this.CLA_BD);
            if (!SqlDB.IsNullOrEmpty(this.DIM_PERIODO)) m_params.Add("DIM_PERIODO", this.DIM_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.SERVIDOR)) m_params.Add("SERVIDOR", this.SERVIDOR);
            if (!SqlDB.IsNullOrEmpty(this.CATALOGO_OLAP)) m_params.Add("CATALOGO_OLAP", this.CATALOGO_OLAP);
            if (!SqlDB.IsNullOrEmpty(this.USUARIO)) m_params.Add("USUARIO", this.USUARIO);
            if (!SqlDB.IsNullOrEmpty(this.PASSWORD)) m_params.Add("PASSWORD", this.PASSWORD);
            if (!SqlDB.IsNullOrEmpty(this.FMT_PERIODO)) m_params.Add("FMT_PERIODO", this.FMT_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.FMT_FECHA)) m_params.Add("FMT_FECHA", this.FMT_FECHA);
            if (!SqlDB.IsNullOrEmpty(this.MEASUREDEF)) m_params.Add("MEASUREDEF", this.MEASUREDEF);
            if (!SqlDB.IsNullOrEmpty(this.REG_SETTINGS)) m_params.Add("REG_SETTINGS", this.REG_SETTINGS);
            if (!SqlDB.IsNullOrEmpty(this.USA_AGREGACION)) m_params.Add("USA_AGREGACION", this.USA_AGREGACION);
            if (!SqlDB.IsNullOrEmpty(this.USA_SINPERIODO)) m_params.Add("USA_SINPERIODO", this.USA_SINPERIODO);
            if (!SqlDB.IsNullOrEmpty(this.SHOW_ALIAS)) m_params.Add("SHOW_ALIAS", this.SHOW_ALIAS);
            if (!SqlDB.IsNullOrEmpty(this.USE_CACHE)) m_params.Add("USE_CACHE", this.USE_CACHE);
            if (!SqlDB.IsNullOrEmpty(this.DIM_LOCALE)) m_params.Add("DIM_LOCALE", this.DIM_LOCALE);
            if (!SqlDB.IsNullOrEmpty(this.DIM_UNICODE)) m_params.Add("DIM_UNICODE", this.DIM_UNICODE);
            if (!SqlDB.IsNullOrEmpty(this.DIM_FONT)) m_params.Add("DIM_FONT", this.DIM_FONT);
            if (!SqlDB.IsNullOrEmpty(this.CLA_CONEXION_SYNC)) m_params.Add("CLA_CONEXION_SYNC", this.CLA_CONEXION_SYNC);
            if (!SqlDB.IsNullOrEmpty(this.CLA_CUBO_SYNC)) m_params.Add("CLA_CUBO_SYNC", this.CLA_CUBO_SYNC);
            if (!SqlDB.IsNullOrEmpty(this.INDICATOR_INPC)) m_params.Add("INDICATOR_INPC", this.INDICATOR_INPC);
            if (!SqlDB.IsNullOrEmpty(this.CLA_OWNER)) m_params.Add("CLA_OWNER", this.CLA_OWNER);
            if (!SqlDB.IsNullOrEmpty(this.NO_NULLS)) m_params.Add("NO_NULLS", this.NO_NULLS);
            if (!SqlDB.IsNullOrEmpty(this.NO_ZEROS)) m_params.Add("NO_ZEROS", this.NO_ZEROS);
            if (!SqlDB.IsNullOrEmpty(this.DATE_KEY)) m_params.Add("DATE_KEY", this.DATE_KEY);
            if (!SqlDB.IsNullOrEmpty(this.AG_NEW)) m_params.Add("AG_NEW", this.AG_NEW);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_CONN)) m_params.Add("TIPO_CONN", this.TIPO_CONN);
            if (!SqlDB.IsNullOrEmpty(this.SERVICE_NAME)) m_params.Add("SERVICE_NAME", this.SERVICE_NAME);
            if (!SqlDB.IsNullOrEmpty(this.DATABASE_NAME)) m_params.Add("DATABASE_NAME", this.DATABASE_NAME);
            if (!SqlDB.IsNullOrEmpty(this.LDAPSECURITY)) m_params.Add("LDAPSECURITY", this.LDAPSECURITY);
            if (!SqlDB.IsNullOrEmpty(this.RI_DEFINITION)) m_params.Add("RI_DEFINITION", this.RI_DEFINITION);
            if (!SqlDB.IsNullOrEmpty(this.OLEDBPROVIDER)) m_params.Add("OLEDBPROVIDER", this.OLEDBPROVIDER);
            if (!SqlDB.IsNullOrEmpty(this.CONFIG_CACHE)) m_params.Add("CONFIG_CACHE", this.CONFIG_CACHE);

            return SqlDB.Update("SI_CONCEPTO", m_params, w_params);
        } // End Update

        public int Delete()
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);

            return SqlDB.Delete("SI_CONCEPTO", w_params);
        } // End Delete


        #endregion

    } //End Class SI_CONCEPTO

} // end namespace BIHelper.lib.artus