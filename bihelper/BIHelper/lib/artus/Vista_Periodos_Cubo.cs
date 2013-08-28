using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Esta clase representa un conjunto de registros de periodos
    /// en un cubo de Artus
    /// </summary>
    public class Vista_Periodos_Cubo
    {

        #region Constructors
        public Vista_Periodos_Cubo()
        {
        }

        public Vista_Periodos_Cubo(
            System.Int32? cla_concepto,
            System.String periodo_tiempo,
            System.String formato,
            System.String tabla,
            System.String campo_fisico_clave,
            System.String campo_fisico_descripcion,
            System.String incluirse,
            System.String descripcion
            )
        {
            this.CLA_CONCEPTO = cla_concepto;
            this.PERIODO_TIEMPO = periodo_tiempo;
            this.FORMATO = formato;
            this.TABLA = tabla;
            this.CAMPO_FISICO_CLAVE = campo_fisico_clave;
            this.CAMPO_FISICO_DESCRIPCION = campo_fisico_descripcion;
            this.INCLUIRSE = incluirse;
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

        private System.String _PERIODO_TIEMPO;
        public System.String PERIODO_TIEMPO
        {
            get { return _PERIODO_TIEMPO; }
            set { _PERIODO_TIEMPO = value; }
        }

        private System.String _FORMATO;
        public System.String FORMATO
        {
            get { return _FORMATO; }
            set { _FORMATO = value; }
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

        private System.String _DESCRIPCION;
        public System.String DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }

        #endregion

        #region Methods
        public List<Vista_Periodos_Cubo> Get(
            System.Int32? cla_concepto)
        {
            string sqlstr = @"SELECT	PC.CLA_CONCEPTO,
		P.NOM_PERIODO PERIODO_TIEMPO,
		P.FMT_PERIODO FORMATO,
		DE.NOM_TABLA TABLA,
		CL.NOM_FISICO CAMPO_FISICO_CLAVE,
		CL.NOM_DESCRIPTOR CAMPO_FISICO_DESCRIPCION,
		'SI' INCLUIRSE,
		'' DESCRIPCION
FROM	SI_PERIODO P
INNER JOIN	SI_PERIODOSxCUBO PC
ON		P.CLA_PERIODO = PC.CLA_PERIODO
INNER JOIN SI_CPTO_LLAVE CL
ON		PC.CLA_PERIODO = CL.CLA_PERIODO
AND		PC.CLA_CONCEPTO = CL.CLA_CONCEPTO
INNER JOIN	SI_DESCRIP_ENC DE
ON		CL.CLA_DESCRIP = DE.CLA_DESCRIP
WHERE	PC.CLA_CONCEPTO = @CLA_CONCEPTO
AND		P.CLA_PERIODO IN
(
	SELECT
	   DISTINCT CLA_PERIODO 
	FROM
	   SI_CPTO_LLAVE 
	WHERE
	   NOT CLA_PERIODO IS NULL
	   AND CLA_PERIODO <> -1 
	   AND CLA_CONCEPTO = @CLA_CONCEPTO
)
ORDER BY	PERIODO_TIEMPO";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_CONCEPTO", cla_concepto);

            List<Vista_Periodos_Cubo> list = new List<Vista_Periodos_Cubo>();
            DataTable dt = SqlDB.Query(sqlstr, m_params);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new Vista_Periodos_Cubo(
                        SqlDB.GetNullableInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToString(dr["PERIODO_TIEMPO"]),
                        Convert.ToString(dr["FORMATO"]),
                        Convert.ToString(dr["TABLA"]),
                        Convert.ToString(dr["CAMPO_FISICO_CLAVE"]),
                        Convert.ToString(dr["CAMPO_FISICO_DESCRIPCION"]),
                        Convert.ToString(dr["INCLUIRSE"]),
                        Convert.ToString(dr["DESCRIPCION"])
                        )
                    );
            }
            return list;
        } // End GetData

        public DataTable GetDataTable(
            System.Int32? cla_concepto)
        {
            string sqlstr = @"SELECT	PC.CLA_CONCEPTO,
		P.NOM_PERIODO PERIODO_TIEMPO,
		P.FMT_PERIODO FORMATO,
		DE.NOM_TABLA TABLA,
		CL.NOM_FISICO CAMPO_FISICO_CLAVE,
		CL.NOM_DESCRIPTOR CAMPO_FISICO_DESCRIPCION,
		'SI' INCLUIRSE,
		'' DESCRIPCION
FROM	SI_PERIODO P
INNER JOIN	SI_PERIODOSxCUBO PC
ON		P.CLA_PERIODO = PC.CLA_PERIODO
INNER JOIN SI_CPTO_LLAVE CL
ON		PC.CLA_PERIODO = CL.CLA_PERIODO
AND		PC.CLA_CONCEPTO = CL.CLA_CONCEPTO
INNER JOIN	SI_DESCRIP_ENC DE
ON		CL.CLA_DESCRIP = DE.CLA_DESCRIP
WHERE	PC.CLA_CONCEPTO = @CLA_CONCEPTO
AND		P.CLA_PERIODO IN
(
	SELECT
	   DISTINCT CLA_PERIODO 
	FROM
	   SI_CPTO_LLAVE 
	WHERE
	   NOT CLA_PERIODO IS NULL
	   AND CLA_PERIODO <> -1 
	   AND CLA_CONCEPTO = @CLA_CONCEPTO
)
ORDER BY	PERIODO_TIEMPO";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_CONCEPTO", cla_concepto);

            return SqlDB.Query(sqlstr, m_params);
        } // End GetDataTable


        #endregion
    } // End Class Vista_Periodos_Cubo
}
