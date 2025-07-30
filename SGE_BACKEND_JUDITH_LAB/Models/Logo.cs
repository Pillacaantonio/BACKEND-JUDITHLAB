namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class Logo
    {
        public int iid_logo { get; set; }
        public int cliec_icod_cliente { get; set; }
        public string? log_nombre { get; set; }
        public string? log_observacion { get; set; }
        public byte[] log_img { get; set; }
        public string? log_iid_direccion { get; set; }
        public string? cliec_vnombre_cliente { get; set; }
        public string? log_estado { get; set; }
 
    }
}
