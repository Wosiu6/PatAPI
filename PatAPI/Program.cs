using Infrastructure.Constants;
using PatAPI.Clients;
using PatAPI.Handlers;
using PatAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

ConfigureServices(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void ConfigureServices(WebApplicationBuilder builder)
{
    ConfigureClients(builder);

    builder.Services.AddSingleton<IHowLongToBeatService, HowLongToBeatService>();

    builder.Services.AddScoped<CachedHowLongToBeatHandler>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

static void ConfigureClients(WebApplicationBuilder builder)
{
    builder.Services.AddMemoryCache();

    builder.Services.AddHttpClient(HowLongToBeatConstants.ClientName, client =>
    {
        client.BaseAddress = HowLongToBeatConstants.BaseUrl;

        client.DefaultRequestHeaders.Add("origin", HowLongToBeatConstants.BaseUrl.AbsoluteUri);
        client.DefaultRequestHeaders.Add("referer", HowLongToBeatConstants.BaseUrl.AbsoluteUri);
        client.DefaultRequestHeaders.Add("user-agent", HowLongToBeatConstants.UserAgent);
    }).AddHttpMessageHandler<CachedHowLongToBeatHandler>();
}