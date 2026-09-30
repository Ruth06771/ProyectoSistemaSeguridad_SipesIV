using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblModulos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblModulosService
    {
        public Task Crear(CreateTblModulosDTO Modulos);
        public Task Actualizar(UpdateTblModulosDTO Modulos);
        public Task Eliminar(int idModulos);
        public Task<ReadTblModulosDTO> ObtenerPorId(int idModulos);
        public Task<List<ReadTblModulosDTO>> ObtenerTodos();
    }
}
