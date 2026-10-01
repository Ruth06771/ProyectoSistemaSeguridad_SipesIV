using ProyectoFinalSS.Datos.Entities;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblAcademicoRepository
    {
        public Task<int> Crear(TblAcademico Academico);
        public Task<int> Actualizar(TblAcademico Academico);
        public Task<int> Eliminar(int idAcademico);
        public Task<TblAcademico> ObtenerPorId(int idAcademico);
        public Task<List<TblAcademico>> ObtenerTodos();
    }
}
