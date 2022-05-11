using gameapplication.Daten;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sql;
using Microsoft.EntityFrameworkCore;
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
        //Neu
         services.AddDbContext<GameContext>(options =>
         options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
         services.AddMvc();
    }
 
    public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
    ILoggerFactory loggerFactory)
    {
        // Configure application
    }
}
}