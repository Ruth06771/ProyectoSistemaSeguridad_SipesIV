using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblContactoEmergenciaRepository
    {
        public Task<int> Crear(TblContactoEmergencia ContactoEmergencia);
        public Task<int> Actualizar(TblContactoEmergencia ContactoEmergencia);
        public Task<int> Eliminar(int idContactoEmergencia);
        public Task<TblContactoEmergencia> ObtenerPorId(int idContactoEmergencia);
        public Task<List<TblContactoEmergencia>> ObtenerTodos();
    }

}
