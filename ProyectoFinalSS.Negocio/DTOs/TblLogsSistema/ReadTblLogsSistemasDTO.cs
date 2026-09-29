using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblLogsSistema
{
    public class ReadTblLogsSistemasDTO
    {
        public int lLog_id { get; set; }
        public int lUsuario_id { get; set; }
        public string sLog_modulo { get; set; }
        public string sLog_accion { get; set; }
        public string sLog_detalle { get; set; }
        public string sLog_origen { get; set; }
        public DateTime sLog_fecha_origen { get; set; }
    }
}
