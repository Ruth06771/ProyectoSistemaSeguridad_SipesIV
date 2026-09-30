using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblPersonas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblPersonasService
    {
        public Task Crear(CreateTblPersonasDTO Personas);
        public Task Actualizar(UpdateTblPersonasDTO Personas);
        public Task Eliminar(int idPersonas);
        public Task<ReadTblPersonasDTO> ObtenerPorId(int idPersonas);
        public Task<List<ReadTblPersonasDTO>> ObtenerTodos();
    }
}
