using ProyectoFinalSS.Negocio.DTOs.TblMaterias;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblMateriasService
    {
        public Task Crear(CreateTblMateriasDTO materiasDTO);
        public Task Actualizar(UpdateTblMateriasDTO materiasDTO);
        public Task Eliminar(int lMateria_id);
        public Task<ReadTblMateriasDTO> ObtenerPorId(int lMateria_id);
        public Task<List<ReadTblMateriasDTO>> ObtenerTodos();
    }
}
