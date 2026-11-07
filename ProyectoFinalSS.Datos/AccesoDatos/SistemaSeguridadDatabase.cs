using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProyectoFinalSS.Datos.AccesoDatos
{
    public class SistemaSeguridadDatabase
    {
        private readonly IConfiguration _configuration;

        public SistemaSeguridadDatabase(IConfiguration configuration)
        {
            _configuration = configuration;

            // Mapeo dinámico e insensible a mayúsculas/minúsculas y '_' para Dapper
            SqlMapper.TypeMapProvider = type =>
                new CustomPropertyTypeMap(type, (t, columnName) =>
                    t.GetProperties().FirstOrDefault(p =>
                        p.Name.Equals(columnName, StringComparison.OrdinalIgnoreCase) ||
                        p.Name.Replace("_", "").Equals(columnName.Replace("_", ""), StringComparison.OrdinalIgnoreCase))
                );
        }

        public async Task<IEnumerable<T>> GetData<T>(string functionName, object parameters = null)
        {
            // Se agregan comillas al nombre de la cadena de conexión
            using IDbConnection conn = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            try
            {
                string sql;

                if (parameters == null)
                {
                    sql = $"SELECT * FROM {functionName}()";
                }
                else
                {
                    var properties = parameters.GetType().GetProperties();
                    var paramNames = string.Join(", ", properties.Select(p => $"@{p.Name}"));
                    sql = $"SELECT * FROM {functionName}({paramNames})";
                }

                var result = await conn.QueryAsync<T>(sql, parameters, commandType: CommandType.Text);
                return result;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception($"Error al ejecutar la función {functionName}: {ex.Message}", ex);
            }
        }
    }
}