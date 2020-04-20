using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QuantityMeasurementConverter.LengthConverter;
using QuantityMeasurementConverter.TemperatureConverter;
using QuantityMeasurementRepository.LengthRepository;
using QuantityMeasurementRepository.TemperatureRepository;
using QuantityMeasurementConverter.WeightConverter;
using QuantityMeasurementRepository.WeightRepository;
using Swashbuckle.AspNetCore.Swagger;

namespace QuantityMeasurementAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<ILengthConverter, ImpLengthConverter>();
            services.AddTransient<ILengthRepository, ImpLengthRepository>();
            services.AddTransient<ITemperatureConverter, ImpTemperatureConverter>();
            services.AddTransient<ITemperatureRepository, ImpTemperatureRepository>();
            services.AddTransient<IWeightConverter, ImpWeightConverter>();
            services.AddTransient<IWeightRepository, ImpWeightRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "QuantityMeasurement", Version = "v1" });
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
