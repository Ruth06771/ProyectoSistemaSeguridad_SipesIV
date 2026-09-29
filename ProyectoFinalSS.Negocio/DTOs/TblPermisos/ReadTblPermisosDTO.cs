using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblPermisos
{
    public class ReadTblPermisosDTO
    {
        public int lPermisos_id { get; set; }
        public int lPerfiles_id { get; set; }
        public int lmodulo_id { get; set; }
        public bool sPermisos_puede_ver { get; set; }
        public bool sPermisos_puede_crear { get; set; }
        public bool sPermisos_puede_editar { get; set; }
        public bool sPermisos_puede_eliminar { get; set; }
    }
}
