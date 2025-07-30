namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class CotizacionDetalle
    {
        public int CtvdIcodDetalleOc { get; set; }
        public int CtvcIcodCotizacionVenta { get; set; }
        public int CtvdIitem { get; set; }
        public int PrdcIcodProducto { get; set; }
        public decimal CtvdNcantidad { get; set; }
        public decimal CtvdNprecioUnitario { get; set; }
        public decimal CtvdNmontoTotal { get; set; }
        public int CtvdIusuarioCrea { get; set; }
        public string CtvdVpcCrea { get; set; }
        public bool CtvdFlagEstado { get; set; }
        public string CtvdVdescripcion { get; set; }
        public string CtvdVcaracteristicas { get; set; }
        public decimal CtvdVdescuento1 { get; set; }
        public decimal CtvdVdescuento2 { get; set; }
        public decimal CtvdVunitarioBase { get; set; }
        public string CtvdCategoria { get; set; }
        public int CtvdIdCategoria { get; set; }
        public CotizaccionCab Cotizacion { get; set; }


    }
}
