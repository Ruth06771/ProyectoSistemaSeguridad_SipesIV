using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblGrupo
{
    public class ReadTblGrupoDTO
    {
        public int lGrupo_id { get; set; }
        public string sGrupo_descripcion { get; set; }
        public bool sGrupo_estado { get; set; }
        public string sGrupo_tipo_grupo { get; set; }
    }
}
