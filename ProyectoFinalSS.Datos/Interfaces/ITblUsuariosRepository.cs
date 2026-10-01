using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblUsuariosRepository
    {
        public Task<int> Crear(TblUsuarios usuarios);
        public Task<int> Actualizar(TblUsuarios usuarios);
        public Task<int> Eliminar(int idUsuarios);
        public Task<TblUsuarios> ObtenerPorId(int idUsuarios);
        public Task<List<TblUsuarios>> ObtenerTodos();
    }
}
