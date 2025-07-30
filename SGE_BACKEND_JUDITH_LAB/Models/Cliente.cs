namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class Cliente
    {
        public int cliec_icod_cliente { get; set; }
        public string? cliec_vnombre_cliente { get; set; }
        public string? cliec_vapellido_paterno { get; set; }
        public string? cliec_vapellido_materno { get; set; } 
        public string? cliec_vdireccion_cliente { get; set; }
        public string? cliec_vnro_telefono { get; set; }
        public int cliec_cruc { get; set; }
        public string? cliec_observacion1 { get; set; }
        public string? cliec_observacion2 { get; set; }
        public string? Situacion { get; set; }
        public string? TipoDoc { get; set; }


    }
}
