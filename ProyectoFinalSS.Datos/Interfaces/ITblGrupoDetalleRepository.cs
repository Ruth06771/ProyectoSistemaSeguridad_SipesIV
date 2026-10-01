using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblGrupoDetalleRepository
    {
        public Task<int> Crear(TblGrupoDetalle GrupoDetalle);
        public Task<int> Actualizar(TblGrupoDetalle GrupoDetalle);
        public Task<int> Eliminar(int idGrupoDetalle);
        public Task<TblGrupoDetalle> ObtenerPorId(int idGrupoDetalle);
        public Task<List<TblGrupoDetalle>> ObtenerTodos();
    }
}
