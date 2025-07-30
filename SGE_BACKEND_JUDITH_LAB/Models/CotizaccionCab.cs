namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class CotizaccionCab
    {
        public int CtvcIcodCotizacionVenta { get; set; }
        public int CtvcIanio { get; set; }
        public string CtvcNumeroCotizacionVenta { get; set; }
        public DateTime CtvcSfechaCotizacionVenta { get; set; }
        public int CliecIcodCliente { get; set; }
        public string CliecVcodCliente { get; set; }
        public int TablcIidTipoMoneda { get; set; }
        public decimal CtvcNporImpIgv { get; set; }
        public decimal CtvcNmontoSubTotal { get; set; }
        public decimal CtvcNmontoImp { get; set; }
        public decimal CtvcNmontoTotal { get; set; }
        public int TablcIidSituacionOc { get; set; }
        public int TablcIformaPago { get; set; }
        public bool CtvcBIncluidoIgv { get; set; }
        public int CtvcIusuarioCrea { get; set; }
        public string CtvcVpcCrea { get; set; }
        public bool CtvcFlagEstado { get; set; }
        public string CtvcVatencion { get; set; }
        public string CtvcVformaPago { get; set; }
        public string CtvcVtiempoEntrega { get; set; }
        public string CtvcVvalidezOferta { get; set; }
        public string CtvcVlugarEntrega { get; set; }
        public string CtvcVnotaCotizacion { get; set; }
        public string CtvcVreferencia { get; set; }
        public string CtvcNumeroTelefono { get; set; }
        public string cliecVnombreCliente { get; set; }
        public string? cliecVDniCliente { get; set; }
        public string? cliecVRuc { get; set; }
        public string? cliecVCorreo { get; set; }
        public string? cliecVNumero { get; set; }
        public int? ctvIdLugarEntrega { get; set; }
        public int? IdLogo { get; set; }
        public string? logVNombre { get; set; }
        public bool? ctcvEnvio { get; set; }
        public int? tablcItipoPago { get; set; }
        public decimal? ctvcMontoPago { get; set; }
        public decimal? ctvcMontoSaldo { get; set; }
        public int? vdrscIcodVendedor { get; set; }
        public decimal? ctvdPocDescuento { get; set; }
        public decimal? ctvdMontoDescuento { get; set; }
        public int? tdoccIcodTipoDoc { get; set; }
        public decimal? ctvdMontoVuelto { get; set; }
 
        public List<CotizacionDetalle> Detalles { get; set; }

    }
}
