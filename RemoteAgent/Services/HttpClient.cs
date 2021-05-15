using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RemoteAgent.Services
{
    public class HttpClient : IHttpClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private System.Net.Http.HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpClient(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpClient = new System.Net.Http.HttpClient();
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task<System.Net.Http.HttpClient> GetClient()
        {
            //var accessToken = await _httpContextAccessor
            //    .HttpContext
            //    .GetTokenAsync(OpenIdConnectParameterNames.AccessToken);

            string accessToken = "";

            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                _httpClient.SetBearerToken(accessToken);
            }

            _httpClient.BaseAddress = new Uri(_configuration["ApiResourceBaseUrls:Api"]);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return _httpClient;
        }
    }
}
