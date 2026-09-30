using ProyectoFinalSS.Negocio.DTOs.TblAccesoPersona;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblAccesoPersonaService
    {
        public Task Crear (CreateTblAccesoPersonaDTO accesoPersonaDTO);
        public Task Actualizar(UpdateTblAccesoPersonaDTO accesoPersonaDTO);
        public Task Eliminar(int lTRegis_id);
        public Task<ReadTblAccesoPersonaDTO> ObtenerPorId(int lTRegis_id);
        public Task<List<ReadTblAccesoPersonaDTO>> ObtenerTodos();
    }
}
