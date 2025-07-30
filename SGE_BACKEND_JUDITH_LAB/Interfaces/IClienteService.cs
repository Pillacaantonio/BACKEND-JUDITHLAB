using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Interfaces
{
    public interface IClienteService
    {
        Task<BaseResponse<IEnumerable<Cliente>>> ClienteList();

    }
}
