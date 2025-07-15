using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Interfaces
{
    public interface IUsuarioService
    {
        Task<BaseResponse<IEnumerable<Usuarios>>> UsuarioList();
        Task<BaseResponse<Usuarios>> UsuarioGetById(int icod);
        Task<BaseResponse<string>> GenerateToken(TokenRequestDto tokenRequestDto);
    }
}
