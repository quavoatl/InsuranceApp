using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using InsuranceApp.Areas.Broker.ViewModels;
using InsuranceApp.Contracts;
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
    public class PolicyController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public PolicyController(IHttpClientFactory clientFactory)
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
        public async Task<IActionResult> Calculate()
        {
            CalculatePolicyViewModel vm = new CalculatePolicyViewModel();
            
            var coverClient = await _clientFactory.GetClientWithToken(HttpContext);

            var coverGetAllResponse = await coverClient.GetAsync(MicroservicesLinks.Covers.GetAll);
            var coverGetAllContent = await coverGetAllResponse.Content.ReadFromJsonAsync<List<CoverResponse>>();
            vm.Cover = coverGetAllContent.SingleOrDefault(x => x.Type.Equals("accidents"));
            
            //************************************************
            
            var limitClient = await _clientFactory.GetClientWithToken(HttpContext);

            var limitGetAllResponse = await limitClient.GetAsync(MicroservicesLinks.Limits.GetAll);
            var limitGetAllContent = await limitGetAllResponse.Content.ReadFromJsonAsync<List<LimitResponse>>();
            vm.Limits = limitGetAllContent;
            
            return View("Calculate", vm);
        }
    }
}