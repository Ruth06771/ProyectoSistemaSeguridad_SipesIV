using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblGrupoRepository : ITblGrupoRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblGrupoRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblGrupo grupo)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblgrupo_crear", new
            {
                sGrupo_descripcion = grupo.sGrupo_descripcion,
                sGrupo_estado = grupo.sGrupo_estado,
                sGrupo_tipo_grupo = grupo.sGrupo_tipo_grupo,

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblGrupo grupo)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblgrupo_actualizar", new TblGrupo
            {
                lGrupo_id = grupo.lGrupo_id,
                sGrupo_descripcion = grupo.sGrupo_descripcion,
                sGrupo_estado = grupo.sGrupo_estado,
                sGrupo_tipo_grupo = grupo.sGrupo_tipo_grupo,
            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Eliminar(int idGrupo)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblgrupo_eliminar", new
            {
                lGrupo_id = idGrupo
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblGrupo>> ObtenerTodos()
        {
            IEnumerable<TblGrupo> resultado = await _database.GetData<TblGrupo>("fn_tblgrupo_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblGrupo> ObtenerPorId(int idGrupo)
        {
            IEnumerable<TblGrupo> resultado = await _database.GetData<TblGrupo>("fn_tblgrupo_obtener_por_id", new
            {
                lGrupo_id = idGrupo
            });
            return resultado.FirstOrDefault();
        }

    }
}
