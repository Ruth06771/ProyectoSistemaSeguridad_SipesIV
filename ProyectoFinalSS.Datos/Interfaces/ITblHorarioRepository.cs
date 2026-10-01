using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblHorarioRepository
    {
        public Task<int> Crear(TblHorario horario);
        public Task<int> Actualizar(TblHorario horario);
        public Task<int> Eliminar(int idHorario);
        public Task<TblHorario> ObtenerPorId(int idHorario);
        public Task<List<TblHorario>> ObtenerTodos();
    }
}
