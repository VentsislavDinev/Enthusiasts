using Enthusiasts.Services.Integrations.Rytr.Services.Models;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System.Security.Cryptography;

namespace Enthusiasts.Services.Integrations.Rytr.Services
{
    public class ContentService
    {
        RestClient _client;
        public ContentService(string accessToken)
        {
            RestClientOptions options = new RestClientOptions();
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(accessToken, "Bearer");
            _client = new RestClient(options);

        }

        public async Task<RestResponse<string>> Create(string envKey, ContentModel  data)
        {
            var request = new RestRequest($"https://api.rytr.me/v1/ryte", Method.Post);
            request.AddJsonBody(data);
            request.AddHeader("Content-Type", "application/json");

            return await _client.ExecuteAsync<string>(request);

        }
    }
}
