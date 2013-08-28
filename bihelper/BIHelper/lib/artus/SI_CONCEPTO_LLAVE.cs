using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Representa la tabla SI_CPTO_LLAVE de la base de datos de metadata de Artus
    /// </summary>
    public class SI_CPTO_LLAVE
    {

        #region Constructors

        public SI_CPTO_LLAVE()
        {
        }

        public SI_CPTO_LLAVE(
            int cla_concepto,
            int consecutivo,
            int nivel,
            int? cla_descrip,
            string nom_descriptor,
            string par_descriptor,
            string nom_fisico,
            string nom_logico,
            string fmt_periodo,
            string measuredef,
            string agrupador,
            int? tipo_dato,
            int? long_dato,
            int? estatus,
            int? orden_del_server,
            int? cla_periodo,
            int? es_metrica,
            int? edit_outline,
            int? no_nonempty,
            string allcaption,
            int? maxrecords,
            int? filterdep,
            int? orden_periodo,
            int? cpaad,
            int? order_by_key,
            int? relativo,
            int? ordinallevel)
        {
            this.CLA_CONCEPTO = cla_concepto;
            this.CONSECUTIVO = consecutivo;
            this.NIVEL = nivel;
            this.CLA_DESCRIP = cla_descrip;
            this.NOM_DESCRIPTOR = nom_descriptor;
            this.PAR_DESCRIPTOR = par_descriptor;
            this.NOM_FISICO = nom_fisico;
            this.NOM_LOGICO = nom_logico;
            this.FMT_PERIODO = fmt_periodo;
            this.MEASUREDEF = measuredef;
            this.AGRUPADOR = agrupador;
            this.TIPO_DATO = tipo_dato;
            this.LONG_DATO = long_dato;
            this.ESTATUS = estatus;
            this.ORDEN_DEL_SERVER = orden_del_server;
            this.CLA_PERIODO = cla_periodo;
            this.ES_METRICA = es_metrica;
            this.EDIT_OUTLINE = edit_outline;
            this.NO_NONEMPTY = no_nonempty;
            this.ALLCAPTION = allcaption;
            this.MAXRECORDS = maxrecords;
            this.FILTERDEP = filterdep;
            this.ORDEN_PERIODO = orden_periodo;
            this.CPAAD = cpaad;
            this.ORDER_BY_KEY = order_by_key;
            this.RELATIVO = relativo;
            this.ORDINALLEVEL = ordinallevel;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Instancia del asistente de acceso a datos Sql Server
        /// </summary>
        public lib.SqlServerHelper SqlDB { get; set; }

        private int _CLA_CONCEPTO;
        public int CLA_CONCEPTO
        {
            get { return _CLA_CONCEPTO; }
            set { _CLA_CONCEPTO = value; }
        }

        private int _CONSECUTIVO;
        public int CONSECUTIVO
        {
            get { return _CONSECUTIVO; }
            set { _CONSECUTIVO = value; }
        }

        private int _NIVEL;
        public int NIVEL
        {
            get { return _NIVEL; }
            set { _NIVEL = value; }
        }

        private int? _CLA_DESCRIP;
        public int? CLA_DESCRIP
        {
            get { return _CLA_DESCRIP; }
            set { _CLA_DESCRIP = value; }
        }

        private string _NOM_DESCRIPTOR;
        public string NOM_DESCRIPTOR
        {
            get { return _NOM_DESCRIPTOR; }
            set { _NOM_DESCRIPTOR = value; }
        }

        private string _PAR_DESCRIPTOR;
        public string PAR_DESCRIPTOR
        {
            get { return _PAR_DESCRIPTOR; }
            set { _PAR_DESCRIPTOR = value; }
        }

        private string _NOM_FISICO;
        public string NOM_FISICO
        {
            get { return _NOM_FISICO; }
            set { _NOM_FISICO = value; }
        }

        private string _NOM_LOGICO;
        public string NOM_LOGICO
        {
            get { return _NOM_LOGICO; }
            set { _NOM_LOGICO = value; }
        }

        private string _FMT_PERIODO;
        public string FMT_PERIODO
        {
            get { return _FMT_PERIODO; }
            set { _FMT_PERIODO = value; }
        }

        private string _MEASUREDEF;
        public string MEASUREDEF
        {
            get { return _MEASUREDEF; }
            set { _MEASUREDEF = value; }
        }

        private string _AGRUPADOR;
        public string AGRUPADOR
        {
            get { return _AGRUPADOR; }
            set { _AGRUPADOR = value; }
        }

        private int? _TIPO_DATO;
        public int? TIPO_DATO
        {
            get { return _TIPO_DATO; }
            set { _TIPO_DATO = value; }
        }

        private int? _LONG_DATO;
        public int? LONG_DATO
        {
            get { return _LONG_DATO; }
            set { _LONG_DATO = value; }
        }

        private int? _ESTATUS;
        public int? ESTATUS
        {
            get { return _ESTATUS; }
            set { _ESTATUS = value; }
        }

        private int? _ORDEN_DEL_SERVER;
        public int? ORDEN_DEL_SERVER
        {
            get { return _ORDEN_DEL_SERVER; }
            set { _ORDEN_DEL_SERVER = value; }
        }

        private int? _CLA_PERIODO;
        public int? CLA_PERIODO
        {
            get { return _CLA_PERIODO; }
            set { _CLA_PERIODO = value; }
        }

        private int? _ES_METRICA;
        public int? ES_METRICA
        {
            get { return _ES_METRICA; }
            set { _ES_METRICA = value; }
        }

        private int? _EDIT_OUTLINE;
        public int? EDIT_OUTLINE
        {
            get { return _EDIT_OUTLINE; }
            set { _EDIT_OUTLINE = value; }
        }

        private int? _NO_NONEMPTY;
        public int? NO_NONEMPTY
        {
            get { return _NO_NONEMPTY; }
            set { _NO_NONEMPTY = value; }
        }

        private string _ALLCAPTION;
        public string ALLCAPTION
        {
            get { return _ALLCAPTION; }
            set { _ALLCAPTION = value; }
        }

        private int? _MAXRECORDS;
        public int? MAXRECORDS
        {
            get { return _MAXRECORDS; }
            set { _MAXRECORDS = value; }
        }

        private int? _FILTERDEP;
        public int? FILTERDEP
        {
            get { return _FILTERDEP; }
            set { _FILTERDEP = value; }
        }

        private int? _ORDEN_PERIODO;
        public int? ORDEN_PERIODO
        {
            get { return _ORDEN_PERIODO; }
            set { _ORDEN_PERIODO = value; }
        }

        private int? _CPAAD;
        public int? CPAAD
        {
            get { return _CPAAD; }
            set { _CPAAD = value; }
        }

        private int? _ORDER_BY_KEY;
        public int? ORDER_BY_KEY
        {
            get { return _ORDER_BY_KEY; }
            set { _ORDER_BY_KEY = value; }
        }

        private int? _RELATIVO;
        public int? RELATIVO
        {
            get { return _RELATIVO; }
            set { _RELATIVO = value; }
        }

        private int? _ORDINALLEVEL;
        public int? ORDINALLEVEL
        {
            get { return _ORDINALLEVEL; }
            set { _ORDINALLEVEL = value; }
        }

        #endregion

        #region Methods
        public void Validate()
        {            

            if (this.NOM_DESCRIPTOR.Length > 255)
            {
                throw new Exception("NOM_DESCRIPTOR debe tener máximo 255 carateres.");
            }

            if (this.PAR_DESCRIPTOR.Length > 20)
            {
                throw new Exception("PAR_DESCRIPTOR debe tener máximo 20 carateres.");
            }

            if (this.NOM_FISICO.Length > 254)
            {
                throw new Exception("NOM_FISICO debe tener máximo 254 carateres.");
            }

            if (this.NOM_LOGICO.Length > 254)
            {
                throw new Exception("NOM_LOGICO debe tener máximo 254 carateres.");
            }

            if (this.FMT_PERIODO.Length > 60)
            {
                throw new Exception("FMT_PERIODO debe tener máximo 60 carateres.");
            }

            if (this.MEASUREDEF.Length > 250)
            {
                throw new Exception("MEASUREDEF debe tener máximo 250 carateres.");
            }

            if (this.AGRUPADOR.Length > 255)
            {
                throw new Exception("AGRUPADOR debe tener máximo 255 carateres.");
            }

            if (this.ALLCAPTION.Length > 255)
            {
                throw new Exception("ALLCAPTION debe tener máximo 255 carateres.");
            }


        } // End Validate

        public int Create()
        {
            Hashtable m_params = new Hashtable();
            m_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            m_params.Add("CONSECUTIVO", this.CONSECUTIVO);
            m_params.Add("NIVEL", this.NIVEL);
            if (!SqlDB.IsNullOrEmpty(this.CLA_DESCRIP)) m_params.Add("CLA_DESCRIP", this.CLA_DESCRIP);
            if (!SqlDB.IsNullOrEmpty(this.NOM_DESCRIPTOR)) m_params.Add("NOM_DESCRIPTOR", this.NOM_DESCRIPTOR);
            if (!SqlDB.IsNullOrEmpty(this.PAR_DESCRIPTOR)) m_params.Add("PAR_DESCRIPTOR", this.PAR_DESCRIPTOR);
            if (!SqlDB.IsNullOrEmpty(this.NOM_FISICO)) m_params.Add("NOM_FISICO", this.NOM_FISICO);
            if (!SqlDB.IsNullOrEmpty(this.NOM_LOGICO)) m_params.Add("NOM_LOGICO", this.NOM_LOGICO);
            if (!SqlDB.IsNullOrEmpty(this.FMT_PERIODO)) m_params.Add("FMT_PERIODO", this.FMT_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.MEASUREDEF)) m_params.Add("MEASUREDEF", this.MEASUREDEF);
            if (!SqlDB.IsNullOrEmpty(this.AGRUPADOR)) m_params.Add("AGRUPADOR", this.AGRUPADOR);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_DATO)) m_params.Add("TIPO_DATO", this.TIPO_DATO);
            if (!SqlDB.IsNullOrEmpty(this.LONG_DATO)) m_params.Add("LONG_DATO", this.LONG_DATO);
            if (!SqlDB.IsNullOrEmpty(this.ESTATUS)) m_params.Add("ESTATUS", this.ESTATUS);
            if (!SqlDB.IsNullOrEmpty(this.ORDEN_DEL_SERVER)) m_params.Add("ORDEN_DEL_SERVER", this.ORDEN_DEL_SERVER);
            if (!SqlDB.IsNullOrEmpty(this.CLA_PERIODO)) m_params.Add("CLA_PERIODO", this.CLA_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.ES_METRICA)) m_params.Add("ES_METRICA", this.ES_METRICA);
            if (!SqlDB.IsNullOrEmpty(this.EDIT_OUTLINE)) m_params.Add("EDIT_OUTLINE", this.EDIT_OUTLINE);
            if (!SqlDB.IsNullOrEmpty(this.NO_NONEMPTY)) m_params.Add("NO_NONEMPTY", this.NO_NONEMPTY);
            if (!SqlDB.IsNullOrEmpty(this.ALLCAPTION)) m_params.Add("ALLCAPTION", this.ALLCAPTION);
            if (!SqlDB.IsNullOrEmpty(this.MAXRECORDS)) m_params.Add("MAXRECORDS", this.MAXRECORDS);
            if (!SqlDB.IsNullOrEmpty(this.FILTERDEP)) m_params.Add("FILTERDEP", this.FILTERDEP);
            if (!SqlDB.IsNullOrEmpty(this.ORDEN_PERIODO)) m_params.Add("ORDEN_PERIODO", this.ORDEN_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.CPAAD)) m_params.Add("CPAAD", this.CPAAD);
            if (!SqlDB.IsNullOrEmpty(this.ORDER_BY_KEY)) m_params.Add("ORDER_BY_KEY", this.ORDER_BY_KEY);
            if (!SqlDB.IsNullOrEmpty(this.RELATIVO)) m_params.Add("RELATIVO", this.RELATIVO);
            if (!SqlDB.IsNullOrEmpty(this.ORDINALLEVEL)) m_params.Add("ORDINALLEVEL", this.ORDINALLEVEL);

            return SqlDB.Insert("SI_CPTO_LLAVE", m_params);
        } // End Create

        public List<SI_CPTO_LLAVE> Read()
        {
            List<SI_CPTO_LLAVE> list = new List<SI_CPTO_LLAVE>();
            DataTable dt = SqlDB.Select("SI_CPTO_LLAVE");
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new SI_CPTO_LLAVE(
                        Convert.ToInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToInt32(dr["CONSECUTIVO"]),
                        Convert.ToInt32(dr["NIVEL"]),
                        SqlDB.GetNullableInt32(dr["CLA_DESCRIP"]),
                        Convert.ToString(dr["NOM_DESCRIPTOR"]),
                        Convert.ToString(dr["PAR_DESCRIPTOR"]),
                        Convert.ToString(dr["NOM_FISICO"]),
                        Convert.ToString(dr["NOM_LOGICO"]),
                        Convert.ToString(dr["FMT_PERIODO"]),
                        Convert.ToString(dr["MEASUREDEF"]),
                        Convert.ToString(dr["AGRUPADOR"]),
                        SqlDB.GetNullableInt32(dr["TIPO_DATO"]),
                        SqlDB.GetNullableInt32(dr["LONG_DATO"]),
                        SqlDB.GetNullableInt32(dr["ESTATUS"]),
                        SqlDB.GetNullableInt32(dr["ORDEN_DEL_SERVER"]),
                        SqlDB.GetNullableInt32(dr["CLA_PERIODO"]),
                        SqlDB.GetNullableInt32(dr["ES_METRICA"]),
                        SqlDB.GetNullableInt32(dr["EDIT_OUTLINE"]),
                        SqlDB.GetNullableInt32(dr["NO_NONEMPTY"]),
                        Convert.ToString(dr["ALLCAPTION"]),
                        SqlDB.GetNullableInt32(dr["MAXRECORDS"]),
                        SqlDB.GetNullableInt32(dr["FILTERDEP"]),
                        SqlDB.GetNullableInt32(dr["ORDEN_PERIODO"]),
                        SqlDB.GetNullableInt32(dr["CPAAD"]),
                        SqlDB.GetNullableInt32(dr["ORDER_BY_KEY"]),
                        SqlDB.GetNullableInt32(dr["RELATIVO"]),
                        SqlDB.GetNullableInt32(dr["ORDINALLEVEL"])
                    )
                );
            }

            return list;
        } // End Read

        public SI_CPTO_LLAVE Read(int cla_concepto, int consecutivo)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", cla_concepto);
            w_params.Add("CONSECUTIVO", consecutivo);
            DataTable dt = SqlDB.Select("SI_CPTO_LLAVE", w_params);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("No existe SI_CPTO_LLAVE con los criterios de búsqueda especificados.");
            }
            DataRow dr = dt.Rows[0];
            return new SI_CPTO_LLAVE(
                Convert.ToInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToInt32(dr["CONSECUTIVO"]),
                        Convert.ToInt32(dr["NIVEL"]),
                        SqlDB.GetNullableInt32(dr["CLA_DESCRIP"]),
                        Convert.ToString(dr["NOM_DESCRIPTOR"]),
                        Convert.ToString(dr["PAR_DESCRIPTOR"]),
                        Convert.ToString(dr["NOM_FISICO"]),
                        Convert.ToString(dr["NOM_LOGICO"]),
                        Convert.ToString(dr["FMT_PERIODO"]),
                        Convert.ToString(dr["MEASUREDEF"]),
                        Convert.ToString(dr["AGRUPADOR"]),
                        SqlDB.GetNullableInt32(dr["TIPO_DATO"]),
                        SqlDB.GetNullableInt32(dr["LONG_DATO"]),
                        SqlDB.GetNullableInt32(dr["ESTATUS"]),
                        SqlDB.GetNullableInt32(dr["ORDEN_DEL_SERVER"]),
                        SqlDB.GetNullableInt32(dr["CLA_PERIODO"]),
                        SqlDB.GetNullableInt32(dr["ES_METRICA"]),
                        SqlDB.GetNullableInt32(dr["EDIT_OUTLINE"]),
                        SqlDB.GetNullableInt32(dr["NO_NONEMPTY"]),
                        Convert.ToString(dr["ALLCAPTION"]),
                        SqlDB.GetNullableInt32(dr["MAXRECORDS"]),
                        SqlDB.GetNullableInt32(dr["FILTERDEP"]),
                        SqlDB.GetNullableInt32(dr["ORDEN_PERIODO"]),
                        SqlDB.GetNullableInt32(dr["CPAAD"]),
                        SqlDB.GetNullableInt32(dr["ORDER_BY_KEY"]),
                        SqlDB.GetNullableInt32(dr["RELATIVO"]),
                        SqlDB.GetNullableInt32(dr["ORDINALLEVEL"])
                    );
        } // End Read
        
        public DataTable ReadDataTable()
        {
            return SqlDB.Select("SI_CPTO_LLAVE");
        } // End Read

        public DataTable ReadDataTable(int cla_concepto, int consecutivo)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", cla_concepto);
            w_params.Add("CONSECUTIVO", consecutivo);
            return SqlDB.Select("SI_CPTO_LLAVE", w_params);
        } // End Read

        public int Update()
        {
            Hashtable m_params = new Hashtable();
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            w_params.Add("CONSECUTIVO", this.CONSECUTIVO);
            m_params.Add("NIVEL", this.NIVEL);
            if (!SqlDB.IsNullOrEmpty(this.CLA_DESCRIP)) m_params.Add("CLA_DESCRIP", this.CLA_DESCRIP);
            if (!SqlDB.IsNullOrEmpty(this.NOM_DESCRIPTOR)) m_params.Add("NOM_DESCRIPTOR", this.NOM_DESCRIPTOR);
            if (!SqlDB.IsNullOrEmpty(this.PAR_DESCRIPTOR)) m_params.Add("PAR_DESCRIPTOR", this.PAR_DESCRIPTOR);
            if (!SqlDB.IsNullOrEmpty(this.NOM_FISICO)) m_params.Add("NOM_FISICO", this.NOM_FISICO);
            if (!SqlDB.IsNullOrEmpty(this.NOM_LOGICO)) m_params.Add("NOM_LOGICO", this.NOM_LOGICO);
            if (!SqlDB.IsNullOrEmpty(this.FMT_PERIODO)) m_params.Add("FMT_PERIODO", this.FMT_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.MEASUREDEF)) m_params.Add("MEASUREDEF", this.MEASUREDEF);
            if (!SqlDB.IsNullOrEmpty(this.AGRUPADOR)) m_params.Add("AGRUPADOR", this.AGRUPADOR);
            if (!SqlDB.IsNullOrEmpty(this.TIPO_DATO)) m_params.Add("TIPO_DATO", this.TIPO_DATO);
            if (!SqlDB.IsNullOrEmpty(this.LONG_DATO)) m_params.Add("LONG_DATO", this.LONG_DATO);
            if (!SqlDB.IsNullOrEmpty(this.ESTATUS)) m_params.Add("ESTATUS", this.ESTATUS);
            if (!SqlDB.IsNullOrEmpty(this.ORDEN_DEL_SERVER)) m_params.Add("ORDEN_DEL_SERVER", this.ORDEN_DEL_SERVER);
            if (!SqlDB.IsNullOrEmpty(this.CLA_PERIODO)) m_params.Add("CLA_PERIODO", this.CLA_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.ES_METRICA)) m_params.Add("ES_METRICA", this.ES_METRICA);
            if (!SqlDB.IsNullOrEmpty(this.EDIT_OUTLINE)) m_params.Add("EDIT_OUTLINE", this.EDIT_OUTLINE);
            if (!SqlDB.IsNullOrEmpty(this.NO_NONEMPTY)) m_params.Add("NO_NONEMPTY", this.NO_NONEMPTY);
            if (!SqlDB.IsNullOrEmpty(this.ALLCAPTION)) m_params.Add("ALLCAPTION", this.ALLCAPTION);
            if (!SqlDB.IsNullOrEmpty(this.MAXRECORDS)) m_params.Add("MAXRECORDS", this.MAXRECORDS);
            if (!SqlDB.IsNullOrEmpty(this.FILTERDEP)) m_params.Add("FILTERDEP", this.FILTERDEP);
            if (!SqlDB.IsNullOrEmpty(this.ORDEN_PERIODO)) m_params.Add("ORDEN_PERIODO", this.ORDEN_PERIODO);
            if (!SqlDB.IsNullOrEmpty(this.CPAAD)) m_params.Add("CPAAD", this.CPAAD);
            if (!SqlDB.IsNullOrEmpty(this.ORDER_BY_KEY)) m_params.Add("ORDER_BY_KEY", this.ORDER_BY_KEY);
            if (!SqlDB.IsNullOrEmpty(this.RELATIVO)) m_params.Add("RELATIVO", this.RELATIVO);
            if (!SqlDB.IsNullOrEmpty(this.ORDINALLEVEL)) m_params.Add("ORDINALLEVEL", this.ORDINALLEVEL);

            return SqlDB.Update("SI_CPTO_LLAVE", m_params, w_params);
        } // End Update

        public int Delete()
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            w_params.Add("CONSECUTIVO", this.CONSECUTIVO);

            return SqlDB.Delete("SI_CPTO_LLAVE", w_params);
        } // End Delete


        #endregion
    } //End Class SI_CPTO_LLAVE
}
