using Dapper;
using SGE_BACKEND_JUDITH_LAB.Context;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Models;
using System.Data;

namespace SGE_BACKEND_JUDITH_LAB.Services
{
    public class DestinoService : IDestinoService
    {
        private readonly Conexion _conexion;
        private IConfiguration _configuration;

        public DestinoService(Conexion conexion, IConfiguration configuration)
        {
            _conexion = conexion;
            _configuration = configuration;
        }
        public async Task<BaseResponse<IEnumerable<Destino>>> Destino(int cliec_icod_cliente)
        {
            var response = new BaseResponse<IEnumerable<Destino>>();
            try
            {
                using (var conexion = _conexion.ObtenerConnexion())
                {
                     var parameters = new { cliec_icod_cliente }; 
                    response.Data = await conexion.QueryAsync<Destino>("SGE_DIRECCION_CLIENTE_LISTAR",parameters,commandType:CommandType.StoredProcedure);
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
