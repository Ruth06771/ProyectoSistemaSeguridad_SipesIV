using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblMaterias;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblMateriasService
    {
        public Task Crear(CreateTblMateriasDTO materias);
        public Task Actualizar(UpdateTblMateriasDTO materias);
        public Task Eliminar(int idMaterias);
        public Task<ReadTblMateriasDTO> ObtenerPorId(int idMaterias);
        public Task<List<ReadTblMateriasDTO>> ObtenerTodos();
    }
}
