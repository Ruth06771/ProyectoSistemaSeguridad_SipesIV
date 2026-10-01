using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblConfiguracionSistemaRepository
    {
        public Task<int> Crear(TblConfiguracionSistema ConfiguracionSistema);
        public Task<int> Actualizar(TblConfiguracionSistema ConfiguracionSistema);
        public Task<int> Eliminar(int idConfiguracionSistema);
        public Task<TblConfiguracionSistema> ObtenerPorId(int idConfiguracionSistema);
        public Task<List<TblConfiguracionSistema>> ObtenerTodos();
    }
}
