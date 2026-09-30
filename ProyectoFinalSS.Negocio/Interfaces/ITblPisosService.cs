using ProyectoFinalSS.Negocio.DTOs.TblPisos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPisosService
    {
        public Task Crear(CreateTblPisosDTO pisosDTO);
        public Task Actualizar(UpdateTblPisosDTO pisosDTO);
        public Task Eliminar(int lPiso_id);
        public Task<ReadTblPisosDTO> ObtenerPorId(int lPiso_id);
        public Task<List<ReadTblPisosDTO>> ObtenerTodos();
    }
}
