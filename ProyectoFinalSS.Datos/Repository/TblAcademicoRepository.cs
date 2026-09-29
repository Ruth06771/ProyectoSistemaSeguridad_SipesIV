using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblAcademicoRepository : ITblAcademicoRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblAcademicoRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }

        public async Task<int> Crear(TblAcademico Academico)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblacademico_crear", new
            {
                lMateria_id = Academico.lMateria_id,
                sAcademico_nombre_grupo = Academico.sAcademico_nombre_grupo,
               
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblAcademico Academico)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblacademico_actualizar", new TblAcademico
            {
                lGrupo_id = Academico.lGrupo_id,
                lMateria_id = Academico.lMateria_id,
                sAcademico_nombre_grupo = Academico.sAcademico_nombre_grupo,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idAcademico)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblacademico_eliminar", new
            {
                lGrupo_id = idAcademico
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblAcademico>> ObtenerTodos()
        {
            IEnumerable<TblAcademico> resultado = await _database.GetData<TblAcademico>("fn_tblacademico_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblAcademico> ObtenerPorId(int idAcademico)
        {
            IEnumerable<TblAcademico> resultado = await _database.GetData<TblAcademico>("fn_tblacademico_obtener_por_id", new
            {
                lGrupo_id = idAcademico
            });
            return resultado.FirstOrDefault();
        }
    }
}
