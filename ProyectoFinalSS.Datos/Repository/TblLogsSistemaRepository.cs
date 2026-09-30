using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblLogsSistemaRepository : ITblLogsSistemaRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblLogsSistemaRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblLogsSistema LogsSistema)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbllogsistema_crear", new
            {
                lUsuario_id = LogsSistema.lUsuario_id,
                sLog_modulo = LogsSistema.sLog_modulo,
                sLog_accion = LogsSistema.sLog_accion,
                sLog_detalle = LogsSistema.sLog_detalle,
                sLog_origen = LogsSistema.sLog_origen,
                sLog_fecha_origen = LogsSistema.sLog_fecha_origen,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblLogsSistema LogsSistema)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbllogsistema_actualizar", new TblLogsSistema
            {
                lLog_id = LogsSistema.lLog_id,
                lUsuario_id = LogsSistema.lUsuario_id,
                sLog_modulo = LogsSistema.sLog_modulo,
                sLog_accion = LogsSistema.sLog_accion,
                sLog_detalle = LogsSistema.sLog_detalle,
                sLog_origen = LogsSistema.sLog_origen,
                sLog_fecha_origen = LogsSistema.sLog_fecha_origen,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idLogsSistema)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tbllogsistema_eliminar", new
            {
                lLog_id = idLogsSistema
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblLogsSistema>> ObtenerTodos()
        {
            IEnumerable<TblLogsSistema> resultado = await _database.GetData<TblLogsSistema>("fn_tbllogsistema_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblLogsSistema> ObtenerPorId(int idLogsSistema)
        {
            IEnumerable<TblLogsSistema> resultado = await _database.GetData<TblLogsSistema>("fn_tbllogsistema_obtener_por_id", new
            {
                lLog_id = idLogsSistema
            });
            return resultado.FirstOrDefault();
        }
    }
}
