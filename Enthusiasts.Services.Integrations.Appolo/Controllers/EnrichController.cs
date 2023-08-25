using Enthusiasts.Services.Integrations.Appolo.Services;
using Enthusiasts.Services.Integrations.Appolo.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enthusiasts.Services.Integrations.Appolo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrichController : ControllerBase
    {
        private readonly PeopleEnrichService _service;

        public EnrichController(PeopleEnrichService service)
        {
            _service = service;
        }

        [HttpGet(Name = "Company")]
        public PeopleEnrichResponseModel Get(PeopleEnrichRequestModel data)
        {
            return _service.Search("", data).Result.Data;
        }
    }
}
