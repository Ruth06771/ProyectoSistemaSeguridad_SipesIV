using ProyectoFinalSS.Datos.AccesoDatos;
using ProyectoFinalSS.Datos.Entities;
using ProyectoFinalSS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Repository
{
    public class TblAccesoPersonaRepository : ITblAccesoPersonaRepository
    {
        private readonly SistemaSeguridadDatabase _database;
        public TblAccesoPersonaRepository(SistemaSeguridadDatabase database)
        {
            _database = database;
        }

        public async Task<int> Crear(TblAccesoPersona AccesoPersona)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblaccesopersona_crear", new
            {
                lPersonas_id = AccesoPersona.lPersonas_id

            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblAccesoPersona AccesoPersona)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblaccesopersona_actualizar", new TblAccesoPersona
            {
                lTRegis_id = AccesoPersona.lTRegis_id,
                lPersonas_id = AccesoPersona.lPersonas_id
            });
            return resultado.FirstOrDefault();

        }
        public async Task<int> Eliminar(int idAccesoPersona)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblaccesopersona_eliminar", new
            {
                lTRegis_id = idAccesoPersona
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblAccesoPersona>> ObtenerTodos()
        {
            IEnumerable<TblAccesoPersona> resultado = await _database.GetData<TblAccesoPersona>("fn_tblaccesopersona_obtener_todos");
            return resultado.ToList();
        }
        public async Task<TblAccesoPersona> ObtenerPorId(int idAccesoPersona)
        {
            IEnumerable<TblAccesoPersona> resultado = await _database.GetData<TblAccesoPersona>("fn_tblaccesopersona_obtener_por_id", new
            {
                lTRegis_id = idAccesoPersona
            });
            return resultado.FirstOrDefault();
        }
    }
}
