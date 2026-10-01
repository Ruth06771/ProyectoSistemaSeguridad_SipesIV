using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblHorarioRepository : ITblHorarioRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblHorarioRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblHorario horario)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblhorario_crear", new
            {
                lArea_id = horario.lArea_id,
                sHorario_fecha_inicio = horario.sHorario_fecha_inicio,
                sHorario_fecha_fin = horario.sHorario_fecha_fin,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblHorario horario)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblhorario_actualizar", new TblHorario
            {
                lhorario_id = horario.lhorario_id,
                lArea_id = horario.lArea_id,
                sHorario_fecha_inicio = horario.sHorario_fecha_inicio,
                sHorario_fecha_fin = horario.sHorario_fecha_fin,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idHorario)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblhorario_eliminar", new
            {
                lhorario_id = idHorario
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblHorario>> ObtenerTodos()
        {
            IEnumerable<TblHorario> resultado = await _database.GetData<TblHorario>("fn_tblhorario_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblHorario> ObtenerPorId(int idHorario)
        {
            IEnumerable<TblHorario> resultado = await _database.GetData<TblHorario>("fn_tblhorario_obtener_por_id", new
            {
                lhorario_id = idHorario
            });
            return resultado.FirstOrDefault();
        }

    }
}
