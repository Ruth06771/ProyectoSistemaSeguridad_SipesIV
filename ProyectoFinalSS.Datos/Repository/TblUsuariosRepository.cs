using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblUsuariosRepository : ITblUsuariosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblUsuariosRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblUsuarios usuarios)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblusuarios_crear", new
            {
                lPersonas_id = usuarios.lPersonas_id,
                lPerfiles_id = usuarios.lPerfiles_id,
                sUsuario_correo = usuarios.sUsuario_correo,
                sUsuario_password = usuarios.sUsuario_password,
                sUsuario_estado = usuarios.sUsuario_estado,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblUsuarios usuarios)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblusuarios_actualizar", new TblUsuarios
            {
                lUsuarios_id = usuarios.lUsuarios_id,
                lPersonas_id = usuarios.lPersonas_id,
                lPerfiles_id = usuarios.lPerfiles_id,
                sUsuario_correo = usuarios.sUsuario_correo,
                sUsuario_password = usuarios.sUsuario_password,
                sUsuario_estado = usuarios.sUsuario_estado,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idUsuarios)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblusuarios_eliminar", new
            {
                lUsuarios_id = idUsuarios
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblUsuarios>> ObtenerTodos()
        {
            IEnumerable<TblUsuarios> resultado = await _database.GetData<TblUsuarios>("fn_tblusuarios_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblUsuarios> ObtenerPorId(int idUsuarios)
        {
            IEnumerable<TblUsuarios> resultado = await _database.GetData<TblUsuarios>("fn_tblusuarios_obtener_por_id", new
            {
                lUsuarios_id = idUsuarios
            });
            return resultado.FirstOrDefault();
        }
    }
}
