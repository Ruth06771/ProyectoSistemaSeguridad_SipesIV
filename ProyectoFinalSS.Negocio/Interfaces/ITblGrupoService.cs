using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblGrupo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblGrupoService
    {
        public Task Crear(CreateTblGrupoDTO grupo);
        public Task Actualizar(UpdateTblGrupoDTO grupo);
        public Task Eliminar(int idGrupo);
        public Task<ReadTblGrupoDTO> ObtenerPorId(int idGrupo);
        public Task<List<ReadTblGrupoDTO>> ObtenerTodos();
    }
}

