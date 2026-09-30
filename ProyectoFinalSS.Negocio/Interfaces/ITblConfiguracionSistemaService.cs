using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblConfiguracionSistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblConfiguracionSistemaService
    {
        public Task Crear(CreateTblConfiguracionSistemaDTO ConfiguracionSistema);
        public Task Actualizar(UpdateTblConfiguracionSistemaDTO ConfiguracionSistema);
        public Task Eliminar(int idConfiguracionSistema);
        public Task<ReadTblConfiguracionSistemaDTO> ObtenerPorId(int idConfiguracionSistema);
        public Task<List<ReadTblConfiguracionSistemaDTO>> ObtenerTodos();
    }
}
