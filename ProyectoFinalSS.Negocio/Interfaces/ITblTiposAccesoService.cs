using ProyectoFinalSS.Negocio.DTOs.TblRegistroAccesos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblTiposAccesoService
    {
        public Task Crear(CreateTblRegistroAccesosDTO registroAccesosDTO);
        public Task Actualizar(UpdateTblRegistroAccesosDTO registroAccesosDTO);
        public Task Eliminar(int lTRegistro_id);
        public Task<ReadTblRegistroAccesosDTO> ObtenerPorId(int lTRegistro_id);
        public Task<List<ReadTblRegistroAccesosDTO>> ObtenerTodos();
    }
}
