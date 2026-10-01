using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblExternoRepository
    {
        public Task<int> Crear(TblExterno externo);
        public Task<int> Actualizar(TblExterno externo);
        public Task<int> Eliminar(int idExterno);
        public Task<TblExterno> ObtenerPorId(int idExterno);
        public Task<List<TblExterno>> ObtenerTodos();
    }
}
