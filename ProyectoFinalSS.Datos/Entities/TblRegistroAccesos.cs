using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblRegistroAccesos
    {
        public int lRegistro_Accesos_id { get; set; }
        public int lTarjetas_id { get; set; }
        public int llab_id { get; set; }
        public int ITRegis_id { get; set; }
        public string sTipo_movimiento { get; set; }
        public bool bAutorizado { get; set; }
        public string sMotivo_denegacion { get; set; }
        public DateTime dFecha_hora { get; set; }

    }
}
