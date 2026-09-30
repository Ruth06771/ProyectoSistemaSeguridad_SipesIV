using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblMateriasRepository : ITblMateriasRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblMateriasRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblMaterias materias)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblmaterias_crear", new
            {
                sMateria_codigo = materias.sMateria_codigo,
                sMateria_nombre = materias.sMateria_nombre,
                sMateria_estado = materias.sMateria_estado

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblMaterias materias)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblmaterias_actualizar", new TblMaterias
            {
                lMateria_id = materias.lMateria_id,
                sMateria_codigo = materias.sMateria_codigo,
                sMateria_nombre = materias.sMateria_nombre,
                sMateria_estado = materias.sMateria_estado
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idMaterias)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblmaterias_eliminar", new
            {
                lMateria_id = idMaterias
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblMaterias>> ObtenerTodos()
        {
            IEnumerable<TblMaterias> resultado = await _database.GetData<TblMaterias>("fn_tblmaterias_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblMaterias> ObtenerPorId(int idMaterias)
        {
            IEnumerable<TblMaterias> resultado = await _database.GetData<TblMaterias>("fn_tblmaterias_obtener_por_id", new
            {
               lMateria_id = idMaterias
            });
            return resultado.FirstOrDefault();
        }
    }
}
