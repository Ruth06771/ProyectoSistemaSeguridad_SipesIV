using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblModulosRepository
    {
        public Task<int> Crear(TblModulos modulos);
        public Task<int> Actualizar(TblModulos modulos);
        public Task<int> Eliminar(int idModulos);
        public Task<TblModulos> ObtenerPorId(int idModulos);
        public Task<List<TblModulos>> ObtenerTodos();
    }
}
