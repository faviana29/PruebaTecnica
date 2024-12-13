using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Services;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteStoreProcedureService _storeProcedureService;
        private readonly ClienteLinqService _linqService;

        public ClientesController(ClienteStoreProcedureService storeProcedureService, ClienteLinqService linqService)
        {
            _storeProcedureService = storeProcedureService;
            _linqService = linqService;
        }

       
        [HttpGet("store-procedure")]
        public async Task<IActionResult> ObtenerClientesSP(int pagina = 1, int tama�o = 10)
        {
            try
            {
                var clientes = await _storeProcedureService.ObtenerClientesPaginados(pagina, tama�o);
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al obtener los clientes con Store Procedure.", error = ex.Message });
            }
        }

        
        [HttpGet("linq")]
        public async Task<IActionResult> ObtenerClientesLinq(int pagina = 1, int tama�o = 10)
        {
            try
            {
                var clientes = await _linqService.ObtenerClientesPaginados(pagina, tama�o);
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al obtener los clientes con LINQ.", error = ex.Message });
            }
        }
    }
}
