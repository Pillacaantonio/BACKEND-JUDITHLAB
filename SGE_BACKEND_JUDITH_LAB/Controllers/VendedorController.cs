using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Models;
using SGE_BACKEND_JUDITH_LAB.Services;

namespace SGE_BACKEND_JUDITH_LAB.Controllers
{
    [Route("api/Vendedor")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorService _vendedorService;
        private IMapper _mapper;

        public VendedorController(IVendedorService vendedorService, IMapper mapper)
        {
            _vendedorService = vendedorService;
            _mapper = mapper;
        }
        [HttpGet("ListaVendedor")]
        public async Task<ActionResult<BaseResponse<IEnumerable<Cliente>>>> VendedorList()
        {
            var data = await _vendedorService.VendedorList();
            return Ok(data);
        }
    }
}
