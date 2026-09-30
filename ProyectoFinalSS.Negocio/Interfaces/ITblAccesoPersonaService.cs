using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using ProyectoFinalSS.Negocio.DTOs.TblAccesoPersona;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblAccesoPersonaService
    {
        public Task Crear(CreateTblAccesoPersonaDTO AccesoPersona);
        public Task Actualizar(UpdateTblAccesoPersonaDTO AccesoPersona);
        public Task Eliminar(int idAccesoPersona);
        public Task<ReadTblAccesoPersonaDTO> ObtenerPorId(int idAccesoPersona);
        public Task<List<ReadTblAccesoPersonaDTO>> ObtenerTodos();
    }
}
