namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class MetodoPago
    {
        public int tarec_icorrelativo_registro { get; set; }
        public string? tarec_vdescripcion { get; set; }
        public string? tarec_vtipo_operacion { get; set; }
        public int tarec_iid_tabla_registro { get; set; }
         public int tarec_iid_tabla_registro_ingreso { get; set; }
        public int tarec_iid_tabla_registro_salida { get; set; }
    }
}
