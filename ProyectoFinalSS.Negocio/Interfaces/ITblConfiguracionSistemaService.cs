using ProyectoFinalSS.Negocio.DTOs.TblConfiguracionSistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblConfiguracionSistemaService
    {
        public Task Crear(CreateTblConfiguracionSistemaDTO configuracionSistemaDTO);
        public Task Actualizar(UpdateTblConfiguracionSistemaDTO configuracionSistemaDTO);
        public Task Eliminar(int lConfig_id);
        public Task<ReadTblConfiguracionSistemaDTO> ObtenerPorId(int lConfig_id);
        public Task<List<ReadTblConfiguracionSistemaDTO>> ObtenerTodos();
    }
}
