using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BIHelper.lib.artus
{
    /// <summary>
    /// Esta clase representa un conjunto de registros de indicadores
    /// en un cubo de Artus
    /// </summary>
    public class Vista_Indicadores_Cubo
    {

        #region Constructors
        public Vista_Indicadores_Cubo()
        {
        }

        public Vista_Indicadores_Cubo(
            System.Int32? cla_concepto,
            System.String nom_indicador,
            System.String tipo,
            System.String formato,
            System.String tabla,
            System.String campo,
            System.String tipodato,
            System.String agrupacion,
            System.String alarma_o_propiedad,
            System.String descripcion,
            System.String formula_bd
            )
        {
            this.CLA_CONCEPTO = cla_concepto;
            this.NOM_INDICADOR = nom_indicador;
            this.TIPO = tipo;
            this.FORMATO = formato;
            this.TABLA = tabla;
            this.CAMPO = campo;
            this.TIPODATO = tipodato;
            this.AGRUPACION = agrupacion;
            this.ALARMA_O_PROPIEDAD = alarma_o_propiedad;
            this.DESCRIPCION = descripcion;
            this.FORMULA_BD = formula_bd;
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

        private System.String _NOM_INDICADOR;
        public System.String NOM_INDICADOR
        {
            get { return _NOM_INDICADOR; }
            set { _NOM_INDICADOR = value; }
        }

        private System.String _TIPO;
        public System.String TIPO
        {
            get { return _TIPO; }
            set { _TIPO = value; }
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

        private System.String _CAMPO;
        public System.String CAMPO
        {
            get { return _CAMPO; }
            set { _CAMPO = value; }
        }

        private System.String _TIPODATO;
        public System.String TIPODATO
        {
            get { return _TIPODATO; }
            set { _TIPODATO = value; }
        }

        private System.String _AGRUPACION;
        public System.String AGRUPACION
        {
            get { return _AGRUPACION; }
            set { _AGRUPACION = value; }
        }

        private System.String _ALARMA_O_PROPIEDAD;
        public System.String ALARMA_O_PROPIEDAD
        {
            get { return _ALARMA_O_PROPIEDAD; }
            set { _ALARMA_O_PROPIEDAD = value; }
        }

        private System.String _DESCRIPCION;
        public System.String DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }

        private System.String _FORMULA_BD;
        public System.String FORMULA_BD
        {
            get { return _FORMULA_BD; }
            set { _FORMULA_BD = value; }
        }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!Convert.IsDBNull(obj) && obj != null)
            {
                Vista_Indicadores_Cubo instance =
                (Vista_Indicadores_Cubo)obj;

                return (
                    this.AGRUPACION.Equals(instance.AGRUPACION) &&
                    this.ALARMA_O_PROPIEDAD.Equals(instance.ALARMA_O_PROPIEDAD) &&
                    this.CAMPO.Equals(instance.CAMPO) &&
                    this.CLA_CONCEPTO.Equals(instance.CLA_CONCEPTO) &&
                    this.DESCRIPCION.Equals(instance.DESCRIPCION) &&
                    this.FORMATO.Equals(instance.FORMATO) &&
                    this.FORMULA_BD.Equals(instance.FORMULA_BD) &&
                    this.NOM_INDICADOR.Equals(instance.NOM_INDICADOR) &&
                    this.TABLA.Equals(instance.TABLA) &&
                    this.TIPO.Equals(instance.TIPO) &&
                    this.TIPODATO.Equals(instance.TIPODATO)
                );
            }
            else
            {
                return base.Equals(obj);
            }
        }

        public override string ToString()
        {
            return this.NOM_INDICADOR;
        }

        public Vista_Indicadores_Cubo GetByCLA_INDICADOR(
            int cla_indicador
        )
        {
            string sqlstr = @"SELECT
	I.CLA_CONCEPTO,
	I.NOM_INDICADOR,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN 'NATIVO'   
	  ELSE 'CALCULADO'   
	END TIPO,
	I.FORMATO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN C.NOM_TABLA   
	  ELSE 'REFERENCIA A OTRO(S) INDICADORES(S)'   
	END TABLA,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN A.NOM_FISICO   
	  ELSE I.FORMULA_USR   
	END CAMPO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN T.NOM_DATO   
	  ELSE 'float'   
	END TIPODATO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN A.AGRUPADOR   
	  ELSE 'CALCULADO'   
	END AGRUPACION,
	ISNULL(I.DIM_ALARM, '') [ALARMA_O_PROPIEDAD],
	ISNULL(I.DESCRIPCION, '') DESCRIPCION,
	I.FORMULA_BD 
FROM
   SI_INDICADOR I   
INNER JOIN
   SI_CONCEPTO C    
      ON I.CLA_CONCEPTO = C.CLA_CONCEPTO   
LEFT JOIN
   SI_CPTO_ATRIB A    
      ON I.CLA_CONCEPTO = A.CLA_CONCEPTO     
      AND I.NOM_INDICADOR = A.NOM_LOGICO     
      AND A.ESTATUS <> 2    
LEFT JOIN
   SI_BD_TIPOS T    
      ON A.TIPO_DATO = T.TIPO_DATO     
      AND T.CLA_BD = C.CLA_BD  
WHERE
   I.CLA_INDICADOR = @CLA_INDICADOR  
   AND  I.NOM_INDICADOR IS NOT NULL   
   AND  I.NOM_INDICADOR <> ''   
   AND  ISNULL(NO_EJECUTIVO,0) = 0  
ORDER BY
   I.NOM_INDICADOR";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_INDICADOR", cla_indicador);

            DataTable dt = SqlDB.Query(sqlstr, m_params);

            Vista_Indicadores_Cubo indicador = null;

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                indicador = new Vista_Indicadores_Cubo(
                        SqlDB.GetNullableInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToString(dr["NOM_INDICADOR"]),
                        Convert.ToString(dr["TIPO"]),
                        Convert.ToString(dr["FORMATO"]),
                        Convert.ToString(dr["TABLA"]),
                        Convert.ToString(dr["CAMPO"]),
                        Convert.ToString(dr["TIPODATO"]),
                        Convert.ToString(dr["AGRUPACION"]),
                        Convert.ToString(dr["ALARMA_O_PROPIEDAD"]),
                        Convert.ToString(dr["DESCRIPCION"]),
                        Convert.ToString(dr["FORMULA_BD"])
                        );
            }

            return indicador;
        }

        public List<Vista_Indicadores_Cubo> Get(
            System.Int32? cla_concepto)
        {
            string sqlstr = @"SELECT
	I.CLA_CONCEPTO,
	I.NOM_INDICADOR,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN 'NATIVO'   
	  ELSE 'CALCULADO'   
	END TIPO,
	I.FORMATO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN C.NOM_TABLA   
	  ELSE 'REFERENCIA A OTRO(S) INDICADORES(S)'   
	END TABLA,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN A.NOM_FISICO   
	  ELSE I.FORMULA_USR   
	END CAMPO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN T.NOM_DATO   
	  ELSE 'float'   
	END TIPODATO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN A.AGRUPADOR   
	  ELSE 'CALCULADO'   
	END AGRUPACION,
	ISNULL(I.DIM_ALARM, '') [ALARMA_O_PROPIEDAD],
	ISNULL(I.DESCRIPCION, '') DESCRIPCION,
	I.FORMULA_BD 
FROM
   SI_INDICADOR I   
INNER JOIN
   SI_CONCEPTO C    
      ON I.CLA_CONCEPTO = C.CLA_CONCEPTO   
LEFT JOIN
   SI_CPTO_ATRIB A    
      ON I.CLA_CONCEPTO = A.CLA_CONCEPTO     
      AND I.NOM_INDICADOR = A.NOM_LOGICO     
      AND A.ESTATUS <> 2    
LEFT JOIN
   SI_BD_TIPOS T    
      ON A.TIPO_DATO = T.TIPO_DATO     
      AND T.CLA_BD = C.CLA_BD  
WHERE
   I.CLA_CONCEPTO = @CLA_CONCEPTO  
   AND  I.NOM_INDICADOR IS NOT NULL   
   AND  I.NOM_INDICADOR <> ''   
   AND  ISNULL(NO_EJECUTIVO,0) = 0  
ORDER BY
   I.NOM_INDICADOR";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_CONCEPTO", cla_concepto);

            List<Vista_Indicadores_Cubo> list = new List<Vista_Indicadores_Cubo>();
            DataTable dt = SqlDB.Query(sqlstr, m_params);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new Vista_Indicadores_Cubo(
                        SqlDB.GetNullableInt32(dr["CLA_CONCEPTO"]),
                        Convert.ToString(dr["NOM_INDICADOR"]),
                        Convert.ToString(dr["TIPO"]),
                        Convert.ToString(dr["FORMATO"]),
                        Convert.ToString(dr["TABLA"]),
                        Convert.ToString(dr["CAMPO"]),
                        Convert.ToString(dr["TIPODATO"]),
                        Convert.ToString(dr["AGRUPACION"]),
                        Convert.ToString(dr["ALARMA_O_PROPIEDAD"]),
                        Convert.ToString(dr["DESCRIPCION"]),
                        Convert.ToString(dr["FORMULA_BD"])
                        )
                    );
            }
            return list;
        } // End GetData

        public DataTable GetDataTable(
            System.Int32? cla_concepto)
        {
            string sqlstr = @"SELECT
	I.CLA_CONCEPTO,
	I.NOM_INDICADOR,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN 'NATIVO'   
	  ELSE 'CALCULADO'   
	END TIPO,
	I.FORMATO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN C.NOM_TABLA   
	  ELSE 'REFERENCIA A OTRO(S) INDICADORES(S)'   
	END TABLA,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN A.NOM_FISICO   
	  ELSE I.FORMULA_USR   
	END CAMPO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN T.NOM_DATO   
	  ELSE 'float'   
	END TIPODATO,
	CASE   
	  WHEN A.NOM_LOGICO IS NOT NULL THEN A.AGRUPADOR   
	  ELSE 'CALCULADO'   
	END AGRUPACION,
	ISNULL(I.DIM_ALARM, '') [ALARMA_O_PROPIEDAD],
	ISNULL(I.DESCRIPCION, '') DESCRIPCION,
	I.FORMULA_BD 
FROM
   SI_INDICADOR I   
INNER JOIN
   SI_CONCEPTO C    
      ON I.CLA_CONCEPTO = C.CLA_CONCEPTO   
LEFT JOIN
   SI_CPTO_ATRIB A    
      ON I.CLA_CONCEPTO = A.CLA_CONCEPTO     
      AND I.NOM_INDICADOR = A.NOM_LOGICO     
      AND A.ESTATUS <> 2    
LEFT JOIN
   SI_BD_TIPOS T    
      ON A.TIPO_DATO = T.TIPO_DATO     
      AND T.CLA_BD = C.CLA_BD  
WHERE
   I.CLA_CONCEPTO = @CLA_CONCEPTO  
   AND  I.NOM_INDICADOR IS NOT NULL   
   AND  I.NOM_INDICADOR <> ''   
   AND  ISNULL(NO_EJECUTIVO,0) = 0  
ORDER BY
   I.NOM_INDICADOR";

            Hashtable m_params = new Hashtable();
            m_params.Add("@CLA_CONCEPTO", cla_concepto);

            return SqlDB.Query(sqlstr, m_params);
        } // End GetDataTable


        #endregion
    } // End Class Vista_Indicadores_Cubo
}
