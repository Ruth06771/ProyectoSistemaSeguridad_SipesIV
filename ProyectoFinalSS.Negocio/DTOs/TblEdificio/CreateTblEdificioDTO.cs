using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblEdificio
{
    public class CreateTblEdificioDTO
    {
        public string sEdificio_nombre { get; set; }
        public bool sEdificio_estado { get; set; }
        public string sEdificio_descripcion { get; set; }
    }
}
