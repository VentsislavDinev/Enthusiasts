using Enthusiasts.Services.Integrations.Appolo.Services;
using Enthusiasts.Services.Integrations.Appolo.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enthusiasts.Services.Integrations.Appolo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleSearchController : ControllerBase
    {
        private readonly PeopleSearchService _service;

        public PeopleSearchController(PeopleSearchService service)
        {
            _service = service;
        }

        [HttpGet(Name = "Company")]
        public PeopleSearchResponseModel Get(PeopleSearchRequestModel data)
        {
            return _service.Search("", data).Result.Data;
        }
    }
}
