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
    [Route("api/Direccion")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DireccionController : Controller
    {
        private readonly IDestinoService _destinoService;
        private IMapper _mapper;
        public DireccionController(IDestinoService destinoService, IMapper mapper)
        {
            _destinoService = destinoService;
            _mapper = mapper;
        }

        [HttpGet("Destino/{id}")]
        public async Task<ActionResult<BaseResponse<IEnumerable<Destino>>>> Destino(int id)
        {
             var data = await _destinoService.Destino(id); 
             return Ok(data);
        }
    }
}
