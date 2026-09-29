using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblAcademico
{
    public class UpdateTblAcademicoDTO
    {
        public int lGrupo_id { get; set; }
        public int lMateria_id { get; set; }
        public string sAcademico_nombre_grupo { get; set; }
    }
}
