using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblRegistroAccesoRepository : ITblRegistroAccesosRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblRegistroAccesoRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }
        public async Task<int> Crear(TblRegistroAccesos RegistroAcceso)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblregistroaccesos_crear", new
            {
                lPersonas_id = RegistroAcceso.lPersonas_id,
                llector_id = RegistroAcceso.llector_id,
                sRegistro_Autorizado = RegistroAcceso.sRegistro_Autorizado,
                sRegistro_motivo_denegacion = RegistroAcceso.sRegistro_motivo_denegacion,
                sRegistro_fecha_hora = RegistroAcceso.sRegistro_fecha_hora,

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblRegistroAccesos RegistroAcceso)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblregistroaccesos_actualizar", new TblRegistroAccesos
            {
                lRegistro_Accesos_id = RegistroAcceso.lRegistro_Accesos_id,
                lPersonas_id = RegistroAcceso.lPersonas_id,
                llector_id = RegistroAcceso.llector_id,
                sRegistro_Autorizado = RegistroAcceso.sRegistro_Autorizado,
                sRegistro_motivo_denegacion = RegistroAcceso.sRegistro_motivo_denegacion,
                sRegistro_fecha_hora = RegistroAcceso.sRegistro_fecha_hora,
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idRegistroAcceso)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblregistroaccesos_eliminar", new
            {
                lRegistro_Accesos_id = idRegistroAcceso
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblRegistroAccesos>> ObtenerTodos()
        {
            IEnumerable<TblRegistroAccesos> resultado = await _database.GetData<TblRegistroAccesos>("fn_tblregistroaccesos_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblRegistroAccesos> ObtenerPorId(int idRegistroAcceso)
        {
            IEnumerable<TblRegistroAccesos> resultado = await _database.GetData<TblRegistroAccesos>("fn_tblregistroaccesos_obtener_por_id", new
            {
                lRegistro_Accesos_id = idRegistroAcceso
            });
            return resultado.FirstOrDefault();
        }
    }
    
}
