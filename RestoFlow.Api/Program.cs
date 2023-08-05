using Microsoft.EntityFrameworkCore;

using RestoFlow.Api.Extensions;
using RestoFlow.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

bool isLocalHost = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
var connectionString = isLocalHost
           ? Environment.GetEnvironmentVariable("CONNECTION_STRING")
           : builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddServices();
builder.Services.ConfigureServices(connectionString);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowOrigins");
app.UseHttpsRedirection();
app.UseJwtMiddleware();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
