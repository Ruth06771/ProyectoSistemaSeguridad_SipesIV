using ProyectoFinalSS.Negocio.DTOs.TblEdificios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblEdificiosService
    {
        public Task Crear(CreateTblEdificiosDTO edificioDTO);
        public Task Actualizar(UpdateTblEdificiosDTO edificioDTO);
        public Task Eliminar(int lEdificio_id);
        public Task<ReadTblEdificiosDTO> ObtenerPorId(int lEdificio_id);
        public Task<List<ReadTblEdificiosDTO>> ObtenerTodos();
    }
}
