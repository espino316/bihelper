using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Xml;

namespace BIHelper.lib
{
    /// <summary>
    /// Esta clase contiene métodos y funciones para interactuar con un
    /// servidor de base de datos MS SQL Server
    /// </summary>
    public class SqlServerHelper
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="SqlServerHelper"/>
        /// </summary>
        public SqlServerHelper()
        {
        }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="SqlServerHelper"/>
        /// </summary>
        /// <param name="server">El nombre del servidor</param>
        /// <param name="database">El nombre de la base de datos</param>
        /// <param name="userid">El nombre de usuario</param>
        /// <param name="password">La constraseña de usuario</param>
        public SqlServerHelper(string server, string database, string userid, string password)
        {
            //  Configuramos las propiedades
            this.Server = server;
            this.DataBase = database;
            this.UserID = userid;
            this.Password = password;

            //  Establecemos la conexión
            this.SetConnStr();

            //  Intentamos conectarnos al servidor
            if (!TryConnect(this.connStr))
                throw new Exception("No se puede conectar a la base de datos");
        }

        #endregion

        #region Properties

        /// <summary>
        /// Representa la cadena de conexión al servidor MS SQL Server
        /// </summary>
        public string connStr;

        #endregion

        /// <summary>
        /// Establece la cadena de conexión al servidor
        /// </summary>
        public void SetConnStr()
        {
            connStr = "Server=@Server; DataBase=@DataBase; User ID=@UserID; Password=@Pwd";
            connStr = connStr.Replace("@Server", Server);
            connStr = connStr.Replace("@DataBase", DataBase);
            connStr = connStr.Replace("@UserID", UserID);
            connStr = connStr.Replace("@Pwd", Password);
        }

        /// <summary>
        /// El nombre de la instancia del servidor MS SQL Server a conectarse
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// El nombre de la base de datos
        /// </summary>
        public string DataBase { get; set; }

        /// <summary>
        /// El nombre de usuario
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// El password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Conexión a la base de datos a utilizar
        /// </summary>
        private SqlConnection conn;

        /// <summary>
        /// Transacción de base de datos a utilizar
        /// </summary>
        private SqlTransaction tran;

        /// <summary>
        /// Esta variable servirá para indicar si la consulta actual
        /// se manejará como dentro de una transacción manejada
        /// </summary>
        private bool IsTransaction = false;

        /// <summary>
        /// Establece el inicio de una transacción
        /// </summary>
        public void BeginTransaction()
        {
            IsTransaction = true;
            conn = new SqlConnection(connStr);
            conn.Open();
            tran = conn.BeginTransaction();
        }

        /// <summary>
        /// Registra la transacción en la base de datos
        /// </summary>
        public void CommitTransaction()
        {
            if (tran != null)
            {
                tran.Commit();
            }

            conn.Close();

            IsTransaction = false;
        }

        /// <summary>
        /// Cancela la transacción y devuelve los objetos afectados a su estado anterior
        /// </summary>
        public void RollBackTransaction()
        {
            if (tran != null)
            {
                tran.Rollback();
            }

            conn.Close();

            IsTransaction = false;
        }

