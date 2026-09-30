using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblDetalleHorario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblDetalleHorarioService
    {
        public Task Crear(CreateTblDetalleHorarioDTO DetalleHorario);
        public Task Actualizar(UpdateTblDetalleHorarioDTO DetalleHorario);
        public Task Eliminar(int idDetalleHorario);
        public Task<ReadTblDetalleHorarioDTO> ObtenerPorId(int idDetalleHorario);
        public Task<List<ReadTblDetalleHorarioDTO>> ObtenerTodos();
    }
}
