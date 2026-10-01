using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblModulos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblModulosService
    {
        public Task Crear(CreateTblModulosDTO modulos);
        public Task Actualizar(UpdateTblModulosDTO modulos);
        public Task Eliminar(int idModulos);
        public Task<ReadTblModulosDTO> ObtenerPorId(int idModulos);
        public Task<List<ReadTblModulosDTO>> ObtenerTodos();
    }
}
