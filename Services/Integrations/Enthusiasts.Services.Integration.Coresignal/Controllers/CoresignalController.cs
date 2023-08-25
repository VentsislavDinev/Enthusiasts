using Enthusiasts.Services.Integration.Coresignal.Services;
using Enthusiasts.Services.Integration.Coresignal.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace Enthusiasts.Services.Integration.Coresignal.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CoresignalController : ControllerBase
    {
        private readonly CompaignService _service;

        public CoresignalController(CompaignService service)
        {
            _service = service;
        }

        [HttpGet(Name = "Company")]
        public string Get(CompanyRequestModel data)
        {
            return _service.SearchCompany("", data).Result.Data;
        }
        [HttpGet(Name  = "View")]
        public CompanyResponseModel View(string companyId)
        {
            return _service.Company("ApiKey", "companyId").Result.Data;
        }
    }
}
