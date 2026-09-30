using ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas;
using ProyectoFinalSS.Negocio.DTOs.TblHorario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.Interfaces
{
    public interface ITblHorarioService
    {
        public Task Crear(CreateTblHorarioDTO Horarios);
        public Task Actualizar(UpdateTblHorarioDTO Horarios);
        public Task Eliminar(int idHorarios);
        public Task<ReadTblHorarioDTO> ObtenerPorId(int idHorarios);
        public Task<List<ReadTblHorarioDTO>> ObtenerTodos();
    }
}
}
