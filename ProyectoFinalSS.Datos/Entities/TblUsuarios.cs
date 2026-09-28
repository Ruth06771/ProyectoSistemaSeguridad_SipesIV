using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Datos.Entities
{
    public class TblUsuarios
    {
        public int lUsuarios_id { get; set; }
        public int lPersona_id { get; set; }
        public int lPerfiles_id { get; set; }
        public string sUsuario_correo { get; set; }
        public string sUsuario_password { get; set; }
        public bool sUsuario_estado { get; set; }
    }
}
