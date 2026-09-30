using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblArea
{
    public class UpdateTblAreaDTO
    {
        public int lArea_id { get; set; }
        public int lPiso_id { get; set; }
        public string sArea_nombre { get; set; }
        public int sArea_capacidad_maxima { get; set; }
        public bool sArea_estado { get; set; }
        public string sArea_codigo_aula { get; set; }
    }
}