        /// <summary>
        /// Cierra la conexión con la base de datos
        /// </summary>
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        /// <summary>
        /// Realiza un intento de conexión a un servidor SQL
        /// </summary>
        /// <param name="connectionstring">La cadena de conexión a utlizar</param>
        /// <returns></returns>
        public bool TryConnect(string connectionstring)
        {
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = connectionstring;
                sqlcon.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        /// <summary>
        /// Determina si un expresión es nula o vación
        /// </summary>
        /// <param name="expression">La expresión</param>
        /// <returns></returns>
        public bool IsNullOrEmpty(object expression)
        {
            if (expression == null || Convert.IsDBNull(expression))
            {
                return true;
            }
            else
            {
                if (expression.GetType() == typeof(string))
                {
                    if ((string)expression == "" || (string)expression == string.Empty)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Determina si una cadena es numerica
        /// </summary>
        /// <param name="valor">El valor a evaluar</param>
        /// <returns>bool</returns>
        public bool IsNumeric(object valor)
        {
            Decimal d;
            return Decimal.TryParse(valor.ToString(), out d);
        }
        
        /// <summary>
        /// Regresa el último ID utilizado,
        /// Sirve para conocer el dato y asignarlo en la aplicación
        /// Si no lo sabes con anticipación, un returning debe ser usado
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public object Ident_Current(string columnName, string tableName)
        {
            string sqlstr = String.Format("SELECT MAX({0}) FROM {1};", columnName, tableName);
            return QueryScalar(sqlstr);
        }

        /// <summary>
        /// Obtiene la fecha actual del servidor de base de datos
        /// </summary>
        /// <returns></returns>
        public DateTime GetDate()
        {
            string sqlstr = "SELECT GETDATE()";
            return (DateTime)QueryScalar(sqlstr);
        }

        /// <summary>
        /// Consulta una columna XML desde SqlServer
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public XmlDocument GetXMLColumn(string query)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                XmlDocument xdoc = new XmlDocument();
                XmlReader reader = command.ExecuteXmlReader();
                if (reader.Read())
                    xdoc.Load(reader);

                return xdoc;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
             
        } // end GetXMLColumn

        /// <summary>
        /// Devuelve un DataTable a partir de un consulta
        /// </summary>
        /// <param name="query">La consulta SQL</param>
        /// <returns></returns>
        public DataTable Query(string query)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "SqlDATA");

                return ds.Tables[0];
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public DataTable Query

        /// <summary>
        /// Devuelve un DataTable a partir de una consulta parametrizada
        /// </summary>
        /// <param name="m_command">La consulta SQL</param>
        /// <param name="m_params">Los parámetros</param>
        /// <returns></returns>
        public DataTable Query(string m_command, Hashtable m_params)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = m_command;
                command.Parameters.Clear();

                foreach (string key in m_params.Keys)
                {
                    if (m_params[key] == null)
                    {
                        command.Parameters.AddWithValue(key, DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(key, m_params[key]);
                    }
                }

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "SqlDATA");

                return ds.Tables[0];
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public DataTable QueryCommand

        /// <summary>
        /// Devuelve un objeto escalar a partir de un consulta
        /// </summary>
        /// <param name="sqlQry">La consulta SQL</param>
        /// <param name="params">Los parámetros</param>
        /// <returns></returns>
        public object QueryScalar(string sqlQry, Hashtable @params)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                object result;
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlQry;
                command.Parameters.Clear();
                foreach (string k in @params.Keys)
                {
                    command.Parameters.AddWithValue(k, @params[k]);
                }
                result = command.ExecuteScalar();
                return result;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public static object QueryScalar

        /// <summary>
        /// Obtiene un objeto escalar a partir de una consulta
        /// </summary>
        /// <param name="sqlQry">La consulta SQL</param>
        /// <returns></returns>
        public object QueryScalar(string sqlQry)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlQry;

                Object Result = command.ExecuteScalar();
                return Result;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public static object QueryScalar

        /// <summary>
        /// Ejecuta una consulta de actualización (Update, Insert, Delete)
        /// </summary>
        /// <param name="execQuery">La consulta de actualización</param>
        public void NonQuery(string execQuery)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = execQuery;
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public void ExecuteQuery

        /// <summary>
        /// Ejecuta una consulta de actualización (Update, Insert, Delete)
        /// </summary>
        /// <param name="execQuery">La consulta de actualización</param>
        /// <param name="m_params">Los parámetros</param>
        public void NonQuery(string execQuery, Hashtable m_params)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = execQuery;
                command.Parameters.Clear();

                foreach (string key in m_params.Keys)
                {
                    command.Parameters.AddWithValue(key, m_params[key]);
                }
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public void ExecuteCommand

        /// <summary>
        /// Executa un procedimiento almacenado en la base de datos
        /// </summary>
        /// <param name="sp_name">El nombre del procedimiento almacenado</param>
        /// <returns></returns>
        public int SPNonQuery(string sp_name, Hashtable @params)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
            command.Parameters.Clear();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp_name;

            if (@params != null)
            {
                foreach (string k in @params.Keys)
                {
                    if (@params[k] == null)
                    {
                        command.Parameters.AddWithValue(k, DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(k, @params[k]);
                    }
                }
            }

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        /// <summary>
        /// Devuelte un DataTable a partir de una procedimiento almacenado
        /// </summary>
        /// <param name="sp_name">El nombre del procedimiento almacenado</param>
        /// <param name="m_params">Los parámetros</param>
        /// <returns></returns>
        public DataTable SPQuery(string sp_name, Hashtable m_params)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sp_name;
                command.Parameters.Clear();

                foreach (string key in m_params.Keys)
                {
                    if (m_params[key] == null)
                    {
                        command.Parameters.AddWithValue(key, DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(key, m_params[key]);
                    }
                }

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "SqlDATA");

                return ds.Tables[0];
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public DataTable QueryCommand

        #region ActiveRecord

        /// <summary>
        /// </summary>
        /// <param name="strTabla"></param>
        /// <param name="params"></param>
        /// <returns></returns>
        public int IdentityInsertRow(string strTabla, Hashtable @params)
        {
            string strSQL = String.Format("SET IDENTITY_INSERT {0} ON \r\n INSERT INTO {0} (", strTabla);
            int cont = 0;
            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k;
                }
                else
                {
                    strSQL += "," + k;
                }
                cont += 1;
            }

            strSQL += ") VALUES (";
            cont = 0;

            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += "@" + k;
                }
                else
                {
                    strSQL += ", @" + k;
                }
                cont += 1;
            }

