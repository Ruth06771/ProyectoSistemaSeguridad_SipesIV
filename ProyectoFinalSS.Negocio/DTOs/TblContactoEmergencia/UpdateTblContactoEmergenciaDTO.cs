using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblContactoEmergencia
{
    public class UpdateTblContactoEmergenciaDTO
    {
        public int lContacto_emerg_id { get; set; }
        public int lPersonas_id { get; set; }
        public string sContacto_emerg_nm { get; set; }
        public string sContacto_emerg_telefono { get; set; }
        public string sContacto_emerg_relacion { get; set; }
        public string sContacto_emerg_direccion { get; set; }
    }
}
