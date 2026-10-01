using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblPerfiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPerfilesService
    {
        public Task Crear(CreateTblPerfilesDTO perfiles);
        public Task Actualizar(UpdateTblPerfilesDTO perfiles);
        public Task Eliminar(int idPerfiles);
        public Task<ReadTblPerfilesDTO> ObtenerPorId(int idPerfiles);
        public Task<List<ReadTblPerfilesDTO>> ObtenerTodos();
    }
}
