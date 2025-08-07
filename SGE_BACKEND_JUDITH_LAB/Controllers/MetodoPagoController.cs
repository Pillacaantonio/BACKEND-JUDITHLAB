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
    [Route("api/MetodoPago")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MetodoPagoController : Controller
    {
        private readonly IMetodoPagoService _metodoPagoService;
        private IMapper _mapper;

        public MetodoPagoController(IMetodoPagoService metodoPagoService, IMapper mapper)
        {
            _metodoPagoService = metodoPagoService;
            _mapper = mapper;
        }
        [HttpGet("ListaMetoPago")]
        public async Task<ActionResult<BaseResponse<IEnumerable<Cliente>>>> ListarMetodoPago()
        {
            var data = await _metodoPagoService.ListarMetodoPago();
            return Ok(data);
        }

    }
}
