using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Interfaces
{
    public interface ICotizacionService
    {
        Task<BaseResponse<IEnumerable<Cotizacion>>> CotizacionList();
        Task<string> CrearCotizacion(CotizaccionCab cabecera);
        Task<BaseResponse<IEnumerable<ProdTerminado>>> ProdTerminadoList();


    }
}
