using ProyectoFinalSS.Negocio.DTOs.TblPermisos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPermisosService
    {
        public Task Crear(CreateTblPermisosDTO permisosDTO);
        public Task Actualizar(UpdateTblPermisosDTO permisosDTO);
        public Task Eliminar(int lPermisos_id);
        public Task<ReadTblPermisosDTO> ObtenerPorId(int lPermisos_id);
        public Task<List<ReadTblPermisosDTO>> ObtenerTodos();
    }
}
