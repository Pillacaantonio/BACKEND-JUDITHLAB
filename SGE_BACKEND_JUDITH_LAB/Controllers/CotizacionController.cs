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
    [Route("api/Cotizacion")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CotizacionController : ControllerBase
    {
        private readonly ICotizacionService _cotizacionService;
        private IMapper _mapper;

        public CotizacionController(ICotizacionService cotizacionService, IMapper mapper)
        {
            _cotizacionService = cotizacionService;
            _mapper = mapper;
        }

        [HttpGet("listadoCotizacion")] 
        public async Task<ActionResult<BaseResponse<IEnumerable<Cotizacion>>>> GetAll()
        {
            var data = await _cotizacionService.CotizacionList();
            return Ok(data);
        }
        [HttpGet("Pterminado")]
        public async Task<ActionResult<BaseResponse<IEnumerable<ProdTerminado>>>> ProdTerminadoList()
        {
            var data = await _cotizacionService.ProdTerminadoList();
            return Ok(data);
        }
        [HttpPost("InsertarCotizacion")]
        public async Task<ActionResult<CotizacionCabDto>> CrearCotizacion([FromBody] CotizacionCabDto dto)
        {
          
            var cabecera = _mapper.Map<CotizaccionCab>(dto); 

             var result = await _cotizacionService.CrearCotizacion(cabecera);

            if (string.IsNullOrEmpty(result))  
            {
                return BadRequest("Error al crear la cotización");
            }

             return CreatedAtAction(nameof(CrearCotizacion), new { id = cabecera.CtvcIcodCotizacionVenta }, dto);
        }
    }
}
