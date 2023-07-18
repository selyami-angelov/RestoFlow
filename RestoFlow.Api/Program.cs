using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using RestoFlow.Api.Extensions;
using RestoFlow.Api.Middlewares;
using RestoFlow.Infrastructure.Data;
using RestoFlow.Infrastructure.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
builder.Services.AddDbContext<RestoFlowDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;

})
    .AddEntityFrameworkStores<RestoFlowDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddServices();
builder.Services.ConfigureServices();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowLocalhost3000");
}

app.UseHttpsRedirection();

app.UseJwtMiddleware();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
