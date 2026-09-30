using ProyectoFinalSS.Negocio.DTOs.TblGrupo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblGruposService
    {
        public Task Crear(CreateTblGrupoDTO grupoDTO);
        public Task Actualizar(UpdateTblGrupoDTO grupoDTO);
        public Task Eliminar(int lGrupo_id);
        public Task<ReadTblGrupoDTO> ObtenerPorId(int lGrupo_id);
        public Task<List<ReadTblGrupoDTO>> ObtenerTodos();
    }
}
