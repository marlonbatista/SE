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
                policy.SetIsOriginAllowedToAllowWildcardSubdomains()
                      .AllowAnyHeader()
                      .AllowAnyMethod()
                      .WithOrigins("*")
                      .Build();
            }
        );
});

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
builder.Services.AddTransient<IAlunoRepositorio, AlunoRepositorio>();


// Add services to the container.

var app = builder.Build();

app.UseRouting();

app.UseCors(Origens);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();


void ConfigureService(IServiceCollection services)
{
    services.AddControllersWithViews();
}