using ProyectoFinalSS.Negocio.DTOs.TblLectores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblLectoresService
    {
        public Task Crear(CreateTblLectoresDTO lectoresDTO);
        public Task Actualizar(UpdateTblLectoresDTO lectoresDTO);
        public Task Eliminar(int lLector_id);
        public Task<ReadTblLectoresDTO> ObtenerPorId(int lLector_id);
        public Task<List<ReadTblLectoresDTO>> ObtenerTodos();
    }
}
