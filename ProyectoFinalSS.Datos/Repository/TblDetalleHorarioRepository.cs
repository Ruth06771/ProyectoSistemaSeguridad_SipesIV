using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblDetalleHorarioRepository : ITblDetalleHorarioRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblDetalleHorarioRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblDetalleHorario DetalleHorario)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbldetallehorario_crear", new
            {
                lhorario_id = DetalleHorario.lhorario_id,
                lGrupo_id = DetalleHorario.lGrupo_id,
                sDetalleHorario_dia = DetalleHorario.sDetalleHorario_dia,
                sDetalleHorario_hora_inicio = DetalleHorario.sDetalleHorario_hora_inicio,
                sDetalleHorario_hora_fin = DetalleHorario.sDetalleHorario_hora_fin,

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblDetalleHorario DetalleHorario)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbldetallehorario_actualizar", new TblDetalleHorario
            {
                lDetalleHorario_id = DetalleHorario.lDetalleHorario_id,
                lhorario_id = DetalleHorario.lhorario_id,
                lGrupo_id = DetalleHorario.lGrupo_id,
                sDetalleHorario_dia = DetalleHorario.sDetalleHorario_dia,
                sDetalleHorario_hora_inicio = DetalleHorario.sDetalleHorario_hora_inicio,
                sDetalleHorario_hora_fin = DetalleHorario.sDetalleHorario_hora_fin,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idDetalleHorario)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbldetallehorario_eliminar", new
            {
                lDetalleHorario_id = idDetalleHorario
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblDetalleHorario>> ObtenerTodos()
        {
            IEnumerable<TblDetalleHorario> resultado = await _database.GetData<TblDetalleHorario>("fn_tbldetallehorario_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblDetalleHorario> ObtenerPorId(int idDetalleHorario)
        {
            IEnumerable<TblDetalleHorario> resultado = await _database.GetData<TblDetalleHorario>("fn_tbldetallehorario_obtener_por_id", new
            {
                lDetalleHorario_id = idDetalleHorario
            });
            return resultado.FirstOrDefault();
        }

    }
}
