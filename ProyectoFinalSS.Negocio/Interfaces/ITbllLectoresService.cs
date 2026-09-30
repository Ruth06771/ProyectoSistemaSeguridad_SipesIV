using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblLectores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblLectoresService
    {
        public Task Crear(CreateTblLectoresDTO lectores);
        public Task Actualizar(UpdateTblLectoresDTO lectores);
        public Task Eliminar(int idLectores);
        public Task<ReadTblLectoresDTO> ObtenerPorId(int idLectores);
        public Task<List<ReadTblLectoresDTO>> ObtenerTodos();
    }
}
