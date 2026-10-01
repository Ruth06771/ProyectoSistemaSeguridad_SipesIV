using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblAreaRepository
    {
        public Task<int> Crear(TblArea area);
        public Task<int> Actualizar(TblArea area);
        public Task<int> Eliminar(int idArea);
        public Task<TblArea> ObtenerPorId(int idArea);
        public Task<List<TblArea>> ObtenerTodos();
    }
}
