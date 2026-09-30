using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblPerfilesRepository : ITblPerfilesRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblPerfilesRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblPerfiles perfiles)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblperfiles_crear", new
            {
                sPerfiles_nm = perfiles.sPerfiles_nm,
                sPerfiles_estado = perfiles.sPerfiles_estado,
                sPerfiles_descripcion = perfiles.sPerfiles_descripcion,
               
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblPerfiles perfiles)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblperfiles_actualizar", new TblPerfiles
            {
                lPerfiles_id = perfiles.lPerfiles_id,
                sPerfiles_nm = perfiles.sPerfiles_nm,
                sPerfiles_estado = perfiles.sPerfiles_estado,
                sPerfiles_descripcion = perfiles.sPerfiles_descripcion,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idPerfiles)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblperfiles_eliminar", new
            {
                lPerfiles_id = idPerfiles
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblPerfiles>> ObtenerTodos()
        {
            IEnumerable<TblPerfiles> resultado = await _database.GetData<TblPerfiles>("fn_tblperfiles_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblPerfiles> ObtenerPorId(int idPerfiles)
        {
            IEnumerable<TblPerfiles> resultado = await _database.GetData<TblPerfiles>("fn_tblperfiles_obtener_por_id", new
            {
                lPerfiles_id = idPerfiles
            });
            return resultado.FirstOrDefault();
        }

    }
}
