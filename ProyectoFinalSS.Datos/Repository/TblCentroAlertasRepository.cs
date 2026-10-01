using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblCentroAlertasRepository : ITblCentroAlertasRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblCentroAlertasRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblCentroAlertas CentroAlertas)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblcentroalertas_crear", new
            {
                lArea_id = CentroAlertas.lArea_id,
                lRegistro_accesos_id = CentroAlertas.lRegistro_accesos_id,
                sCentroAlertas_fecha_hora = CentroAlertas.sCentroAlertas_fecha_hora

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblCentroAlertas CentroAlertas)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblcentroalertas_actualizar", new TblCentroAlertas
            {
                lCentroAlertas_id = CentroAlertas.lCentroAlertas_id,
                lArea_id = CentroAlertas.lArea_id,
                lRegistro_accesos_id = CentroAlertas.lRegistro_accesos_id,
                sCentroAlertas_fecha_hora = CentroAlertas.sCentroAlertas_fecha_hora
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idCentroAlertas)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblcentroalertas_eliminar", new
            {
                lCentroAlertas_id = idCentroAlertas
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblCentroAlertas>> ObtenerTodos()
        {
            IEnumerable<TblCentroAlertas> resultado = await _database.GetData<TblCentroAlertas>("fn_tblcentroalertas_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblCentroAlertas> ObtenerPorId(int idCentroAlertas)
        {
            IEnumerable<TblCentroAlertas> resultado = await _database.GetData<TblCentroAlertas>("fn_tblcentroalertas_obtener_por_id", new
            {
                lCentroAlertas_id = idCentroAlertas
            });
            return resultado.FirstOrDefault();
        }
    }
}
