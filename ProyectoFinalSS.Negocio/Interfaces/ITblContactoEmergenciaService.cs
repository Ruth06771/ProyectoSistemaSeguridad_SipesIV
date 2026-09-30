using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblContactoEmergencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblContactoEmergenciaService
    {
        public Task Crear(CreateTblContactoEmergenciaDTO ContactoEmergencia);
        public Task Actualizar(UpdateTblContactoEmergenciaDTO ContactoEmergencia);
        public Task Eliminar(int idContactoEmergencia);
        public Task<ReadTblContactoEmergenciaDTO> ObtenerPorId(int idContactoEmergencia);
        public Task<List<ReadTblContactoEmergenciaDTO>> ObtenerTodos();
    }
}
