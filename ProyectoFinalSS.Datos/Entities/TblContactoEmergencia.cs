using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblContactoEmergencia
    {
        public int lEmerg_contacto_id { get; set; }
        public int lPersonas_id { get; set; }
        public string sEmerg_nombre_contacto { get; set; }
        public string sEmerg_telefono_emergencia { get; set; }
        public string sEmerg_relacion { get; set; }
        public string sEmerg_direccion { get; set; }

    }
}
