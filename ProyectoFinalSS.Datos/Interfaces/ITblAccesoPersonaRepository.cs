using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblAccesoPersonaRepository
    {
        public Task<int> Crear(TblAccesoPersona AccesoPersona);
        public Task<int> Actualizar(TblAccesoPersona AccesoPersona);
        public Task<int> Eliminar(int idAccesoPersona);
        public Task<TblAccesoPersona> ObtenerPorId(int idAccesoPersona);
        public Task<List<TblAccesoPersona>> ObtenerTodos();
    }
}
