using ProyectoFinalSS.Negocio.DTOs.TblAcademico;
using ProyectoFinalSS.Negocio.DTOs.TblBloqueados;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblBloqueadosService
    {
        public Task Crear(CreateTblBloqueadosDTO bloqueados);
        public Task Actualizar(UpdateTblBloqueadosDTO bloqueados);
        public Task Eliminar(int idBloqueados);
        public Task<ReadTblBloqueadosDTO> ObtenerPorId(int idBloqueados);
        public Task<List<ReadTblBloqueadosDTO>> ObtenerTodos();
    }
}
