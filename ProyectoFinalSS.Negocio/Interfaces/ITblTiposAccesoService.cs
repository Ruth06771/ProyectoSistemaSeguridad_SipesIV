using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblTiposAcceso;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblTiposAccesoService
    {
        public Task Crear(CreateTblTiposAccessoDTO TiposAcceso);
        public Task Actualizar(UpdateTblTiposAccesoDTO TiposAcceso);
        public Task Eliminar(int idTiposAcceso);
        public Task<ReadTblTiposAccesoDTO> ObtenerPorId(int idTiposAcceso);
        public Task<List<ReadTblTiposAccesoDTO>> ObtenerTodos();
    }
}
