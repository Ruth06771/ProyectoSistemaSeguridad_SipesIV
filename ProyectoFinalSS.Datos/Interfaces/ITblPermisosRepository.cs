using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblPermisosRepository
    {
        public Task<int> Crear(TblPermisos permisos);
        public Task<int> Actualizar(TblPermisos permisos);
        public Task<int> Eliminar(int idPermisos);
        public Task<TblPermisos> ObtenerPorId(int idPermisos);
        public Task<List<TblPermisos>> ObtenerTodos();
    }
}
