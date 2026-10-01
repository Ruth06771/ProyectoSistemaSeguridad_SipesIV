using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblTiposAccesoRepository : ITblTiposAccesoRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblTiposAccesoRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblTiposAccesos TiposAcceso)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbltiposacceso_crear", new
            {
                sTRegistro_nombre = TiposAcceso.sTRegistro_nombre,
                sTRegistro_estado = TiposAcceso.sTRegistro_estado,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblTiposAccesos TiposAcceso)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbltiposacceso_actualizar", new TblTiposAccesos
            {
                lTRegistro_id = TiposAcceso.lTRegistro_id,
                sTRegistro_nombre = TiposAcceso.sTRegistro_nombre,
                sTRegistro_estado = TiposAcceso.sTRegistro_estado,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idTiposAcceso)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbltiposacceso_eliminar", new
            {
                lTRegistro_id = idTiposAcceso
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblTiposAccesos>> ObtenerTodos()
        {
            IEnumerable<TblTiposAccesos> resultado = await _database.GetData<TblTiposAccesos>("fn_tbltiposacceso_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblTiposAccesos> ObtenerPorId(int idTiposAcceso)
        {
            IEnumerable<TblTiposAccesos> resultado = await _database.GetData<TblTiposAccesos>("fn_tbltiposacceso_obtener_por_id", new
            {
                lTRegistro_id = idTiposAcceso
            });
            return resultado.FirstOrDefault();
        }
    }
}
