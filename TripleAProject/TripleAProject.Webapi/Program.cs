using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
var builder = WebApplication.CreateBuilder(args);

// Todo:
// Configure EF Core with
// .UseMySql(
//    builder.GetConnectionString("MySql"),
//    new MariaDbServerVersion(new Version(10, 4, 22)))

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
if (app.Environment.IsDevelopment())
{
    app.UseCors();
}
app.UseStaticFiles();
app.MapGet("/api/news", () => "News");
app.MapFallbackToFile("index.html");
app.Run();