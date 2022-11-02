using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using se_api.Context;
using se_api.Context.Config;
using se_api.DAL;
using se_api.DAL.Repositories.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var Origens = "_seapi";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Origens,
            policy =>
            {
                policy.WithOrigins("*");
            }
        );
});
//builder.Services.AddAuthentication();
//builder.Services.AddAuthorization();
//builder.Services.AddControllersWithViews();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var key = Encoding.ASCII.GetBytes(Setting.Secret);
builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Services.AddScoped<SEContext, SEContext>();
builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();


// Add services to the container.

var app = builder.Build();

//app.UseHttpsRedirection();
//app.UseStaticFiles();
app.UseRouting();

app.UseCors(Origens);

app.UseAuthentication();
app.UseAuthorization();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});
app.MapControllers();
// Configure the HTTP request pipeline.

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//       new WeatherForecast
//       (
//           DateTime.Now.AddDays(index),
//           Random.Shared.Next(-20, 55),
//           summaries[Random.Shared.Next(summaries.Length)]
//       ))
//        .ToArray();
//    return forecast;
//});

app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}


void ConfigureService(IServiceCollection services)
{
    services.AddControllersWithViews();
}