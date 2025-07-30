namespace SGE_BACKEND_JUDITH_LAB.Models
{
    public class Cotizacion
    {
        // Información de la cotización
        public int icod_cotizacion { get; set; }
        public int anio_cotizacion { get; set; }
        public string? numero_cotizacion { get; set; }
        public DateTime fecha_cotizacion { get; set; }

        // Información del cliente
        public int icod_cliente { get; set; }
        public string? vcod_cliente { get; set; }
        public string? nombre_cliente { get; set; }
        public string? direccion_cliente { get; set; }
        public string? dni_cliente { get; set; }
        public string? ruc_cliente { get; set; }
        public string? correo_cliente { get; set; }
        public string? direccion_cliente_cliente { get; set; }  
        public string? cruz_cliente { get; set; }
        public string? telefono_cliente { get; set; }

  

        // Información sobre impuestos y montos
        public decimal porcentaje_igv { get; set; }
        public decimal monto_sub_total { get; set; }
        public decimal monto_impuesto { get; set; }
        public decimal monto_total { get; set; }

        // Información sobre la situación de la cotización
        public int situacion_oc { get; set; }
        public string? descripcion_situacion { get; set; }

        // Información de pago y otros detalles
        public int forma_pago { get; set; }
        public bool incluido_igv { get; set; }
        public string atencion { get; set; }
        public string? forma_pago_detalle { get; set; }
        public string? tiempo_entrega { get; set; }
         public string? lugar_entrega { get; set; }
        public string? nota_cotizacion { get; set; }
        public string? referencia_cotizacion { get; set; }

        // Información adicional sobre el cliente
        // public string? telefono_cliente_cotizacion { get; set; }
        //public string? numero_telefono_cliente { get; set; }

        // Información de la ubicación y logos
        //public string? lugar_entrega_cliente { get; set; }
        //public int logo_id { get; set; }
        //public string? logo_nombre { get; set; }

        // Información de la provincia y pagos
        public string? envio_provincia { get; set; }
        public int tipo_pago { get; set; }
        public decimal monto_pagado { get; set; }
        public decimal monto_saldo { get; set; }
        public decimal monto_vuelto { get; set; }
        // Vendedor y descuentos
        public string? nombre_vendedor { get; set; }
        public decimal porcentaje_descuento { get; set; }
        public decimal monto_descuento { get; set; }

        // Tipo de documento
        public int tipo_documento_id { get; set; }
        public string? tipo_documento_abreviatura { get; set; }
        public string? tipo_documento_descripcion { get; set; }

        // Vuelto y notas
         public int nota_venta_id { get; set; }
        public string? numero_nota_venta { get; set; }

        // Estado de la guía y remisión
        public string? estado_guia { get; set; }
        public int remision_id { get; set; }

        // Información del vendedor
        public int Vendedor_Id { get; set; }

        // Fechas de creación y modificación
        public DateTime fecha_creacion_cotizacion { get; set; }
        public DateTime fecha_creacion { get; set; }
        public string? usuario_creacion { get; set; }
        public int usuario_modificacion { get; set; }
        public DateTime fecha_modificacion { get; set; }
        public string? usuario_modificacion_detalle { get; set; }
    }
}
