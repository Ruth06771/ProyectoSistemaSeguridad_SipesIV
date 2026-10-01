using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblPisos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPisosService
    {
        public Task Crear(CreateTblPisosDTO pisos);
        public Task Actualizar(UpdateTblPisosDTO pisos);
        public Task Eliminar(int idPisos);
        public Task<ReadTblPisosDTO> ObtenerPorId(int idPisos);
        public Task<List<ReadTblPisosDTO>> ObtenerTodos();
    }
}
