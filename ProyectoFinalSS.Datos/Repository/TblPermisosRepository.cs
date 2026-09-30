using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblPermisosRepository : ITblPermisosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblPermisosRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblPermisos permisos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpermisos_crear", new
            {
                lPerfiles_id = permisos.lPerfiles_id,
                lmodulo_id = permisos.lmodulo_id,
                sPermisos_puede_ver = permisos.sPermisos_puede_ver,
                sPermisos_puede_crear = permisos.sPermisos_puede_crear,
                sPermisos_puede_editar = permisos.sPermisos_puede_editar,
                sPermisos_puede_eliminar = permisos.sPermisos_puede_eliminar,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblPermisos permisos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpermisos_actualizar", new TblPermisos
            {
                lPermisos_id = permisos.lPermisos_id,
                lPerfiles_id = permisos.lPerfiles_id,
                lmodulo_id = permisos.lmodulo_id,
                sPermisos_puede_ver = permisos.sPermisos_puede_ver,
                sPermisos_puede_crear = permisos.sPermisos_puede_crear,
                sPermisos_puede_editar = permisos.sPermisos_puede_editar,
                sPermisos_puede_eliminar = permisos.sPermisos_puede_eliminar,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idPermisos)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpermisos_eliminar", new
            {
                lPermisos_id = idPermisos
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblPermisos>> ObtenerTodos()
        {
            IEnumerable<TblPermisos> resultado = await _database.GetData<TblPermisos>("fn_tblpermisos_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblPermisos> ObtenerPorId(int idPermisos)
        {
            IEnumerable<TblPermisos> resultado = await _database.GetData<TblPermisos>("fn_tblpermisos_obtener_por_id", new
            {
                lPermisos_id = idPermisos
            });
            return resultado.FirstOrDefault();
        }
    }
}
