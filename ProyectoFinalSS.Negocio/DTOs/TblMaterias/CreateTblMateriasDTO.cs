using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblMaterias
{
    public class CreateTblMateriasDTO
    {
        public string sMateria_codigo { get; set; }
        public string sMateria_nombre { get; set; }
        public bool sMateria_estado { get; set; }
    }
}
