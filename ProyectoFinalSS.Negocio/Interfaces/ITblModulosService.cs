using ProyectoFinalSS.Negocio.DTOs.TblModulos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblModulosService
    {
        public Task Crear(CreateTblModulosDTO modulosDTO);
        public Task Actualizar(UpdateTblModulosDTO modulosDTO);
        public Task Eliminar(int lModulo_id);
        public Task<ReadTblModulosDTO> ObtenerPorId(int lModulo_id);
        public Task<List<ReadTblModulosDTO>> ObtenerTodos();
    }
}
