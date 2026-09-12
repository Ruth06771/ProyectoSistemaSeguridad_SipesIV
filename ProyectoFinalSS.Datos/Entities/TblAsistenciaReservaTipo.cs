using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblAsistenciaReservaTipo
    {
        public int lAsistencia_id { get; set; }
        public int lReservaTipo_id { get; set; }
        public int lPersonas_id { get; set; }
        public DateTime sfecha_inicio { get; set; }
        public DateTime sfecha_fin { get; set; }
    }
}