            strSQL += String.Format(") \r\n SET IDENTITY_INSERT {0} OFF", strTabla);

            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
            command.Parameters.Clear();
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            foreach (string k in @params.Keys)
            {
                if (@params[k] == null)
                {
                    command.Parameters.AddWithValue("@" + k, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + k, @params[k]);
                }
            }

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public int InsertRow

        /// <summary>
        /// Ejecuta una inserción en la base de datos
        /// </summary>
        /// <param name="strTabla">La tabla en la que se insertarán los registros</param>
        /// <param name="params">Los parámetros del registro a insertar</param>
        /// <returns></returns>
        public int Insert(string strTabla, Hashtable @params)
        {
            string strSQL = "INSERT INTO " + strTabla + " (";
            int cont = 0;
            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k;
                }
                else
                {
                    strSQL += "," + k;
                }
                cont += 1;
            }

            strSQL += ") VALUES (";
            cont = 0;

            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += "@" + k;
                }
                else
                {
                    strSQL += ", @" + k;
                }
                cont += 1;
            }

            strSQL += ")";

            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
            command.Parameters.Clear();
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            foreach (string k in @params.Keys)
            {
                if (@params[k] == null)
                {
                    command.Parameters.AddWithValue("@" + k, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + k, @params[k]);
                }
            }

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public int InsertRow

        /// <summary>
        /// Devuelve una DataTable a partir del nombre de una tabla. El DataTable contendrá
        /// todos los registros de la tabla
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public DataTable Select(string tablename)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM " + tablename;
                command.Parameters.Clear();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "SqlDATA");

                return ds.Tables[0];
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        /// <summary>
        /// Devuelve un DataTable a partir del nombre de una tabla, parámetros de consulta y ordenamiento
        /// </summary>
        /// <param name="tablename">El nombre de la tabla</param>
        /// <param name="w_params">Los parámetros de búsqueda</param>
        /// <param name="sort">Las columnas de ordenamiento</param>
        /// <returns></returns>
        public DataTable Select(string tablename, Hashtable w_params = null, string sort = null)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;                
                command.CommandText = SelectStatement(tablename, w_params, sort);
                command.Parameters.Clear();

                if (w_params != null)
                {
                    foreach (string key in w_params.Keys)
                    {
                        if (w_params[key] == null)
                        {
                            command.Parameters.AddWithValue(key, DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(key, w_params[key]);
                        }
                    }
                }
                
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "SqlDATA");

                return ds.Tables[0];
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        /// <summary>
        /// Devuelve la cantidad de registros en una tabla, a partir del nombre de la misma  y
        /// parámetros de búsqueda
        /// </summary>
        /// <param name="tablename">El nombre de la tabla</param>
        /// <param name="w_params">Los parámetros de búsqueda</param>
        /// <returns></returns>
        public int GetCount(string tablename, Hashtable w_params)
        {
            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            try
            {
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = SelectCountStatement(tablename, w_params);
                command.Parameters.Clear();

                foreach (string key in w_params.Keys)
                {
                    command.Parameters.AddWithValue(key, w_params[key]);
                }

                Object Result = command.ExecuteScalar();
                return (int)Result;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        /// <summary>
        /// Devuelve una instrucción "SELECT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="top">Número de registros a devolver</param>
        /// <param name="filter">Filtro a aplicar</param>
        /// <param name="sort">Columnas de ordenamiento</param>
        /// <returns></returns>
        public string SelectStatement(string strTabla, int top, string filter, string sort)
        {
            string strSQL = "";

            strSQL += "SELECT FIRST " + top.ToString() + " * FROM " + strTabla + " WHERE " + filter;

            if (!String.IsNullOrEmpty(sort)) strSQL += " ORDER BY " + sort;

            return strSQL;

        } // End SelectStatement

        /// <summary>
        /// Devuelve una instrucción "SELECT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="params">Las columnas a devolver</param>
        /// <param name="whereParams">Los parámetros de búsqueda</param>
        /// <returns></returns>
        public string SelectStatement(string strTabla, Hashtable @params, Hashtable @whereParams)
        {
            int cont;
            string strSQL = "";
            strSQL += "SELECT ";
            cont = 0;

            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k;
                }
                else
                {
                    strSQL += ", " + k;
                }
                cont += 1;
            }

            cont = 0;
            strSQL += " FROM " + strTabla + " WHERE ";
            foreach (string k in @whereParams.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += " AND " + k + " = @" + k;
                }
                cont += 1;
            }

            return strSQL;
        } // End SelectStatement

        /// <summary>
        /// Devuelve una instrucción "SELECT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <returns></returns>
        public string SelectStatement(string strTabla)
        {
            string strSQL = "";
            strSQL += "SELECT * FROM " + strTabla;

            return strSQL;
        } // End SelectStatement

        /// <summary>
        /// Devuelve una instrucción "SELECT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="filter">El filtro a aplicar</param>
        /// <param name="sort">El criterio de ordenamiento</param>
        /// <returns></returns>
        public string SelectStatement(string strTabla, string filter, string sort)
        {
            string strSQL = "";
            strSQL += "SELECT * FROM " + strTabla;
            if (!String.IsNullOrEmpty(filter)) strSQL += " WHERE " + filter;
            if (!String.IsNullOrEmpty(sort)) strSQL += " ORDER BY " + sort;

            return strSQL;
        } // End SelectStatement

        /// <summary>
        /// Devuelve una instrucción "SELECT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="strCampo">El campo a devolver</param>
        /// <param name="whereParams">Los parámetros de búsqueda</param>
        /// <returns></returns>
        public string SelectScalarStatement(string strTabla, string strCampo, Hashtable @whereParams)
        {
            int cont;
            string strSQL = "";
            strSQL += "SELECT " + strCampo + " FROM " + strTabla + " WHERE ";
            cont = 0;

            foreach (string k in @whereParams.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += " AND " + k + " = @" + k;
                }
                cont += 1;
            }

            return strSQL;
        } // End SelectStatement

        /// <summary>
        /// Devuelve una instrucción "SELECT COUNT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="whereParams">Los parámetros de búsqueda</param>
        /// <returns></returns>
        public string SelectCountStatement(string strTabla, Hashtable @whereParams)
        {
            int cont;
            string strSQL = "";
            strSQL += "SELECT COUNT(*) FROM " + strTabla + " WHERE ";
            cont = 0;

            foreach (string k in @whereParams.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += " AND " + k + " = @" + k;
                }
                cont += 1;
            }

            return strSQL;
        } // End SelectStatement

        /// <summary>
        /// Devuelve una instrucción "SELECT" SQL a partir de parámetros
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="whereParams">Los parámetros de búsqueda</param>
        /// <param name="sort">El criterio de ordenamiento</param>
        /// <returns></returns>
        public string SelectStatement(string strTabla, Hashtable @whereParams = null, string sort = null)
        {
            int cont;
            string strSQL = "";
            strSQL += "SELECT * FROM " + strTabla;
            cont = 0;

            if (@whereParams != null)
            {
                strSQL += " WHERE ";

                foreach (string k in @whereParams.Keys)
                {
                    if (cont == 0)
                    {
                        strSQL += k + " = @" + k;
                    }
                    else
                    {
                        strSQL += " AND " + k + " = @" + k;
                    }
                    cont += 1;
                }
            }
            
            if (!string.IsNullOrEmpty(sort))
                strSQL += " ORDER BY " + sort;

            return strSQL;
        } // End SelectStatement

        /// <summary>
        /// Borra todos los registros de una tabla
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <returns></returns>
        public int DeleteAllRows(string strTabla)
        {
            string strSQL = "DELETE FROM " + strTabla;

            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();

            command.Parameters.Clear();
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        /// <summary>
        /// Borra registros en una tabla a partir de parámetros de búsqueda
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="whereParams">Los parámetros de búsqueda</param>
        /// <returns></returns>
        public int Delete(string strTabla, Hashtable @whereParams)
        {
            string strSQL = "DELETE FROM " + strTabla + " ";
            int cont = 0;

            strSQL += " WHERE ";

            foreach (string k in @whereParams.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += " AND " + k + " = @" + k;
                }
                cont += 1;
            }

            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
            command.Parameters.Clear();
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            foreach (string k in @whereParams.Keys)
            {
                if (@whereParams[k] == null)
                {
                    command.Parameters.AddWithValue("@" + k, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + k, @whereParams[k]);
                }
            }

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // public int DeleteRow

        /// <summary>
        /// Actualiza una tabla
        /// </summary>
        /// <param name="strTabla">La tabla</param>
        /// <param name="params">Los campos y valores a actualizar</param>
        /// <returns></returns>
        public int UpdateRow(string strTabla, Hashtable @params)
        {
            string strSQL = "UPDATE " + strTabla + " SET ";
            int cont = 0;
            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += ", " + k + " = @" + k;
                }
                cont += 1;
            }

            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
            command.Parameters.Clear();
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            foreach (string k in @params.Keys)
            {
                if (@params[k] == null)
                {
                    command.Parameters.AddWithValue("@" + k, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + k, @params[k]);
                }
            }

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // int UpdateRow

        /// <summary>
        /// Actualiza registros en una tabla a partir de parámetros de búsqueda
        /// </summary>
        /// <param name="strTabla">El nombre de la tabla</param>
        /// <param name="params">Los campos y valores a actualizar</param>
        /// <param name="whereParams">Los parámetros de búsqueda</param>
        /// <returns></returns>
        public int Update(string strTabla, Hashtable @params, Hashtable @whereParams)
        {

            string strSQL = "UPDATE " + strTabla + " SET ";
            int cont = 0;
            foreach (string k in @params.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += ", " + k + " = @" + k;
                }
                cont += 1;
            }

            strSQL += " WHERE ";
            cont = 0;

            foreach (string k in @whereParams.Keys)
            {
                if (cont == 0)
                {
                    strSQL += k + " = @" + k;
                }
                else
                {
                    strSQL += " AND " + k + " = @" + k;
                }
                cont += 1;
            }

            SqlCommand command = new SqlCommand();

            if (IsTransaction)
            {
                command.Connection = conn; command.Transaction = tran;
            }
            else
            {
                command.Connection = new SqlConnection(connStr);
            }

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
            command.Parameters.Clear();
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            foreach (string k in @params.Keys)
            {
                if (@params[k] == null)
                {
                    command.Parameters.AddWithValue("@" + k, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + k, @params[k]);
                }
            }

            foreach (string k in @whereParams.Keys)
            {
                if (@whereParams[k] == null)
                {
                    command.Parameters.AddWithValue("@" + k, DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@" + k, @whereParams[k]);
                }
            }

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!IsTransaction)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        } // int UpdateRow

        #endregion

        /// <summary>
        /// Regresa un entero nulable a partir de una expresión evaluada
        /// </summary>
        /// <param name="expression">La expresión a evaluar</param>
        /// <returns>int?</returns>
        public int? GetNullableInt32(object expression)
        {
            if (expression == null || Convert.IsDBNull(expression))
            {
                return null;
            }
            else
            {
                if (expression.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)expression))
                    {
                        return null;
                    }
                }

                if (!this.IsNumeric(expression))
                {
                    throw new Exception(String.Format("{0} no es numérica", expression));
                }
                return Convert.ToInt32(expression);
            }
        }

        /// <summary>
        /// Regresa un entero nulable a partir de una expresión evaluada
        /// </summary>
        /// <param name="expression">La expresión a evaluar</param>
        /// <returns>int?</returns>
        public short? GetNullableInt16(object expression)
        {
            if (expression == null || Convert.IsDBNull(expression))
            {
                return null;
            }
            else
            {
                if (expression.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)expression))
                    {
                        return null;
                    }
                }

                if (!this.IsNumeric(expression))
                {
                    throw new Exception(String.Format("{0} no es numérica", expression));
                }
                return Convert.ToInt16(expression);
            }
        }

        /// <summary>
        /// Regresa una valor DateTime nulable a partir de un expresión evaluada
        /// </summary>
        /// <param name="expression">La expresión a evaluar</param>
        /// <returns></returns>
        public DateTime? GetNullableDateTime(object expression)
        {
            if (expression == null || Convert.IsDBNull(expression))
            {
                return null;
            }
            else
            {
                if (expression.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)expression))
                    {
                        return null;
                    }
                }
                return Convert.ToDateTime(expression);
            }
        }

        /// <summary>
        /// Devuelve un Decimal nulable a partir de una expresión evaluada
        /// </summary>
        /// <param name="expression">La expresión a evaluar</param>
        /// <returns></returns>
        public decimal? GetNullableDecimal(object expression)
        {
            if (expression == null || Convert.IsDBNull(expression))
            {
                return null;
            }
            else
            {
                if (expression.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)expression))
                    {
                        return null;
                    }
                }
                if (!this.IsNumeric(expression))
                {
                    throw new Exception(String.Format("{0} no es numérica", expression));
                }
                return Convert.ToDecimal(expression);
            }
        }

        /// <summary>
        /// Devuelve un valor Booleano nulable a partir de una expresión evaluada
        /// </summary>
        /// <param name="expression">La expresión a evaluar</param>
        /// <returns></returns>
        public Boolean? GetNullableBoolean(object expression)
        {
            if (expression == null || Convert.IsDBNull(expression))
            {
                return null;
            }
            else
            {
                if (expression.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)expression))
                    {
                        return null;
                    }
                }
                return Convert.ToBoolean(expression);
            }
        }

    } // end class
}
