using Microsoft.OpenApi.Models;
using PatAPI.Handlers;
using PatAPI.Infrastructure.Constants;
using PatAPI.Services;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PatAPI.Configuration
{
    public static class ServiceConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            ConfigureClients(services);

            services.AddSingleton<IHowLongToBeatService, HowLongToBeatService>();
            services.AddScoped<CachedHowLongToBeatHandler>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(sgo =>
            {
                ConfigureSteamApiKey(sgo);                                      /* Steam web API key auth documentation - https://partner.steamgames.com/doc/webapi_overview/auth */
                ConfigureFacebookAccessToken(sgo);
                /* Facebook Access Token doc - https://developers.facebook.com/docs/messenger-platform/reference/send-api/#send-api-reference */
            });
        }

        private static void ConfigureClients(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddHttpClient(HowLongToBeatConstants.ClientName, client =>
            {
                client.BaseAddress = HowLongToBeatConstants.BaseUrl;

                client.DefaultRequestHeaders.Add("origin", client.BaseAddress.AbsoluteUri);
                client.DefaultRequestHeaders.Add("referer", client.BaseAddress.AbsoluteUri);
                client.DefaultRequestHeaders.Add("user-agent", HowLongToBeatConstants.UserAgent);
            }).AddHttpMessageHandler<CachedHowLongToBeatHandler>();
        }

        private static void ConfigureSteamApiKey(SwaggerGenOptions sgo)
        {
            sgo.AddSecurityDefinition("SteamApiKey", new OpenApiSecurityScheme
            {
                Description = "The Steam API Key to access the API",
                Type = SecuritySchemeType.ApiKey,
                Name = "x-webapi-key",
                In = ParameterLocation.Header,
                Scheme = "ApiKeyScheme"
            });

            OpenApiSecurityScheme scheme = new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "SteamApiKey"
                },
                In = ParameterLocation.Header,
            };

            OpenApiSecurityRequirement securityRequirement = new OpenApiSecurityRequirement
                {
                    {scheme, new List<string>() }
                };

            sgo.AddSecurityRequirement(securityRequirement);
        }

        private static void ConfigureFacebookAccessToken(SwaggerGenOptions sgo)
        {
            sgo.AddSecurityDefinition("FacebookPageAccessToken", new OpenApiSecurityScheme
            {
                Description = "The Facebook Page Access Token",
                Type = SecuritySchemeType.OAuth2,
                Name = "access_token",
                In = ParameterLocation.Query,
                Scheme = "FacebookAccessToken"
            });

            OpenApiSecurityScheme scheme = new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "FacebookAccessToken"
                },
                In = ParameterLocation.Query,
            };

            OpenApiSecurityRequirement securityRequirement = new OpenApiSecurityRequirement
                {
                    {scheme, new List<string>() }
                };

            sgo.AddSecurityRequirement(securityRequirement);
        }
    }
}