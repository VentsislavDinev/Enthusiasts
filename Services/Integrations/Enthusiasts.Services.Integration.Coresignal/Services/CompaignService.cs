using Enthusiasts.Services.Integration.Coresignal.Services.Models;
using RestSharp;

namespace Enthusiasts.Services.Integration.Coresignal.Services
{
    public class CompaignService
    {
        public async Task<RestResponse<string>> SearchCompany(string apiKey, CompanyRequestModel data)
        {
            var client = new RestClient();
            var request = new RestRequest($"https://api.coresignal.com/cdapi/v1/linkedin/company/search/filter", Method.Post);
            request.AddJsonBody(data);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer " + apiKey);
            request.AddHeader("content-type", "application/json");

            return await client.ExecuteAsync<string>(request);
        }

        public async Task<RestResponse<CompanyResponseModel>> Company(string apiKey, string companyId)
        {
            var client = new RestClient();
            var request = new RestRequest($"https://api.coresignal.com/cdapi/v1/linkedin/company/collect/{companyId}", Method.Get);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer " + apiKey);

            return await client.ExecuteAsync<CompanyResponseModel>(request);
        }
    }
}

