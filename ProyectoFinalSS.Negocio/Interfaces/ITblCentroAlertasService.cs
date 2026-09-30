using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblCentroAlertasService
    {
        public Task Crear(CreateTblCentroAlertasDTO centroAlertasDTO);
        public Task Actualizar (UpdateTblCentroAlertasDTO centroAlertasDTO);
        public Task Eliminar(int lCentroAlertas_id);
        public Task<ReadTblCentroAlertasDTO> ObtenerPorId(int lCentroAlertas_id);
        public Task<List<ReadTblCentroAlertasDTO>> ObtenerTodos();
    }
}
