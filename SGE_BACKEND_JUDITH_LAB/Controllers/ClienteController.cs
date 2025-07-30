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
    [Route("api/Cliente")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private IMapper _mapper;

        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }
        [HttpGet("ListaCliente")]
        public async Task<ActionResult<BaseResponse<IEnumerable<Cliente>>>> ClienteList()
        {
            var data = await _clienteService.ClienteList();
            return Ok(data);
        }
    }
}
