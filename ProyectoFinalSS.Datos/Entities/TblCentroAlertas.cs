using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblCentroAlertas
    {
        public int lCentroAlertas_id { get; set; }
        public int lArea_id { get; set; }
        public int lRegistro_accesos_id { get; set; }   
        public DateTime sCentroAlertas_fecha_hora { get; set; }
    }
}
