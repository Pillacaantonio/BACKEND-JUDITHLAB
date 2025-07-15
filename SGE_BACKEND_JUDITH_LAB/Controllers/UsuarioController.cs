using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Models;
using System.Security.Claims;

namespace SGE_BACKEND_JUDITH_LAB.Controllers
{
    [Route("api/Usuarios")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse<IEnumerable<Usuarios>>>> GetAll()
        {
            var data = await _usuarioService.UsuarioList();
            return Ok(data);
        }

        [HttpGet("{usua_icod_usuario}")]
        public async Task<ActionResult<BaseResponse<Usuarios>>> GetById(int usua_icod_usuario)
        {
            var data = await _usuarioService.UsuarioGetById(usua_icod_usuario);
            return Ok(data);
        }

        [AllowAnonymous]
        [HttpPost("generate/token")]
        public async Task<ActionResult<BaseResponse<string>>> Post([FromBody] TokenRequestDto tokenRequestDto)
        {
            var response = await _usuarioService.GenerateToken(tokenRequestDto);
            return Ok(response);
        }

        [HttpGet("validarToken")]
        public async Task<ActionResult<BaseResponse<Token>>> GetUserByToken()
        {
            var response = new BaseResponse<Token>();
            var identntity = HttpContext.User.Identity as ClaimsIdentity;
            var userclaims = identntity!.Claims;
            var id = userclaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value;
            var usuario = await _usuarioService.UsuarioGetById(Convert.ToInt32(id));
            var nuevoToken = await _usuarioService.GenerateToken(new TokenRequestDto() { email = usuario.Data!.usua_codigo_usuario!, password = usuario.Data.usua_password_usuario! });

            response.Data = _mapper.Map<Token>(usuario.Data);
            response.Data.token = nuevoToken.Data!;
            return Ok(response);

        }
    }
}
