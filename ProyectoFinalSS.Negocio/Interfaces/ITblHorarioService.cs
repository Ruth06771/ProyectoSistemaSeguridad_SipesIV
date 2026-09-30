using GitHub.Copilot.Rpc;
using ProyectoFinalSS.Negocio.DTOs.TblHorario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblHorarioService
    {
        public Task Crear(CreateTblHorarioDTO horarioDTO);
        public Task Actualizar(UpdateTblHorarioDTO horarioDTO);
        public Task Eliminar(int lhorario_id);
        public Task<ReadTblHorarioDTO> ObtenerPorId(int lhorario_id);
        public Task<List<ReadTblHorarioDTO>> ObtenerTodos();
    }
}
