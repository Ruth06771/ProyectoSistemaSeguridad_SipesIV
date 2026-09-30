using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblEdificio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblEdificiosService
    {
        public Task Crear(CreateTblEdificioDTO edificios);
        public Task Actualizar(UpdateTblEdificioDTO edificios);
        public Task Eliminar(int idEdificios);
        public Task<ReadTblEdificioDTO> ObtenerPorId(int idEdificios);
        public Task<List<ReadTblEdificioDTO>> ObtenerTodos();
    }
}
