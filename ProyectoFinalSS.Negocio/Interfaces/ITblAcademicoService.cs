using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using ProyectoFinalSS.Negocio.DTOs.TblArea;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblAcademicoService
    {
        public Task Crear(CreateTblAcademicoDTO academico);
        public Task Actualizar(UpdateTblAcademicoDTO academico);
        public Task Eliminar(int idAcademico);
        public Task<ReadTblAcademicoDTO> ObtenerPorId(int idAcademico);
        public Task<List<ReadTblAcademicoDTO>> ObtenerTodos();
    }
}
