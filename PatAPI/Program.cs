using PatAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

ServiceConfiguration.Configure(builder.Services);

// configure swagger doc


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();