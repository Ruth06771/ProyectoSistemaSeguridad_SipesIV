using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblPasesEspecialesRepository : ITblPasesEspecialesRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblPasesEspecialesRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblPasesEspeciales pasesEspeciales)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpasesespeciales_crear", new
            {
                lPersonas_id = pasesEspeciales.lPersonas_id,
                lLector_id = pasesEspeciales.lLector_id,
                lPasesEspeciales_motivo = pasesEspeciales.lPasesEspeciales_motivo,
                lPasesEspeciales_fecha_inicio = pasesEspeciales.lPasesEspeciales_fecha_inicio,
                lPasesEspeciales_fecha_fin = pasesEspeciales.lPasesEspeciales_fecha_fin,
                lPasesEspeciales_estado = pasesEspeciales.lPasesEspeciales_estado,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblPasesEspeciales pasesEspeciales)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpasesespeciales_actualizar", new TblPasesEspeciales
            {
                lPasesEspeciales_id = pasesEspeciales.lPasesEspeciales_id,
                lPersonas_id = pasesEspeciales.lPersonas_id,
                lLector_id = pasesEspeciales.lLector_id,
                lPasesEspeciales_motivo = pasesEspeciales.lPasesEspeciales_motivo,
                lPasesEspeciales_fecha_inicio = pasesEspeciales.lPasesEspeciales_fecha_inicio,
                lPasesEspeciales_fecha_fin = pasesEspeciales.lPasesEspeciales_fecha_fin,
                lPasesEspeciales_estado = pasesEspeciales.lPasesEspeciales_estado,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idPasesEspeciales)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblpasesespeciales_eliminar", new
            {
                lPasesEspeciales_id = idPasesEspeciales
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblPasesEspeciales>> ObtenerTodos()
        {
            IEnumerable<TblPasesEspeciales> resultado = await _database.GetData<TblPasesEspeciales>("fn_tblpasesespeciales_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblPasesEspeciales> ObtenerPorId(int idPasesEspeciales)
        {
            IEnumerable<TblPasesEspeciales> resultado = await _database.GetData<TblPasesEspeciales>("fn_tblpasesespeciales_obtener_por_id", new
            {
                lPasesEspeciales_id = idPasesEspeciales
            });
            return resultado.FirstOrDefault();
        }
    }
}
