using ProyectoFinalSS.Negocio.DTOs.TblLogsSistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblLogsSistemaService
    {
        public Task Crear(CreateTblLogsSistemasDTO logsSistemasDTO);
        public Task Actualizar(UpdateTblLogsSistemasDTO logsSistemasDTO);
        public Task Eliminar(int lLog_id);
        public Task<ReadTblLogsSistemasDTO> ObtenerPorId(int lLog_id);
        public Task<List<ReadTblLogsSistemasDTO>> ObtenerTodos();
    }
}
