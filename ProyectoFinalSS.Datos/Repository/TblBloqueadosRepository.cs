using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblBloqueadosRepository : ITblBloqueadosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblBloqueadosRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblBloqueados bloqueados)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblbloqueado_crear", new
            {
                lPersonas_id = bloqueados.lPersonas_id,
                sBloqueado_fecha_inicio = bloqueados.sBloqueado_fecha_inicio,
                sBloqueado_estado = bloqueados.sBloqueado_estado,
                sBloqueado_motivo = bloqueados.sBloqueado_motivo,
                sBloqueado_fecha_fin  = bloqueados.sBloqueado_fecha_fin,

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblBloqueados bloqueados)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblbloqueado_actualizar", new TblBloqueados
            {
                lBloqueados_id = bloqueados.lBloqueados_id,
                lPersonas_id = bloqueados.lPersonas_id,
                sBloqueado_fecha_inicio = bloqueados.sBloqueado_fecha_inicio,
                sBloqueado_estado = bloqueados.sBloqueado_estado,
                sBloqueado_motivo = bloqueados.sBloqueado_motivo,
                sBloqueado_fecha_fin = bloqueados.sBloqueado_fecha_fin,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idbloqueados)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblbloqueado_eliminar", new
            {
                lBloqueados_id = idbloqueados
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblBloqueados>> ObtenerTodos()
        {
            IEnumerable<TblBloqueados> resultado = await _database.GetData<TblBloqueados>("fn_tblbloqueado_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblBloqueados> ObtenerPorId(int idbloqueados)
        {
            IEnumerable<TblBloqueados> resultado = await _database.GetData<TblBloqueados>("fn_tblbloqueado_obtener_por_id", new
            {
                lBloqueados_id = idbloqueados
            });
            return resultado.FirstOrDefault();
        }
    }
}
