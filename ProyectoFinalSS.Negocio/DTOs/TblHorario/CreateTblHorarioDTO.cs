using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblHorario
{
    public class CreateTblHorarioDTO
    {
        public int lArea_id { get; set; }
        public DateTime sHorario_fecha_inicio { get; set; }
        public DateTime sHorario_fecha_fin { get; set; }
    }
}
