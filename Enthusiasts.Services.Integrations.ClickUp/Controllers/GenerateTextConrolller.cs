using Enthusiasts.Services.Integrations.ClickUp.Services;
using Enthusiasts.Services.Integrations.ClickUp.Services.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enthusiasts.Services.Integrations.ClickUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateTextConrolller : ControllerBase
    {
        private readonly GenerateTextService _generateText;

        public GenerateTextConrolller(GenerateTextService generateText)
        {
            _generateText = generateText;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ResponseGenerateTextModel Get(GenerateTextModel data)
        {
            return _generateText.Create("", "", data).Result.Data;
        }
    }
}
