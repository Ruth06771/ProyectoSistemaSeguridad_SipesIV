using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblCentroAlertas
{
    public class UpdateTblCentroAlertasDTO
    {
        public int lCentroAlertas_id { get; set; }
        public int lArea_id { get; set; }
        public int lRegistro_accesos_id { get; set; }
        public DateTime sCentroAlertas_fecha_hora { get; set; }
    }
}
