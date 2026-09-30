using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblPermisos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPermisosService
    {
        public Task Crear(CreateTblPermisosDTO Permisos);
        public Task Actualizar(UpdateTblPermisosDTO Permisos);
        public Task Eliminar(int idPermisos);
        public Task<ReadTblPermisosDTO> ObtenerPorId(int idPermisos);
        public Task<List<ReadTblPermisosDTO>> ObtenerTodos();
    }
}
