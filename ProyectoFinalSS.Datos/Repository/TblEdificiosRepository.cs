using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblEdificiosRepository : ITblEdificiosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblEdificiosRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblEdificios edificios)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbledificios_crear", new
            {
                sEdificio_nombre = edificios.sEdificio_nombre,
                sEdificio_estado = edificios.sEdificio_estado,
                sEdificio_descripcion = edificios.sEdificio_descripcion,

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblEdificios edificios)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbledificios_actualizar", new TblEdificios
            {
                lEdificio_id = edificios.lEdificio_id,
                sEdificio_nombre = edificios.sEdificio_nombre,
                sEdificio_estado = edificios.sEdificio_estado,
                sEdificio_descripcion = edificios.sEdificio_descripcion,

            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idEdificios)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbledificios_eliminar", new
            {
                lEdificio_id = idEdificios
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblEdificios>> ObtenerTodos()
        {
            IEnumerable<TblEdificios> resultado = await _database.GetData<TblEdificios>("fn_tblacademico_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblEdificios> ObtenerPorId(int idEdificios)
        {
            IEnumerable<TblEdificios> resultado = await _database.GetData<TblEdificios>("fn_tblacademico_obtener_por_id", new
            {
                lEdificio_id = idEdificios
            });
            return resultado.FirstOrDefault();
        }
    }
}
