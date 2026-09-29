using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblModulos
{
    public class UpdateTblModulosDTO
    {
        public int lModulo_id { get; set; }
        public string sModulo_nm { get; set; }
        public bool sModulo_estado { get; set; }
    }
}
