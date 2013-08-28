using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Esta clase representa un conjunto de registros de dimensiones
    /// en un cubo de Artus
    /// </summary>
    public class Vista_Dimensiones_Cubo
    {

        #region Constructors
        public Vista_Dimensiones_Cubo()
        {
        }

        public Vista_Dimensiones_Cubo(
            System.Int32? cla_concepto,
            System.String grupo,
            System.String nombre_logico,
            System.String dimension_artus_admin,
            System.String tabla,
            System.String campo_fisico_clave,
            System.String campo_fisico_descripcion,
            System.String incluirse,
            System.String campo_clave_tabla_hechos,
            System.String campo_clave_tabla_dimension,
            System.String descripcion
            )
        {
            this.CLA_CONCEPTO = cla_concepto;
            this.GRUPO = grupo;
            this.NOMBRE_LOGICO = nombre_logico;
            this.DIMENSION_ARTUS_ADMIN = dimension_artus_admin;
            this.TABLA = tabla;
            this.CAMPO_FISICO_CLAVE = campo_fisico_clave;
            this.CAMPO_FISICO_DESCRIPCION = campo_fisico_descripcion;
            this.INCLUIRSE = incluirse;
            this.CAMPO_CLAVE_TABLA_HECHOS = campo_clave_tabla_hechos;
            this.CAMPO_CLAVE_TABLA_DIMENSION = campo_clave_tabla_dimension;
            this.DESCRIPCION = descripcion;
        }

        #endregion

        #region Properties

        /// <summary>
        /// La instancia del asistente de acceso a datos
        /// </summary>
        public lib.SqlServerHelper SqlDB { get; set; }

        private System.Int32? _CLA_CONCEPTO;
        public System.Int32? CLA_CONCEPTO
        {
            get { return _CLA_CONCEPTO; }
            set { _CLA_CONCEPTO = value; }
        }

        private System.String _GRUPO;
        public System.String GRUPO
        {
            get { return _GRUPO; }
            set { _GRUPO = value; }
        }

        private System.String _NOMBRE_LOGICO;
        public System.String NOMBRE_LOGICO
        {
            get { return _NOMBRE_LOGICO; }
            set { _NOMBRE_LOGICO = value; }
        }

        private System.String _DIMENSION_ARTUS_ADMIN;
        public System.String DIMENSION_ARTUS_ADMIN
        {
            get { return _DIMENSION_ARTUS_ADMIN; }
            set { _DIMENSION_ARTUS_ADMIN = value; }
        }

        private System.String _TABLA;
        public System.String TABLA
        {
            get { return _TABLA; }
            set { _TABLA = value; }
        }

        private System.String _CAMPO_FISICO_CLAVE;
        public System.String CAMPO_FISICO_CLAVE
        {
            get { return _CAMPO_FISICO_CLAVE; }
            set { _CAMPO_FISICO_CLAVE = value; }
        }

        private System.String _CAMPO_FISICO_DESCRIPCION;
        public System.String CAMPO_FISICO_DESCRIPCION
        {
            get { return _CAMPO_FISICO_DESCRIPCION; }
            set { _CAMPO_FISICO_DESCRIPCION = value; }
        }

        private System.String _INCLUIRSE;
        public System.String INCLUIRSE
        {
            get { return _INCLUIRSE; }
            set { _INCLUIRSE = value; }
        }

        private System.String _CAMPO_CLAVE_TABLA_HECHOS;
        public System.String CAMPO_CLAVE_TABLA_HECHOS
        {
            get { return _CAMPO_CLAVE_TABLA_HECHOS; }
            set { _CAMPO_CLAVE_TABLA_HECHOS = value; }
        }

        private System.String _CAMPO_CLAVE_TABLA_DIMENSION;
        public System.String CAMPO_CLAVE_TABLA_DIMENSION
        {
            get { return _CAMPO_CLAVE_TABLA_DIMENSION; }
            set { _CAMPO_CLAVE_TABLA_DIMENSION = value; }
        }

        private System.String _DESCRIPCION;
        public System.String DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return this.NOMBRE_LOGICO;
        }

        public List<Vista_Dimensiones_Cubo> Get(
            System.Int32? cla_concepto)
        {
            string sqlstr = @"SELECT	CL.CLA_CONCEPTO,
		DE.AGRUPADOR GRUPO,
		CL.NOM_LOGICO NOMBRE_LOGICO,
		DE.NOM_LOGICO DIMENSION_ARTUS_ADMIN,
		DE.NOM_TABLA TABLA,
		CL.NOM_FISICO CAMPO_FISICO_CLAVE,
		CL.NOM_DESCRIPTOR CAMPO_FISICO_DESCRIPCION,
		'SI' INCLUIRSE,
		DK.NOM_FISICOK CAMPO_CLAVE_TABLA_HECHOS,
		DK.NOM_FISICOK_JOIN CAMPO_CLAVE_TABLA_DIMENSION,
		'' DESCRIPCION		
FROM	SI_CPTO_LLAVE CL
INNER JOIN	SI_DESCRIP_ENC DE
ON		CL.CLA_DESCRIP = DE.CLA_DESCRIP
INNER JOIN	SI_DESCRIP_KEYS DK
ON		CL.CLA_CONCEPTO = DK.CLA_CONCEPTO
AND		DK.NOM_TABLA = DE.NOM_TABLA
WHERE	DK.CLA_CONCEPTO = @CLA_CONCEPTO
ORDER BY    DE.AGRUPADOR, CL.NOM_LOGICO";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_CONCEPTO", cla_concepto);

            List<Vista_Dimensiones_Cubo> list = new List<Vista_Dimensiones_Cubo>();
            DataTable dt = SqlDB.Query(sqlstr, m_params);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new Vista_Dimensiones_Cubo(
                        SqlDB.GetNullableInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToString(dr["GRUPO"]),
                        Convert.ToString(dr["NOMBRE_LOGICO"]),
                        Convert.ToString(dr["DIMENSION_ARTUS_ADMIN"]),
                        Convert.ToString(dr["TABLA"]),
                        Convert.ToString(dr["CAMPO_FISICO_CLAVE"]),
                        Convert.ToString(dr["CAMPO_FISICO_DESCRIPCION"]),
                        Convert.ToString(dr["INCLUIRSE"]),
                        Convert.ToString(dr["CAMPO_CLAVE_TABLA_HECHOS"]),
                        Convert.ToString(dr["CAMPO_CLAVE_TABLA_DIMENSION"]),
                        Convert.ToString(dr["DESCRIPCION"])
                        )
                    );
            }
            return list;
        } // End GetData

        public DataTable GetDataTable(
            System.Int32? cla_concepto)
        {
            string sqlstr = @"SELECT	CL.CLA_CONCEPTO,
		DE.AGRUPADOR GRUPO,
		CL.NOM_LOGICO NOMBRE_LOGICO,
		DE.NOM_LOGICO DIMENSION_ARTUS_ADMIN,
		DE.NOM_TABLA TABLA,
		CL.NOM_FISICO CAMPO_FISICO_CLAVE,
		CL.NOM_DESCRIPTOR CAMPO_FISICO_DESCRIPCION,
		'SI' INCLUIRSE,
		DK.NOM_FISICOK CAMPO_CLAVE_TABLA_HECHOS,
		DK.NOM_FISICOK_JOIN CAMPO_CLAVE_TABLA_DIMENSION,
		'' DESCRIPCION		
FROM	SI_CPTO_LLAVE CL
INNER JOIN	SI_DESCRIP_ENC DE
ON		CL.CLA_DESCRIP = DE.CLA_DESCRIP
INNER JOIN	SI_DESCRIP_KEYS DK
ON		CL.CLA_CONCEPTO = DK.CLA_CONCEPTO
AND		DK.NOM_TABLA = DE.NOM_TABLA
WHERE	DK.CLA_CONCEPTO = @CLA_CONCEPTO";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_CONCEPTO", cla_concepto);

            return SqlDB.Query(sqlstr, m_params);
        } // End GetDataTable


        #endregion
    } // End Class Vista_Dimensiones_Cubo
}
