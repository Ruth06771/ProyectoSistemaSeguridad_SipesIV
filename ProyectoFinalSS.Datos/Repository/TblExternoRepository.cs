using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblExternoRepository : ITblExternoRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblExternoRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblExterno externo)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblexterno_crear", new
            {
                sExterno_nm = externo.sExterno_nm

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblExterno externo)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblexterno_actualizar", new TblExterno
            {
                lGrupo_id = externo.lGrupo_id,
                sExterno_nm = externo.sExterno_nm
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idExterno)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblexterno_eliminar", new
            {
                lGrupo_id = idExterno
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblExterno>> ObtenerTodos()
        {
            IEnumerable<TblExterno> resultado = await _database.GetData<TblExterno>("fn_tblexterno_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblExterno> ObtenerPorId(int idExterno)
        {
            IEnumerable<TblExterno> resultado = await _database.GetData<TblExterno>("fn_tblexterno_obtener_por_id", new
            {
                lGrupo_id = idExterno
            });
            return resultado.FirstOrDefault();
        }
    }
}
