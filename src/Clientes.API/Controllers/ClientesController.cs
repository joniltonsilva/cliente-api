using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Clientes.API.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClientesController : ControllerBase
    {  
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] dynamic data)
        {
            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] dynamic data)
        {
            return Ok(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok(id);
        }
    }
}
