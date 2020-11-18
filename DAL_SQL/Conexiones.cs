using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_SQL
{
    public class Conexiones
    {
        //PC laburo: protected SqlConnection cn = new SqlConnection(@"Server=CPX-L7QBTQ41YG6\SQLEXPRESS01;Initial Catalog=Bohemia;Integrated Security=True");
        protected SqlConnection cn = new SqlConnection(@"Server=DESKTOP-H982BU0\SQLEXPRESS; Initial Catalog=LastraJulianP2;Integrated Security=True");
        protected SqlTransaction st;

        public string TestBD()
        {
            cn.Open();

            if (cn.State == ConnectionState.Open)
            { cn.Close(); return "Conecto a la base de datos"; }

            else
            { cn.Close(); return "No conecta perro"; }
        }

        public DataTable Read(string query)
        {
            var table = new DataTable();

            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(query, cn);
                Da.Fill(table);
            }
            catch (Exception e)
            {
                throw e;
            }

            //Cerras la conexion aca
            cn.Close();
            return table;
        }

        public DataSet ReadDS(string query)
        {
            DataSet DS = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(DS);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            cn.Close();

            return DS;
        }

        public bool Write(string query)
        {
            cn.Open();
            var cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.CommandText = query;

            try
            {
                int response = cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }
        }

        
        public bool Write(string query, ArrayList ar)
        {
            cn.Open();

            var dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);

            try
            {
                st = cn.BeginTransaction();

                var cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.Transaction = st;

                da = new SqlDataAdapter(query, cn);

                if ((ar != null))
                {
                    //si la el arraylist esta vacia
                    foreach (SqlParameter dato in ar)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
                st.Commit();
                return true;
            }

            catch (SqlException ex)
            {
                throw ex; 
            }
            catch (Exception ex)
            {
               st.Rollback();
                return false;
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
