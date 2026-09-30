using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblExterno;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblExternoService
    {
        public Task Crear(CreateTblExternoDTO externo);
        public Task Actualizar(UpdateTblExternoDTO externo);
        public Task Eliminar(int idExterno);
        public Task<ReadTblExternoDTO> ObtenerPorId(int idExterno);
        public Task<List<ReadTblExternoDTO>> ObtenerTodos();
    }
}
