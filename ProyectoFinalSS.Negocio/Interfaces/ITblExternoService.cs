using ProyectoFinalSS.Negocio.DTOs.TblExterno;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblExternoService
    {
        public Task Crear(CreateTblExternoDTO externoDTO);
        public Task Actualizar(UpdateTblExternoDTO externoDTO);
        public Task Eliminar(int lGrupo_id);
        public Task<ReadTblExternoDTO> ObtenerPorId(int lGrupo_id);
        public Task<List<ReadTblExternoDTO>> ObtenerTodos();
    }
}
