using ProyectoFinalSS.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Interfaces
{
    public interface ITblTipoPersonaRepository
    {
        public Task<int> Crear(TblTipoPersona tipoPersona);
        public Task<int> Actualizar(TblTipoPersona tipoPersona);
        public Task<int> Eliminar(int idTipoPersona);
        public Task<TblTipoPersona> ObtenerPorId(int idTipoPersona);
        public Task<List<TblTipoPersona>> ObtenerTiposPersonas();
    }
}
