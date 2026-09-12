using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblReservaExtraordinaria
    {
        public int lReserva_id { get; set; }
        public int llab_id { get; set; }
        public int lPersonas_id { get; set; }
        public string sReserva_motivo { get; set; }
        public DateTime sReserva_fecha { get; set; } //es solo Date 
        public TimeOnly sReserva_hora_inicio { get; set; } //time o
        public TimeOnly sReserva_hora_fin { get; set; } //time o
        public bool sReserva_tipo { get; set; }
    }
}
