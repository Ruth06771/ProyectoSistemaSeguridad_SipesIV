using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblDetalleHorarioRepository
    {
        public Task<int> Crear(TblDetalleHorario DetalleHorario);
        public Task<int> Actualizar(TblDetalleHorario DetalleHorario);
        public Task<int> Eliminar(int idDetalleHorario);
        public Task<TblDetalleHorario> ObtenerPorId(int idDetalleHorario);
        public Task<List<TblDetalleHorario>> ObtenerTodos();
    }
}
