using ProyectoFinalSS.Negocio.DTOs.TblDetalleHorario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblDetalleHorarioService
    {
        public Task Crear(CreateTblDetalleHorarioDTO detalleHorarioDTO);
        public Task Actualizar(UpdateTblDetalleHorarioDTO detalleHorarioDTO);
        public Task Eliminar(int lDetalleHorario_id);
        public Task<ReadTblDetalleHorarioDTO> ObtenerPorId(int lDetalleHorario_id);
        public Task<List<ReadTblDetalleHorarioDTO>> ObtenerTodos();
    }
}
