using ProyectoFinalSS.Negocio.DTOs.TblContactoEmergencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblContactoEmergenciaService
    {
        public Task Crear(CreateTblContactoEmergenciaDTO contactoEmergenciaDTO);
        public Task Actualizar(UpdateTblContactoEmergenciaDTO contactoEmergenciaDTO);
        public Task Eliminar(int lContacto_emerg_id);
        public Task<ReadTblContactoEmergenciaDTO> ObtenerPorId(int lContacto_emerg_id);
        public Task<List<ReadTblContactoEmergenciaDTO>> ObtenerTodos();
    }
}
