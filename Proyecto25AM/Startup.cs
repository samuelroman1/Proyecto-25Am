using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;
using Proyecto25AM.Services.Services;

namespace Proyecto25AM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;


        }

        public IConfiguration Configuration { get; }

        public void Configureservices(IServiceCollection Services)
        {
            // agregar coneciones
            //Add ConnectionDTB
            Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Add services to the container.

           Services.AddControllers();
           Services.AddEndpointsApiExplorer();
           Services.AddSwaggerGen();
            //Inyeccion de dependencias
            Services.AddTransient<IUsuarioServices, UsuarioServices>();
            Services.AddTransient<IClienteServices, ClienteServices>();
            Services.AddTransient<IDepartamentoServices, DepartamentoService>();
            Services.AddTransient<IEmpleadoServices, EmpleadoServices>();
            Services.AddTransient<IFacturaServices, FacturaServices>();
            Services.AddTransient<IPuestoServices, PuestoServices>();
            Services.AddTransient<IRolServices, RolServices>();
        }

        public  void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
