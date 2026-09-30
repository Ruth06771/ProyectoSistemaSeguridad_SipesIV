using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblUsuarios
{
    public class CreateTblUsuariosDTO
    {
      
        public int lPersonas_id { get; set; }
        public int lPerfiles_id { get; set; }
        public string sUsuario_correo { get; set; }
        public string sUsuario_password { get; set; }
        public bool sUsuario_estado { get; set; }
    }
}
