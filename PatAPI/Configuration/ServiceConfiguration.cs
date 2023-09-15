using Infrastructure.Constants;
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
            services.AddSwaggerGen();
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