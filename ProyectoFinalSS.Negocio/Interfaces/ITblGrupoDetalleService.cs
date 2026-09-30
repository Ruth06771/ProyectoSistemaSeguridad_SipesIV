using ProyectoFinalSS.Negocio.DTOs.TblGrupoDetalle;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblGrupoDetalleService
    {
        public Task Crear(CreateTblGrupoDetalleDTO grupoDetalleDTO);
        public Task Actualizar(UpdateTblGrupoDetalleDTO grupoDetalleDTO);
        public Task Eliminar(int lGrupoDetalle_id);
        public Task<ReadTblGrupoDetalleDTO> ObtenerPorId(int lGrupoDetalle_id);
        public Task<List<ReadTblGrupoDetalleDTO>> ObtenerTodos();
    }
}
