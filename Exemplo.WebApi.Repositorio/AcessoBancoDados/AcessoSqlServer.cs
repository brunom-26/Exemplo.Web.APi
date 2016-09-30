using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Repositorio.AcessoBancoDados
{
    public class AcessoSqlServer
    {
        static string _connectionString = "";

        public AcessoSqlServer()
        {
            _connectionString = "";
        }

        public AcessoSqlServer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable Select(string comando, IList<SqlParameter> parametros = null, bool procedure = false)
        {
            DataTable dt = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(comando, conn);

                    if (procedure)
                        command.CommandType = CommandType.StoredProcedure;

                    foreach (SqlParameter parametro in parametros)
                        command.Parameters.Add(parametro);

                    SqlDataAdapter da = new SqlDataAdapter(command);

                    da.Fill(dt);
                }

                return dt;
            }
            catch (SqlException sEx)
            {

            }
            catch (Exception ex)
            {

            }

            return dt;

        }

        public int NonQuery(string comando, IList<SqlParameter> parametros = null, bool procedure = false)
        {
            int qtdRegistros = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(comando, conn);

                    if (procedure)
                        command.CommandType = CommandType.StoredProcedure;

                    foreach (SqlParameter parametro in parametros)
                        command.Parameters.Add(parametro);

                    qtdRegistros = command.ExecuteNonQuery();
                }
            }
            catch (SqlException sEx)
            {

            }
            catch (Exception ex)
            {

            }

            return qtdRegistros;
        }
    }
}
