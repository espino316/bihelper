using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Representa la tabla DESCRIP_KEYS de la base de datos de metadata de Artus
    /// </summary>
    public class SI_DESCRIP_KEYS
    {

        #region Constructors

        public SI_DESCRIP_KEYS()
        {
        }

        public SI_DESCRIP_KEYS(
            int cla_concepto,
            string nom_tabla,
            int consecutivo,
            string nom_fisicok,
            string nom_fisicok_join)
        {
            this.CLA_CONCEPTO = cla_concepto;
            this.NOM_TABLA = nom_tabla;
            this.CONSECUTIVO = consecutivo;
            this.NOM_FISICOK = nom_fisicok;
            this.NOM_FISICOK_JOIN = nom_fisicok_join;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Instancia del asistente de conexióna datos
        /// </summary>
        public lib.SqlServerHelper SqlDB { get; set; }

        private int _CLA_CONCEPTO;
        public int CLA_CONCEPTO
        {
            get { return _CLA_CONCEPTO; }
            set { _CLA_CONCEPTO = value; }
        }

        private string _NOM_TABLA;
        public string NOM_TABLA
        {
            get { return _NOM_TABLA; }
            set { _NOM_TABLA = value; }
        }

        private int _CONSECUTIVO;
        public int CONSECUTIVO
        {
            get { return _CONSECUTIVO; }
            set { _CONSECUTIVO = value; }
        }

        private string _NOM_FISICOK;
        public string NOM_FISICOK
        {
            get { return _NOM_FISICOK; }
            set { _NOM_FISICOK = value; }
        }

        private string _NOM_FISICOK_JOIN;
        public string NOM_FISICOK_JOIN
        {
            get { return _NOM_FISICOK_JOIN; }
            set { _NOM_FISICOK_JOIN = value; }
        }

        #endregion

        #region Methods
        public void Validate()
        {
            
            if (this.NOM_TABLA == null) throw new Exception("NOM_TABLA no puede ser nulo.");

            if (this.NOM_TABLA.Length > 100)
            {
                throw new Exception("NOM_TABLA debe tener máximo 100 carateres.");
            }
            
            if (this.NOM_FISICOK == null) throw new Exception("NOM_FISICOK no puede ser nulo.");

            if (this.NOM_FISICOK.Length > 100)
            {
                throw new Exception("NOM_FISICOK debe tener máximo 100 carateres.");
            }

            if (this.NOM_FISICOK_JOIN == null) throw new Exception("NOM_FISICOK_JOIN no puede ser nulo.");

            if (this.NOM_FISICOK_JOIN.Length > 100)
            {
                throw new Exception("NOM_FISICOK_JOIN debe tener máximo 100 carateres.");
            }


        } // End Validate

        public int Create()
        {
            Hashtable m_params = new Hashtable();
            m_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            m_params.Add("NOM_TABLA", this.NOM_TABLA);
            m_params.Add("CONSECUTIVO", this.CONSECUTIVO);
            m_params.Add("NOM_FISICOK", this.NOM_FISICOK);
            m_params.Add("NOM_FISICOK_JOIN", this.NOM_FISICOK_JOIN);

            return SqlDB.Insert("SI_DESCRIP_KEYS", m_params);
        } // End Create

        public List<SI_DESCRIP_KEYS> Read()
        {
            List<SI_DESCRIP_KEYS> list = new List<SI_DESCRIP_KEYS>();
            DataTable dt = SqlDB.Select("SI_DESCRIP_KEYS");
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new SI_DESCRIP_KEYS(
                        Convert.ToInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToString(dr["NOM_TABLA"]),
                        Convert.ToInt32(dr["CONSECUTIVO"]),
                        Convert.ToString(dr["NOM_FISICOK"]),
                        Convert.ToString(dr["NOM_FISICOK_JOIN"])
                    )
                );
            }

            return list;
        } // End Read

        public SI_DESCRIP_KEYS Read(int cla_concepto, string nom_tabla, int consecutivo)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", cla_concepto);
            w_params.Add("NOM_TABLA", nom_tabla);
            w_params.Add("CONSECUTIVO", consecutivo);
            DataTable dt = SqlDB.Select("SI_DESCRIP_KEYS", w_params);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("No existe SI_DESCRIP_KEYS con los criterios de búsqueda especificados.");
            }
            DataRow dr = dt.Rows[0];
            return new SI_DESCRIP_KEYS(
                Convert.ToInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToString(dr["NOM_TABLA"]),
                        Convert.ToInt32(dr["CONSECUTIVO"]),
                        Convert.ToString(dr["NOM_FISICOK"]),
                        Convert.ToString(dr["NOM_FISICOK_JOIN"])
                    );
        } // End Read
        
        public DataTable ReadDataTable()
        {
            return SqlDB.Select("SI_DESCRIP_KEYS");
        } // End Read

        public DataTable ReadDataTable(int cla_concepto, string nom_tabla, int consecutivo)
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", cla_concepto);
            w_params.Add("NOM_TABLA", nom_tabla);
            w_params.Add("CONSECUTIVO", consecutivo);
            return SqlDB.Select("SI_DESCRIP_KEYS", w_params);
        } // End Read

        public int Update()
        {
            Hashtable m_params = new Hashtable();
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            w_params.Add("NOM_TABLA", this.NOM_TABLA);
            w_params.Add("CONSECUTIVO", this.CONSECUTIVO);
            m_params.Add("NOM_FISICOK", this.NOM_FISICOK);
            m_params.Add("NOM_FISICOK_JOIN", this.NOM_FISICOK_JOIN);

            return SqlDB.Update("SI_DESCRIP_KEYS", m_params, w_params);
        } // End Update

        public int Delete()
        {
            Hashtable w_params = new Hashtable();
            w_params.Add("CLA_CONCEPTO", this.CLA_CONCEPTO);
            w_params.Add("NOM_TABLA", this.NOM_TABLA);
            w_params.Add("CONSECUTIVO", this.CONSECUTIVO);

            return SqlDB.Delete("SI_DESCRIP_KEYS", w_params);
        } // End Delete


        #endregion
    } //End Class SI_DESCRIP_KEYS

}
