namespace ProyectoFinalSS.Datos.Entities
{
    public class TblBloqueados
    {
        public int lBloqueados_id { get; set; }
        public int lPersonas_id { get; set; }
        public DateTime sBloqueado_fecha_inicio { get; set; }
        public bool sBloqueado_estado { get; set; }
        public string sBloqueado_motivo { get; set; }
        public DateTime sBloqueado_fecha_fin { get; set; }
    }
}
