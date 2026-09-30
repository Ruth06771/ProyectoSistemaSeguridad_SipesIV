using ProyectoFinalSS.Negocio.DTOs.TblBloqueados;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblBloqueadosService
    {
        public Task Crear(CreateTblBloqueadosDTO bloqueadoDTO);
        public Task Actualizar(UpdateTblBloqueadosDTO bloqueadoDTO);
        public Task Eliminar(int lBloqueados_id);
        public Task<ReadTblBloqueadosDTO> ObtenerPorId(int lBloqueados_id);
        public Task<List<ReadTblBloqueadosDTO>> ObtenerTodos();
    }
}
