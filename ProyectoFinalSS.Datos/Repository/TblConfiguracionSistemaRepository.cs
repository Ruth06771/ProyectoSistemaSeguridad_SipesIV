using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblConfiguracionSistemaRepository : ITblConfiguracionSistemaRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblConfiguracionSistemaRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblConfiguracionSistema ConfiguracionSistema)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblconfiguracionsistema_crear", new
            {
                lUsuario_id = ConfiguracionSistema.lUsuario_id,
                sConfig_intentos_fallidos_bloqueo = ConfiguracionSistema.sConfig_intentos_fallidos_bloqueo,
                sConfig_inactividad_sesion = ConfiguracionSistema.sConfig_inactividad_sesion,
                sConfig_tolerancia_marcaje_minutos = ConfiguracionSistema.sConfig_tolerancia_marcaje_minutos,
                sConfig_tiempo_antipassck = ConfiguracionSistema.sConfig_tiempo_antipassck,
                sConfig_alertas_intentos_denegados = ConfiguracionSistema.sConfig_alertas_intentos_denegados,
                sConfig_fecha_actualizacion = ConfiguracionSistema.sConfig_fecha_actualizacion,

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblConfiguracionSistema ConfiguracionSistema)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblconfiguracionsistema_actualizar", new TblConfiguracionSistema
            {
                lConfig_id = ConfiguracionSistema.lConfig_id,
                lUsuario_id = ConfiguracionSistema.lUsuario_id,
                sConfig_intentos_fallidos_bloqueo = ConfiguracionSistema.sConfig_intentos_fallidos_bloqueo,
                sConfig_inactividad_sesion = ConfiguracionSistema.sConfig_inactividad_sesion,
                sConfig_tolerancia_marcaje_minutos = ConfiguracionSistema.sConfig_tolerancia_marcaje_minutos,
                sConfig_tiempo_antipassck = ConfiguracionSistema.sConfig_tiempo_antipassck,
                sConfig_alertas_intentos_denegados = ConfiguracionSistema.sConfig_alertas_intentos_denegados,
                sConfig_fecha_actualizacion = ConfiguracionSistema.sConfig_fecha_actualizacion,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idConfiguracionSistema)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblconfiguracionsistema_eliminar", new
            {
                lConfig_id = idConfiguracionSistema
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblConfiguracionSistema>> ObtenerTodos()
        {
            IEnumerable<TblConfiguracionSistema> resultado = await _database.GetData<TblConfiguracionSistema>("fn_tblconfiguracionsistema_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblConfiguracionSistema> ObtenerPorId(int idConfiguracionSistema)
        {
            IEnumerable<TblConfiguracionSistema> resultado = await _database.GetData<TblConfiguracionSistema>("fn_tblconfiguracionsistema_obtener_por_id", new
            {
                lConfig_id = idConfiguracionSistema
            });
            return resultado.FirstOrDefault();
        }
    }
}
