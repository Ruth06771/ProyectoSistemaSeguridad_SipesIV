using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblPisos
{
    public class ReadTblPisosDTO
    {
        public int lPisos_id { get; set; }
        public int lEdificios_id { get; set; }
        public string sPiso_nombre { get; set; }
        public string sPiso_codigo_corto { get; set; }
    }
}
