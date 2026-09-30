using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblGrupoDetalle
{
    public class CreateTblGrupoDetalle
    {
        public int lPersonas_id { get; set; }
        public int lGrupo_id { get; set; }
        public DateTime sGrupoDetalle_fecha { get; set; }
        public string sGrupoDetalle_tipo { get; set; }
        public string sGrupoDetalle_estado { get; set; }
    }
}
