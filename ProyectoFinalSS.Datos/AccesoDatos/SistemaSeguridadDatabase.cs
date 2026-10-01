using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;

namespace ProyectoFinalSS.Datos.AccesoDatos
{
    public class SistemaSeguridadDatabase
    {
        private readonly IConfiguration _configuration;

        public SistemaSeguridadDatabase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<T>> GetData<T>(string functionName, object parameters = null)
        {
            using IDbConnection conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            try
            {
                string sql;

                if (parameters == null)
                {
                    sql = $"SELECT * FROM dbo.[{functionName}]()";
                }
                else
                {
                    var propNames = parameters.GetType().GetProperties().Select(p => $"@{p.Name}");
                    var paramNames = string.Join(", ", propNames);

                    sql = $"SELECT * FROM dbo.[{functionName}]({paramNames})";
                }

                return await conn.QueryAsync<T>(sql, parameters, commandType: CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al ejecutar la función {functionName}: {ex.Message}", ex);
            }
        }
    }
}