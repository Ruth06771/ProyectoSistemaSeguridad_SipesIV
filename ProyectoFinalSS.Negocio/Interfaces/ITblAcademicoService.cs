using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblAcademicoService
    {
        public Task Crear(CreateTblAcademicoDTO academicoDTO);
        public Task Actualizar (UpdateTblAcademicoDTO academicoDTO);
        public Task Eliminar (int AcademicoId); //aqui no se como va no se cual es la pk
        public Task <ReadTblAcademicoDTO> ObtenerPorId(int AcademicoId);
        public Task<List<ReadTblAcademicoDTO>> ObtenerTodos();
    }
}
