namespace ProyectoFinalSS.Datos.Entities
{
    public class TblRegistroAccesos
    {
        public int lRegistro_Accesos_id { get; set; }
        public int lPersonas_id { get; set; }
        public int llector_id { get; set; }
        public bool sRegistro_Autorizado { get; set; }
        public string sRegistro_motivo_denegacion { get; set; }
        public DateTime sRegistro_fecha_hora { get; set; }

    }
}
