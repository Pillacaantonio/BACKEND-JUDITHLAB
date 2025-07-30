using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Interfaces
{
    public interface IVendedorService
    {
        Task<BaseResponse<IEnumerable<Vendedor>>> VendedorList();

    }
 
}
