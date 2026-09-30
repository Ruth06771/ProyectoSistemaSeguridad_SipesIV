using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblPisosRepository : ITblPisosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblPisosRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblPisos pisos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpisos_crear", new
            {
                lEdificios_id = pisos.lPisos_id,
                sPiso_nombre = pisos.sPiso_nombre,
                sPiso_codigo_corto = pisos.sPiso_codigo_corto,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblPisos pisos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpisos_actualizar", new TblPisos
            {
                lPisos_id = pisos.lPisos_id,
                lEdificios_id = pisos.lPisos_id,
                sPiso_nombre = pisos.sPiso_nombre,
                sPiso_codigo_corto = pisos.sPiso_codigo_corto,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idPisos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpisos_eliminar", new
            {
                lPisos_id = idPisos
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblPisos>> ObtenerTodos()
        {
            IEnumerable<TblPisos> resultado = await _database.GetData<TblPisos>("fn_tblpisos_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblPisos> ObtenerPorId(int idPisos)
        { 
        IEnumerable<TblPisos> resultado = await _database.GetData<TblPisos>("fn_tblpisos_obtener_por_id", new
            {
            lPisos_id = idPisos
        });
            return resultado.FirstOrDefault();
        }
    }
}
