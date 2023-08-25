using RestSharp.Authenticators.OAuth2;
using RestSharp;
using Enthusiasts.Services.Integrations.ClickUp.Services.Model;
using Microsoft.Extensions.Options;

namespace Enthusiasts.Services.Integrations.ClickUp.Services
{
    public class GenerateTextService
    {
        public async Task<RestResponse<ResponseGenerateTextModel>> Create(string apiKey, string apiToken, GenerateTextModel data)
        {
            var client = new RestClient();
            var request = new RestRequest($"https://backofficeapi.neuro-flash.com/api/v1/word-embedding/generate_text", Method.Post);
            request.AddJsonBody(data);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("x-API-KEY", apiKey);
            request.AddHeader("X-API-TOKEN", apiToken);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            return await client.ExecuteAsync<ResponseGenerateTextModel>(request);
        }
    }
}
