using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblContactoEmergenciaRepository : ITblContactoEmergenciaRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblContactoEmergenciaRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblContactoEmergencia ContactoEmergencia)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblcontantoemergencia_crear", new
            {
                lPersonas_id = ContactoEmergencia.lPersonas_id,
                sContacto_emerg_nm = ContactoEmergencia.sContacto_emerg_nm,
                sContacto_emerg_telefono = ContactoEmergencia.sContacto_emerg_telefono,
                sContacto_emerg_relacion = ContactoEmergencia.sContacto_emerg_relacion,
                sContacto_emerg_direccion = ContactoEmergencia.sContacto_emerg_direccion,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblContactoEmergencia ContactoEmergencia)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblcontacoemergencia_actualizar", new TblContactoEmergencia
            {
                lContacto_emerg_id = ContactoEmergencia.lContacto_emerg_id,
                lPersonas_id = ContactoEmergencia.lPersonas_id,
                sContacto_emerg_nm = ContactoEmergencia.sContacto_emerg_nm,
                sContacto_emerg_telefono = ContactoEmergencia.sContacto_emerg_telefono,
                sContacto_emerg_relacion = ContactoEmergencia.sContacto_emerg_relacion,
                sContacto_emerg_direccion = ContactoEmergencia.sContacto_emerg_direccion,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idContactoEmergencia)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblcontactoemergencia_eliminar", new
            {
                lContacto_emerg_id = idContactoEmergencia
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblContactoEmergencia>> ObtenerTodos()
        {
            IEnumerable<TblContactoEmergencia> resultado = await _database.GetData<TblContactoEmergencia>("fn_tblcontactoemergencia_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblContactoEmergencia> ObtenerPorId(int idContactoEmergencia)
        {
            IEnumerable<TblContactoEmergencia> resultado = await _database.GetData<TblContactoEmergencia>("fn_tblcontactoemergencia_obtener_por_id", new
            {
                lContacto_emerg_id = idContactoEmergencia
            });
            return resultado.FirstOrDefault();
        }
    }
}
