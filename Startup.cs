namespace gameapplication.Models
{
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
 
    public IConfiguration Configuration { get; }
 
    public virtual void ConfigureServices(IServiceCollection services)
    { 
        // Configure services
        // Configure dependency injection
    }
 
    public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
    ILoggerFactory loggerFactory)
    {
        // Configure application
    }
}
}