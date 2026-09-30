using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblGrupoDetalle;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblGrupoDetalleService
    {
        public Task Crear(CreateTblGrupoDetalleDTO GrupoDetalle);
        public Task Actualizar(UpdateTblGrupoDetalleDTO GrupoDetalle);
        public Task Eliminar(int idGrupoDetalle);
        public Task<ReadTblGrupoDetalleDTO> ObtenerPorId(int idGrupoDetalle);
        public Task<List<ReadTblGrupoDetalleDTO>> ObtenerTodos();
    }
}
