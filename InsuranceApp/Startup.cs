using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using InsuranceApp.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace InsuranceApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient(); 
            services.AddAuthentication(config =>
                {
                    config.DefaultScheme = "Cookies";
                    config.DefaultChallengeScheme = "oidc";
                })
                .AddCookie("Cookies")
                .AddOpenIdConnect("oidc", config =>
                {
                    config.Authority = "https://localhost:5005";
                    config.ClientId = "InsuranceApp";
                    config.ClientSecret = "secret";
                    config.SaveTokens = true;
                    config.ResponseType = "code";

                    config.GetClaimsFromUserInfoEndpoint = true;

                    config.Scope.Add(ClaimsHelpers.ROLES_KEY);
                    config.Scope.Add("broker_limits_rest_api");
                    config.Scope.Add("broker_covers_rest_api");
                    config.ClaimActions.MapUniqueJsonKey(ClaimsHelpers.ROLE,
                        ClaimsHelpers.ROLE,
                        ClaimsHelpers.ROLE);
                    config.TokenValidationParameters.RoleClaimType = ClaimsHelpers.ROLE;
                });

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}