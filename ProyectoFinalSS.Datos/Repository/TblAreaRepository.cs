using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
   public class TblAreaRepository : ITblAreaRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblAreaRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }

        public async Task<int> Crear(TblArea area)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblarea_crear", new
            {
                lPiso_id = area.lPiso_id,
                sArea_nombre = area.sArea_nombre,
                sArea_capacidad_maxima = area.sArea_capacidad_maxima,
                sArea_estado = area.sArea_estado,
                sArea_codigo_aula = area.sArea_codigo_aula
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblArea area)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblarea_actualizar", new TblArea
            {
                lArea_id = area.lArea_id,
                lPiso_id = area.lPiso_id,
                sArea_nombre = area.sArea_nombre,
                sArea_capacidad_maxima = area.sArea_capacidad_maxima,
                sArea_estado = area.sArea_estado,
                sArea_codigo_aula = area.sArea_codigo_aula
            });
            return resultado.FirstOrDefault();

        }

        public async Task<int> Eliminar(int idArea)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblarea_eliminar", new
            {
                lArea_id = idArea
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblArea>> ObtenerTodos()
        {
            IEnumerable<TblArea> resultado = await _database.GetData<TblArea>("fn_tblarea_obtener_todos");
            return resultado.ToList();
        }

        public async Task<TblArea> ObtenerPorId(int idArea)
        {
            IEnumerable<TblArea> resultado = await _database.GetData<TblArea>("fn_tblarea_obtener_por_id", new
            {
                lArea_id = idArea
            });
            return resultado.FirstOrDefault();
        }

    }
}
