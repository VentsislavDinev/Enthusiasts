using Enthusiasts.Services.Integrations.Appolo.Services.Models;
using RestSharp;

namespace Enthusiasts.Services.Integrations.Appolo.Services
{
    public class PeopleEnrichService
    {

        public async Task<RestResponse<PeopleEnrichResponseModel>> Search(string apiKey, PeopleEnrichRequestModel data)
        {
            var client = new RestClient();
            var request = new RestRequest($"https://api.apollo.io/api/v1/people/bulk_match", Method.Post);
            request.AddJsonBody(data);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("content-type", "application/json");
            return await client.ExecuteAsync<PeopleEnrichResponseModel>(request);
        }

    }
}
