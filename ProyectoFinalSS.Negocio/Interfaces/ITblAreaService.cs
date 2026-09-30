using ProyectoFinalSS.Negocio.DTOs.TblArea;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblAreaService
    {
        public Task Crear(CreateTblAreaDTO areaDTO);
        public Task Actualizar(UpdateTblAreaDTO areaDTO);
        public Task Eliminar(int lArea_id);
        public Task<ReadTblAreaDTO> ObtenerPorId(int lArea_id);
        public Task<List<ReadTblAreaDTO>> ObtenerTodos();
    }
}
