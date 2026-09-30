using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalSS.Negocio.DTOs.TblConfiguracionSistema
{
    public class ReadTblConfiguracionSistemaDTO
    {
        public int lConfig_id { get; set; }
        public int lUsuario_id { get; set; }
        public int sConfig_intentos_fallidos_bloqueo { get; set; }
        public int sConfig_inactividad_sesion { get; set; }
        public int sConfig_tolerancia_marcaje_minutos { get; set; }
        public int sConfig_tiempo_antipassck { get; set; }
        public int sConfig_alertas_intentos_denegados { get; set; }
        public DateTime sConfig_fecha_actualizacion { get; set; }
    }
}
