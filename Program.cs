using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.AspNetCore;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using gameapplication.Daten;
var host =  new HostBuilder()
      .Build(); 

using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
    var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Start App");

        }
        catch(Exception ex)
        {

        }
    }
var builder = WebApplication.CreateBuilder(args);
//Logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddControllersWithViews();
builder.WebHost.UseWebRoot(
Path.Combine(Directory.GetCurrentDirectory(), 
"wwwroot"));
using var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


 using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<GameContext>();
            DbInitializer.Initialize(context);
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Database was seeded");
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred while seeding the database.");
        }
    }
app.Run();
