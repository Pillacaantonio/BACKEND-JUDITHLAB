using Dapper;
using SGE_BACKEND_JUDITH_LAB.Context;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Models;
using System.Data;

namespace SGE_BACKEND_JUDITH_LAB.Services
{
    public class MetodoPagoService : IMetodoPagoService
    {
        private readonly Conexion _conexion;
        private IConfiguration _configuration;

        public MetodoPagoService(Conexion conexion, IConfiguration configuration)
        {
            _conexion = conexion;
            _configuration = configuration;
        }
        public async Task<BaseResponse<IEnumerable<MetodoPago>>> ListarMetodoPago()
        {
            var response = new BaseResponse<IEnumerable<MetodoPago>>();
            try
            {
                using (var conexion = _conexion.ObtenerConnexion())
                {
                    response.Data = await conexion.QueryAsync<MetodoPago>("SGE_LISTAR_TIPO_PAGO", commandType: CommandType.StoredProcedure);
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
