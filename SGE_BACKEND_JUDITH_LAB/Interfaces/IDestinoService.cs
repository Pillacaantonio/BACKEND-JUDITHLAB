using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Interfaces
{
    public interface IDestinoService
    {
        Task<BaseResponse<IEnumerable<Destino>>> Destino(int cliec_icod_cliente);

    }
}
