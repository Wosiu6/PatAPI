using Infrastructure.Constants;
using PatAPI.Configuration;
using PatAPI.Handlers;
using PatAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

ServiceConfiguration.Configure(builder.Services);

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