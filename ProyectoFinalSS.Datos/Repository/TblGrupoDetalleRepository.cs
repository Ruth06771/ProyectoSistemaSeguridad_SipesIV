using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblGrupoDetalleRepository : ITblGrupoDetalleRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblGrupoDetalleRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblGrupoDetalle GrupoDetalle)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblgrupodetalle_crear", new
            {
                lPersonas_id = GrupoDetalle.lPersonas_id,
                lGrupo_id = GrupoDetalle.lGrupo_id,
                sGrupoDetalle_fecha = GrupoDetalle.sGrupoDetalle_fecha,
                sGrupoDetalle_tipo = GrupoDetalle.sGrupoDetalle_tipo,
                sGrupoDetalle_estado = GrupoDetalle.sGrupoDetalle_estado,

            });
            return resultado.FirstOrDefault();
        }
        public async Task<int> Actualizar(TblGrupoDetalle GrupoDetalle)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblgrupodetalle_actualizar", new TblGrupoDetalle
            {
                lGrupoDetalle_id = GrupoDetalle.lGrupoDetalle_id,
                lPersonas_id = GrupoDetalle.lPersonas_id,
                lGrupo_id = GrupoDetalle.lGrupo_id,
                sGrupoDetalle_fecha = GrupoDetalle.sGrupoDetalle_fecha,
                sGrupoDetalle_tipo = GrupoDetalle.sGrupoDetalle_tipo,
                sGrupoDetalle_estado = GrupoDetalle.sGrupoDetalle_estado,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idGrupoDetalle)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblgrupodetalle_eliminar", new
            {
                lGrupoDetalle_id = idGrupoDetalle
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblGrupoDetalle>> ObtenerTodos()
        {
            IEnumerable< TblGrupoDetalle> resultado = await _database.GetData<TblGrupoDetalle>("fn_tblgrupodetalle_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblGrupoDetalle> ObtenerPorId(int idGrupoDetalle)
        {
            IEnumerable<TblGrupoDetalle> resultado = await _database.GetData<TblGrupoDetalle>("fn_tblgrupodetalle_obtener_por_id", new
            {
                lGrupoDetalle_id = idGrupoDetalle
            });
            return resultado.FirstOrDefault();
        }

    }
}
