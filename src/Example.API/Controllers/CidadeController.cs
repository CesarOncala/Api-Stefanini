using Example.Application.CidadeService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : BaseController
    {
        private readonly ICidadeService _service;

        public CidadeController(ILogger<ExampleController> logger, ICidadeService service) : base()
        {
            _service = service;
        }
    }
}
