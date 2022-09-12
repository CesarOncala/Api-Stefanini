using Example.Application.PessoaService.Service;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : BaseController
    {
        private readonly IPessoaService _service;

        public PessoaController(ILogger<ExampleController> logger, IPessoaService service) : base()
        {
            _service = service;
        }


    }
}
