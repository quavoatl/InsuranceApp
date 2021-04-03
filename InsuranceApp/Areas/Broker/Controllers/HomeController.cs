using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using InsuranceApp.Contracts.ResponseObjects;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InsuranceApp.Contracts.ResponseObjects;
using InsuranceApp.Extensions;
using Newtonsoft.Json;

namespace InsuranceApp.Areas.Controllers
{
    [Area("Broker")]
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Broker")]
        public async Task<IActionResult> ListLimits()
        {
            var client = await _clientFactory.GetClientWithToken(HttpContext);
            
            var getAllResponse = await client.GetAsync("https://localhost:5001/api/v1/limits");
            var getAllContent = await getAllResponse.Content.ReadFromJsonAsync<List<LimitResponse>>();

            return View("ListLimits", getAllContent);
        }
    }
}