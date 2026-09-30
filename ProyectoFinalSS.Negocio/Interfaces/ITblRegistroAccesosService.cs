using ProyectoFinalSS.Negocio.DTOs.TblRegistroAccesos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblRegistroAccesosService
    {
        public Task Crear (CreateTblRegistroAccesosDTO registroAccesosDTO);
        public Task Actualizar(UpdateTblRegistroAccesosDTO registroAccesosDTO);
        public Task Eliminar(int lRegistro_accesos_id);
        public Task<ReadTblRegistroAccesosDTO> ObtenerPorId(int lRegistro_accesos_id);
        public Task<List<ReadTblRegistroAccesosDTO>> ObtenerTodos();
    }
}
