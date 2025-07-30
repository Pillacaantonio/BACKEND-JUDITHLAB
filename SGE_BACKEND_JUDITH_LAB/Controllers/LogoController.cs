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
    [Route("api/Logo")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LogoController : ControllerBase
    {
        private readonly ILogoService _logoService;
        private IMapper _mapper;

        public LogoController(ILogoService logoService, IMapper mapper)
        {
            _logoService = logoService;
            _mapper = mapper;
        }
        [HttpGet("ListaLogo")]
        public async Task<ActionResult<BaseResponse<IEnumerable<Cliente>>>> LogoList()
        {
            var data = await _logoService.LogoList();
            return Ok(data);
        }
    }
}
