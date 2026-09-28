using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblBloqueados
    {
        public int lBloqueados_id { get; set; }
        public int lPersonas_id { get; set; }
        public string sContacto_emerg_nm { get; set; }
        public string sContacto_emerg_telefono { get; set; }
        public string sContacto_emerg_relacion { get; set; }
        public string sContacto_emerg_direccion { get; set; }
    }
}
