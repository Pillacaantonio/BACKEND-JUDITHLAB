using Dapper;
using SGE_BACKEND_JUDITH_LAB.Context;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Models;
using System.Data;

namespace SGE_BACKEND_JUDITH_LAB.Services
{
    public class LogoService:ILogoService
    {
        private readonly Conexion _conexion;
        private IConfiguration _configuration;

        public LogoService(Conexion conexion, IConfiguration configuration)
        {
            _conexion = conexion;
            _configuration = configuration;
        }

        public async Task<BaseResponse<IEnumerable<Logo>>> LogoList()
        {
            var response = new BaseResponse<IEnumerable<Logo>>();
            try
            {
                using (var conexion = _conexion.ObtenerConnexion())
                {
                    response.Data = await conexion.QueryAsync<Logo>("SGE_DIRECCION_LOGO_LISTAR_TODO", commandType: CommandType.StoredProcedure);
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
