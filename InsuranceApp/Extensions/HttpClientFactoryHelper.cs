using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace InsuranceApp.Extensions
{
    public static class HttpClientFactoryHelper
    {
        public static async Task<HttpClient> GetClientWithToken(this IHttpClientFactory clientFactory, HttpContext context)
        {
            var client = clientFactory.CreateClient();
            var accessToken = await context.GetTokenAsync("access_token");

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);

            return client;
        }
    }
}