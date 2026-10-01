using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblGrupoRepository
    {
        public Task<int> Crear(TblGrupo grupo);
        public Task<int> Actualizar(TblGrupo grupo);
        public Task<int> Eliminar(int idGrupo);
        public Task<TblGrupo> ObtenerPorId(int idGrupo);
        public Task<List<TblGrupo>> ObtenerTodos();
    }
}
