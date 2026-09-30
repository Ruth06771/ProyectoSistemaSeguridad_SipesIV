using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblCentroAlertasService
    {
        public Task Crear(CreateTblCentroAlertasDTO CentroAlertas);
        public Task Actualizar(UpdateTblCentroAlertasDTO CentroAlertas);
        public Task Eliminar(int idCentroAlertas);
        public Task<ReadTblCentroAlertasDTO> ObtenerPorId(int idCentroAlertas);
        public Task<List<ReadTblCentroAlertasDTO>> ObtenerTodos();
    }
}
