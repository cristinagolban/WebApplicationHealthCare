using ApApplication.Interfaces.Repositoryplication;
using AppliApplication.Interfaces.Repositorycation;
using Application;
using Application.Interfaces.Repositoryplication;
using Application.Interfaces.Service;
using Application.Service;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace APIPresentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(AssemblyMarker));
            services.AddDbContext<DatabaseContext>();

            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();

            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IPatientRepository, PatientRepository>();

            services.AddScoped<IAppointmentRepository, AppointmentRepository>();

            services.AddScoped<IWardService, WardService>();
            services.AddScoped<IWardRepository, WardRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(options => options.WithOrigins("https://localhost:44346")
                                                     .AllowAnyMethod()
                                                     .AllowAnyHeader()
                                                     .AllowAnyOrigin());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
