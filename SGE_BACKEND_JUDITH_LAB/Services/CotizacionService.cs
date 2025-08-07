using Dapper;
using Microsoft.Data.SqlClient;
using SGE_BACKEND_JUDITH_LAB.Context;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Models;
using System.Data;

namespace SGE_BACKEND_JUDITH_LAB.Services
{
    public class CotizacionService :ICotizacionService
    {
        private readonly Conexion _conexion;
        private IConfiguration _configuration;

        public CotizacionService(Conexion conexion, IConfiguration configuration)
        {
            _conexion = conexion;
            _configuration = configuration;
        }

        public async Task<BaseResponse<IEnumerable<Cotizacion>>> CotizacionList()
        {
 
            var response = new BaseResponse<IEnumerable<Cotizacion>>();
            try
            {
                using (var conexion = _conexion.ObtenerConnexion())
                {
                    response.Data = await conexion.QueryAsync<Cotizacion>("SGEV_COTIZACION_VENTA_LISTAR_WEB", commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                response.innerExeption = ex.Message;
                response.IsSucces = false;
            }

            return response;
        }

      

        public Task<string> CrearProducto(Cotizacion request)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<IEnumerable<ProdTerminado>>> ProdTerminadoList()
        {
            var response = new BaseResponse<IEnumerable<ProdTerminado>>();
            try
            {
                using (var conexion = _conexion.ObtenerConnexion())
                {
                    response.Data = await conexion.QueryAsync<ProdTerminado>("SGEA_PRODUCTO_LISTAR_CON_PRECIO_WEB", commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                response.innerExeption = ex.Message;
                response.IsSucces = false;
            }

            return response;
        }
        public async Task<string> CrearCotizacion(CotizaccionCab cabecera)
        {
             using (var connection = _conexion.ObtenerConnexion())
            {
                

                 using (var transaction = connection.BeginTransaction()) 
                {
                    try
                    {
                        if (cabecera.CtvcSfechaCotizacionVenta == DateTime.MinValue)
                        {
                            cabecera.CtvcSfechaCotizacionVenta = DateTime.Now;  
                        }
                        DateTime CtvcSfechaCotizacionVenta = DateTime.Parse("2025-07-22T07:39:58.341Z").ToLocalTime();
                       
                        // Parámetros de la cabecera
                        var parametrosCabecera = new
                        {
                            ctvc_icod_cotizacion_venta = 0,  // Se generará automáticamente
                            ctvc_ianio = cabecera.CtvcIanio,
                            ctvc_numero_cotizacion_venta = cabecera.CtvcNumeroCotizacionVenta,
                            ctvc_sfecha_cotizacion_venta = cabecera.CtvcSfechaCotizacionVenta,
                            cliec_icod_cliente = cabecera.CliecIcodCliente,
                            cliec_vcod_cliente = cabecera.CliecVcodCliente,
                            tablc_iid_tipo_moneda = cabecera.TablcIidTipoMoneda,
                            ctvc_npor_imp_igv = cabecera.CtvcNporImpIgv,
                            ctvc_nmonto_sub_Total = cabecera.CtvcNmontoSubTotal,
                            ctvc_nmonto_imp = cabecera.CtvcNmontoImp,
                            ctvc_nmonto_total = cabecera.CtvcNmontoTotal,
                            tablc_iid_situacion_oc = cabecera.TablcIidSituacionOc,
                            tablc_iforma_pago = cabecera.TablcIformaPago,
                            ctvc_bIncluido_igv = cabecera.CtvcBIncluidoIgv,
                            ctvc_iusuario_crea = cabecera.CtvcIusuarioCrea,
                            ctvc_vpc_crea = cabecera.CtvcVpcCrea,
                            ctvc_flag_estado = cabecera.CtvcFlagEstado,
                            ctvc_vatencion = cabecera.CtvcVatencion,
                            ctvc_vforma_pago = cabecera.CtvcVformaPago,
                            ctvc_vtiempo_entrega = cabecera.CtvcVtiempoEntrega,
                            ctvc_vvalidez_oferta = cabecera.CtvcVvalidezOferta,
                            ctvc_vlugar_entrega = cabecera.CtvcVlugarEntrega,
                            ctvc_vnota_cotizacion = cabecera.CtvcVnotaCotizacion,
                            ctvc_vreferencia = cabecera.CtvcVreferencia,
                            ctvc_numero_telefono = cabecera.CtvcNumeroTelefono,
                            cliec_vnombre_cliente=cabecera.cliecVnombreCliente,
                            cliec_dni_cliente=cabecera.cliecVDniCliente,
                            cliec_ruc_cliente=cabecera.cliecVRuc,
                            cliec_correo_cliente=cabecera.cliecVCorreo,
                            cliec_direccion_cliente=cabecera.cliecVNumero,
                             ctvc_id_ilugar_entrega=cabecera.ctvIdLugarEntrega,
                            iid_logo=cabecera.IdLogo,
                            log_nombre=cabecera.logVNombre,
                            ctvc_envio_provincia=cabecera.ctcvEnvio,
                            tablc_itipo_pago=cabecera.tablcItipoPago,
                            ctvc_monto_pagado=cabecera.ctvcMontoPago,
                            ctvc_monto_saldo=cabecera.ctvcMontoSaldo,
                            vdrsc_icod_vendedor=cabecera.vdrscIcodVendedor,
                            ctvd_proc_descuento=cabecera.ctvdPocDescuento,
                            ctvd_monto_descuento=cabecera.ctvdMontoDescuento,
                            tdocc_icod_tipo_doc=cabecera.tdoccIcodTipoDoc,
                            ctvd_monto_vuelto=cabecera.ctvdMontoVuelto

                        };
                        var rowsAffected = await connection.ExecuteAsync("SGEV_COTIZACION_VENTA_INSERTAR", parametrosCabecera, transaction: transaction, commandType: CommandType.StoredProcedure);

                        //await connection.ExecuteAsync("SGEV_COTIZACION_VENTA_INSERTAR", parametrosCabecera, transaction: transaction, commandType: CommandType.StoredProcedure);

                        var idCotizacion = await connection.QuerySingleOrDefaultAsync<int?>("SELECT @@IDENTITY;", transaction: transaction);
                        if (idCotizacion.HasValue)
                        {
                            Console.WriteLine($"El ID de la cotización es: {idCotizacion.Value}");
                        }
                        else
                        {
                            Console.WriteLine("No se ha generado un ID de cotización.");
                        }

                        foreach (var detalle in cabecera.Detalles)
                        {
                            var parametrosDetalle = new
                            {
                                ctvd_icod_detalle_oc = 0,  // Se generará automáticamente
                                ctvc_icod_cotizacion_venta = idCotizacion,
                                ctvd_iitem = detalle.CtvdIitem,
                                prdc_icod_producto = detalle.PrdcIcodProducto,
                                ctvd_ncantidad = detalle.CtvdNcantidad,
                                ctvd_nprecio_unitario = detalle.CtvdNprecioUnitario,
                                ctvd_nmonto_total = detalle.CtvdNmontoTotal,
                                ctvd_iusuario_crea = detalle.CtvdIusuarioCrea,
                                ctvd_vpc_crea = detalle.CtvdVpcCrea,
                                ctvd_flag_estado = detalle.CtvdFlagEstado,
                                ctvd_vdescripcion = detalle.CtvdVdescripcion,
                                ctvd_vcaracteristicas = detalle.CtvdVcaracteristicas,
                                ctvd_vdescuento1 = detalle.CtvdVdescuento1,
                                ctvd_vdescuento2 = detalle.CtvdVdescuento2,
                                ctvd_vunitario_base = detalle.CtvdVunitarioBase,
                                ctvd_categoria = detalle.CtvdCategoria,
                                ctvd_id_categoria = detalle.CtvdIdCategoria
                            };

                             await connection.ExecuteAsync("SGEV_COTIZACION_VENTA_DETALLE_INSERTAR", parametrosDetalle, transaction: transaction, commandType: CommandType.StoredProcedure);
                        }

                         transaction.Commit();

                        return $"Cotización y detalles insertados con éxito. ID: {idCotizacion}";
                    }
                    catch (Exception ex)
                    {
                         transaction.Rollback();
                        return $"Error al crear la cotización: {ex.Message}";
                    }
                }
            }
        }

        public async Task<BaseResponse<IEnumerable<CorrelativoCotizacion>>> Correlativo()
        {
            var response = new BaseResponse<IEnumerable<CorrelativoCotizacion>>();
            try
            {
                using (var conexion = _conexion.ObtenerConnexion())
                {
                    response.Data = await conexion.QueryAsync<CorrelativoCotizacion>("SGE_OBTENER_ULT_CORRELATIVO_COTIZACION", commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                response.innerExeption = ex.Message;
                response.IsSucces = false;
            }

            return response;
        }
    }
}
 