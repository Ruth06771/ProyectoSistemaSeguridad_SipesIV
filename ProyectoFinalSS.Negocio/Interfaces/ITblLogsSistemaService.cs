using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblLogsSistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblLogsSistemaService
    {
        public Task Crear(CreateTblLogsSistemaDTO LogsSistema);
        public Task Actualizar(UpdateTblLogsSistemaDTO LogsSistema);
        public Task Eliminar(int idLogsSistema);
        public Task<ReadTblLogsSistemaDTO> ObtenerPorId(int idLogsSistema);
        public Task<List<ReadTblLogsSistemaDTO>> ObtenerTodos();
    }
}
