using ProyectoFinalSS.Negocio.DTOs.TblPasesEspeciales;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPasesEspecialesService
    {
        public Task Crear(CreateTblPasesEspecialesDTO pasesEspecialesDTO);
        public Task Actualizar(UpdateTblPasesEspecialesDTO pasesEspecialesDTO);
        public Task Eliminar(int lPasesEspeciales_id);
        public Task<ReadTblPasesEspecialesDTO> ObtenerPorId(int lPasesEspeciales_id);
        public Task<List<ReadTblPasesEspecialesDTO>> ObtenerTodos();
    }
}
