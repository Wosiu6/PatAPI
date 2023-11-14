using Infrastructure.Constants;
using Microsoft.OpenApi.Models;
using PatAPI.Handlers;
using PatAPI.Services;

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
        services.AddSwaggerGen(x =>
        {
            x.AddSecurityDefinition("SteamApiKey", new OpenApiSecurityScheme
            {
                Description = "The Steam API Key to access the API",
                Type = SecuritySchemeType.ApiKey,
                Name = "x-api-key",
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

            x.AddSecurityRequirement(securityRequirement);
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
    }
}