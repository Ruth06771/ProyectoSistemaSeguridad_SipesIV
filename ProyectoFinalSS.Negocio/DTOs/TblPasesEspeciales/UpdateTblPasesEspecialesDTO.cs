using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblPasesEspeciales
{
    public class UpdateTblPasesEspecialesDTO
    {
        public int lPasesEspeciales_id { get; set; }
        public int lPersonas_id { get; set; }
        public int lLector_id { get; set; }
        public string lPasesEspeciales_motivo { get; set; }
        public DateTime lPasesEspeciales_fecha_inicio { get; set; }
        public DateTime lPasesEspeciales_fecha_fin { get; set; }
        public bool lPasesEspeciales_estado { get; set; }
    }
}
