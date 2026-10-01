using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblCentroAlertasRepository
    {
        public Task<int> Crear(TblCentroAlertas CentroAlertas);
        public Task<int> Actualizar(TblCentroAlertas CentroAlertas);
        public Task<int> Eliminar(int idCentroAlertas);
        public Task<TblCentroAlertas> ObtenerPorId(int idCentroAlertas);
        public Task<List<TblCentroAlertas>> ObtenerTodos();
    }
}
