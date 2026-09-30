using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblPasesEspeciales;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPasesEspecialesService
    {
        public Task Crear(CreateTblPasesEspecialesDTO PasesEspeciales);
        public Task Actualizar(UpdateTblPasesEspecialesDTO PasesEspeciales);
        public Task Eliminar(int idPasesEspeciales);
        public Task<ReadTblPasesEspecialesDTO> ObtenerPorId(int idPasesEspeciales);
        public Task<List<ReadTblPasesEspecialesDTO>> ObtenerTodos();
    }
}
