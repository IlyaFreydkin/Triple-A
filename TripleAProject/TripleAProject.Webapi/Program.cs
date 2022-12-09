using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TripleAProject.Webapi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
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
var app = builder.Build();
app.UseHttpsRedirection();
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
        using (var db = scope.ServiceProvider.GetRequiredService<AAAContext>())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
    }
    app.UseCors();
}
app.MapControllers();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");
app.Run();