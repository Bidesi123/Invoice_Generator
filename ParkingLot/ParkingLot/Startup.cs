using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VehicleRepository;
using VehicleRepository.Driver;
using VehicleManager.Driver;
using Swashbuckle.AspNetCore.Swagger;
using VehicleRepository.Owner;
using VehicleManager.Owner;
using VehicleRepository.Police;
using VehicleManager.Police;
using VehicleRepository.Security;
using VehicleManager.Security;

namespace ParkingLot
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
            services.AddDbContext<VehicleDBContext>(option => option.UseSqlServer(Configuration.GetConnectionString("UserDbConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IDriverRepository, ImpDriverRepository>();
            services.AddTransient<IDriverManager, ImpDriverManager>();
            services.AddTransient<IOwnerRepository, ImpOwnerRepository>();
            services.AddTransient<IOwnerManager, ImpOwnerManager>();
            services.AddTransient<IPoliceRepository, ImpPoliceRepository>();
            services.AddTransient<IPoliceManager, ImpPoliceManager>();
            services.AddTransient<ISecurityRepository, ImpSecurityRepository>();
            services.AddTransient<ISecurityManager, ImpSecurityManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "ParkingLot", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI V1");
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
