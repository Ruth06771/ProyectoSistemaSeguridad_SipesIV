using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblPersonas
    {
        public int lPersonas_id { get; set; }
        public string sPersonas_nm{ get; set; }
        public string sPersonas_aps { get; set; }
        public DateTime sPersonas_fecha_nacimiento { get; set; } //es solo Date
        public string sPersonas_correo { get; set; }
        public string sPersonas_telefono { get; set; }
        public string sPersonas_numero_carnet{ get; set; }
        public string sPersonas_sexo { get; set; }
        public string sPersonas_tipo_sangre { get; set; }
        public bool sPersonas_estado { get; set; }
        public DateTime sPersonas_fecha_registro { get; set; }
        public string sPersonas_direccion { get; set; }
        public string sPersonas_tipo_persona { get; set; }
        public string sTarjetas_uid { get; set; }
        public string sTarjetas_pin { get; set; }
        public bool sTarjetas_estado { get; set; }


    }
}
