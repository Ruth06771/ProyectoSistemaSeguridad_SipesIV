using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblLectores
{
    public class CreateTblLectoresDTO
    {
        public int lArea_id { get; set; }
        public string sLector_codigo { get; set; }
        public string sLector_ip { get; set; }
        public string sLector_mac { get; set; }
        public string sLector_tipo_acceso { get; set; }
        public bool sLector_estado { get; set; }
        public DateTime sLector_ultimo_ping { get; set; }
    }
}
