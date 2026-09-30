using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblDetalleHorario
{
    public class CreateTblDetalleHorarioDTO
    {
        public int lhorario_id { get; set; }
        public int lGrupo_id { get; set; }
        public string sDetalleHorario_dia { get; set; }
        public TimeOnly sDetalleHorario_hora_inicio { get; set; }
        public TimeOnly sDetalleHorario_hora_fin { get; set; }
    }
}
