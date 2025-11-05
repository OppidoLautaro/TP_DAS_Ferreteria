using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DAL
{
    public class Acceso
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void Conectar()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=TPFerreteria;Integrated Security=True;Encrypt=False;";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
            cn.Dispose();
        }

        public DataTable Leer(string SP, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            Conectar();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            cmd.Parameters.Clear();
            Desconectar();
            return dataTable;
        }

        public int Escribir(string sp, SqlParameter[] parameters)
        {
            int fa = 0;

            Conectar();

            SqlTransaction ST = cn.BeginTransaction();

            try
            {
                cmd.Connection = cn;
                cmd.Transaction = ST;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                    fa = cmd.ExecuteNonQuery();
                }
                else
                {
                    fa = cmd.ExecuteNonQuery();
                }

                ST.Commit();
            }
            catch (Exception)
            {
                ST.Rollback();
            }

            cmd.Parameters.Clear();
            Desconectar();

            return fa;
        }
    }
}
