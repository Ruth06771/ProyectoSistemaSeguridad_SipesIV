using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblPerfiles
{
    public class ReadTblPerfilesDTO
    {
        public int lPerfiles_id { get; set; }
        public string sPerfiles_nm { get; set; }
        public bool sPerfiles_estado { get; set; }
        public string sPerfiles_descripcion { get; set; }
    }
}
