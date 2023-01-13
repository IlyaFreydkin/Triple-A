using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using TripleAProject.Application.Dto;
using TripleAProject.Webapi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddControllers();
builder.Services.AddDbContext<AAAContext>(opt =>
{
    opt.UseMySql(
        builder.Configuration.GetConnectionString("MySql"),
        new MariaDbServerVersion(new Version(10, 4, 22)));
});


if (builder.Environment.IsDevelopment())
{
    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(
            builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
    });
}


// JWT Authentication ******************************************************************************


byte[] secret = Convert.FromBase64String(builder.Configuration["Secret"]);
builder.Services
    .AddAuthentication(options => options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secret),
            ValidateAudience = false,
            ValidateIssuer = false
        };
    });
// *************************************************************************************************


var app = builder.Build();
app.UseHttpsRedirection();
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
        using (var db = scope.ServiceProvider.GetRequiredService<AAAContext>())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
        db.Seed();
    }
    app.UseCors();
}
app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();
//app.UseRouting();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");
app.Run();