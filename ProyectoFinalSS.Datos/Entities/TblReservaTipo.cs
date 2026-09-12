using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblReservaTipo
    {
        public int lReservaTipo_id { get; set; }
        public int lGrupo_id { get; set; }
        public int lReserva_id { get; set; }
        public bool sVisibilidad { get; set; }
        
    }
}
