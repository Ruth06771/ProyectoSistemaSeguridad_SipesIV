using ProyectoFinalSS.Negocio.DTOs.TblPersonas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPersonasService
    {
        public Task Crear(CreateTblPersonasDTO personasDTO);
        public Task Actualizar(UpdateTblPersonasDTO personasDTO);
        public Task Eliminar(int lPersonas_id);
        public Task<ReadTblPersonasDTO> ObtenerPorId(int lPersonas_id);
        public Task<List<ReadTblPersonasDTO>> ObtenerTodos();
    }
}
