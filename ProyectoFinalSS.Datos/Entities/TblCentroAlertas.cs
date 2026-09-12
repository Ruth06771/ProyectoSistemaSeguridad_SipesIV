using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblCentroAlertas
    {
        public int lCentroAlertas_id { get; set; }
        public int llab_id { get; set; }
        public int lRegistro_accesos_id { get; set; }
        public string lCentroAlertas_tipo_alerta { get; set; }
        public bool lCentroAlertas_notificado { get; set; }
        public string lCentroAlertas_canal_notificacion{ get; set; }
        public DateTime lCentroAlertas_fecha_hora { get; set; }
    }
}
