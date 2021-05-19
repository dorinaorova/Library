using LibraryBLL;
using LibraryDAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace LibraryAPI {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers();
            services.AddDbContext<KonyvtarContext>(o => o.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<ILibraryService, LibraryService>();
            services.AddControllers().AddJsonOptions(o => { o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;});
            services.AddAutoMapper(typeof(LibraryProfile));
            services.AddOpenApiDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
