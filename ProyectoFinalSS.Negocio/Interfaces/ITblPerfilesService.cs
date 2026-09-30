using ProyectoFinalSS.Negocio.DTOs.TblPerfiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPerfilesService
    {
        public Task Crear(CreateTblPerfilesDTO perfilesDTO);
        public Task Actualizar(UpdateTblPerfilesDTO perfilesDTO);
        public Task Eliminar(int lPerfiles_id);
        public Task<ReadTblPerfilesDTO> ObtenerPorId(int lPerfiles_id);
        public Task<List<ReadTblPerfilesDTO>> ObtenerTodos();
    }
}
