using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Dtos
{
    public class CotizacionCabDto
    {
        //public int ctvc_icod_cotizacion_venta { get; set; }
        //public int ctvc_ianio { get; set; }
        //public string? ctvc_numero_cotizacion_venta { get; set; }
        //public DateTime ctvc_sfecha_cotizacion_venta { get; set; }
        //public int cliec_icod_cliente { get; set; }
        //public int cliec_vcod_cliente { get; set; }
        //public int tablc_iid_tipo_moneda { get; set; }
        //public decimal ctvc_npor_imp_igv { get; set; }
        //public decimal ctvc_nmonto_sub_Total { get; set; }
        //public decimal ctvc_nmonto_imp { get; set; }
        //public decimal ctvc_nmonto_total { get; set; }
        //public int tablc_iid_situacion_oc { get; set; }
        //public int tablc_iforma_pago { get; set; }
        //public bool ctvc_bIncluido_igv { get; set; }
        //public int ctvc_iusuario_crea { get; set; }
        //public string? ctvc_vpc_crea { get; set; }
        //public bool ctvc_flag_estado { get; set; }
        //public string? ctvc_vatencion { get; set; }
        //public string? ctvc_vforma_pago { get; set; }
        //public string? ctvc_vtiempo_entrega { get; set; }
        //public string? ctvc_vvalidez_oferta { get; set; }
        //public string? ctvc_vlugar_entrega { get; set; }
        //public string? ctvc_vnota_cotizacion { get; set; }
        //public string? ctvc_vreferencia { get; set; }
        //public string? ctvc_numero_telefono { get; set; }
        //public string? cliecVnombreCliente { get; set; }
        //public string? cliec_dni_cliente { get; set; }
        //public string? cliec_ruc_cliente { get; set; }
        //public string? cliec_correo_cliente { get; set; }
        //public string? cliec_direccion_cliente { get; set; }
        //public int? ctvc_id_ilugar_entrega { get; set; }
        //public int? iid_logo { get; set; }
        //public string? log_nombre { get; set; }
        //public bool? ctvc_envio_provincia { get; set; }
        //public int? tablc_itipo_pago { get; set; }
        //public decimal? ctvc_monto_pagado { get; set; }
        //public decimal? ctvc_monto_saldo { get; set; }
        //public int? vdrsc_icod_vendedor { get; set; }
        //public decimal? ctvd_proc_descuento { get; set; }
        //public decimal? ctvd_monto_descuento { get; set; }
        //public int? tdocc_icod_tipo_doc { get; set; }
        //public decimal? ctvd_monto_vuelto { get; set; }
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

        public List<CotizacionDetalleDto> Detalles { get; set; }
    }

    public class CotizacionDetalleDto
    {
        public int ctvdIcodDetalleOc { get; set; }
        public int ctvcIcodCotizacionVenta { get; set; }
        public int ctvdIitem { get; set; }
        public int prdcIcodProducto { get; set; }
        public decimal ctvdNcantidad { get; set; }
        public decimal ctvdNprecioUnitario { get; set; }
        public decimal ctvdNmontoTotal { get; set; }
        public int ctvdIusuarioCrea { get; set; }
        public string ctvdVpcCrea { get; set; }
        public bool ctvdFlagEstado { get; set; }
        public string ctvdVdescripcion { get; set; }
        public string ctvdVcaracteristicas { get; set; }
        public decimal ctvdVdescuento1 { get; set; }
        public decimal ctvdVdescuento2 { get; set; }
        public decimal ctvdVunitarioBase { get; set; }
        public string ctvdCategoria { get; set; }
        public int ctvdIdCategoria { get; set; }
    }

}
