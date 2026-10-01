using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblLectoresRepository : ITblLectoresRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblLectoresRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblLectores lectores)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbllectores_crear", new
            {
                lArea_id = lectores.lArea_id,
                sLector_codigo = lectores.sLector_codigo,
                sLector_ip = lectores.sLector_ip,
                sLector_mac = lectores.sLector_mac,
                sLector_tipo_acceso = lectores.sLector_tipo_acceso,
                sLector_estado = lectores.sLector_estado,
                sLector_ultimo_ping = lectores.sLector_ultimo_ping,


            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblLectores lectores)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbllectores_actualizar", new TblLectores
            {
                lLector_id = lectores.lLector_id,
                lArea_id = lectores.lArea_id,
                sLector_codigo = lectores.sLector_codigo,
                sLector_ip = lectores.sLector_ip,
                sLector_mac = lectores.sLector_mac,
                sLector_tipo_acceso = lectores.sLector_tipo_acceso,
                sLector_estado = lectores.sLector_estado,
                sLector_ultimo_ping = lectores.sLector_ultimo_ping,

            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idLectores)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbllectores_eliminar", new
            {
                lLector_id = idLectores
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblLectores>> ObtenerTodos()
        {
            IEnumerable<TblLectores> resultado = await _database.GetData<TblLectores>("fn_tbllectores_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblLectores> ObtenerPorId(int idLectores)
        {
            IEnumerable<TblLectores> resultado = await _database.GetData<TblLectores>("fn_tbllectores_obtener_por_id", new
            {
                lLector_id = idLectores
            });
            return resultado.FirstOrDefault();
        }
    }
}
