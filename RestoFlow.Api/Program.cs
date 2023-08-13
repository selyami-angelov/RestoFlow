using Microsoft.EntityFrameworkCore;

using RestoFlow.Api.Extensions;
using RestoFlow.Api.Hubs;
using RestoFlow.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

bool isLocalHost = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
var connectionString = isLocalHost
           ? Environment.GetEnvironmentVariable("CONNECTION_STRING")
           : builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.ConfigureServices(connectionString);

var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.UseCors("AllowOrigins");
app.UseHttpsRedirection();
app.UseJwtMiddleware();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<OrderHub>("/orderHub");
    endpoints.MapControllers();
});

app.Run();
