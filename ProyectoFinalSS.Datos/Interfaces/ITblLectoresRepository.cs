using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblLectoresRepository
    {
        public Task<int> Crear(TblLectores lectores);
        public Task<int> Actualizar(TblLectores lectores);
        public Task<int> Eliminar(int idLectores);
        public Task<TblLectores> ObtenerPorId(int idLectores);
        public Task<List<TblLectores>> ObtenerTodos();
    }
}
