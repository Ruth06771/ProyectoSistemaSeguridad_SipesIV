namespace ProyectoFinalSS.Datos.Entities
{
    public class TblLogsSistema
    {
        public int lLog_id { get; set; }
        public int lUsuario_id { get; set; }
        public string sLog_modulo { get; set; }
        public string sLog_accion { get; set; }
        public string sLog_detalle { get; set; }
        public string sLog_origen { get; set; }
        public DateTime sLog_fecha_origen { get; set; }


    }
}
