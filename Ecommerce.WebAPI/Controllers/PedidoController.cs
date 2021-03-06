using System.Threading.Tasks;
using Ecommerce.Dominio;
using Ecommerce.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {        
        private readonly IEcommerceRepositorio _repo;

        public PedidoController (IEcommerceRepositorio repo)
        {
            _repo = repo;
        }

        
        // GET api/values
        [HttpGet] 
        public async Task<IActionResult> GetTask()
        {
            try
            {
                var resultado = await _repo.GetAllPedidoAsync();
                return Ok(resultado);
            }
            catch (System.Exception)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão com o banco de dados!");
            }
        }  

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(Pedido model)
        {
            try
            {
                _repo.Add(model);
                
                if(await _repo.SaveChangesAsync())
                {
                    return Created($"/api/pedido/{model.Id}", model);
                }                
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão com o banco de dados!");
            }

            return BadRequest();      
        }
    }
}