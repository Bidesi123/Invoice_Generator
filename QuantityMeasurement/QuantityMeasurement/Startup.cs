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
using QuantityMeasurementModel;
using QuantityManager.LengthManager;
using QuantityManager.TemperatureManager;
using QuantityManager.WeightManager;
using QuantityRepository.LengthRepository;
using QuantityRepository.TemperatureRepository;
using QuantityRepository.WeightRepository;
using Swashbuckle.AspNetCore.Swagger;

namespace QuantityMeasurement
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
            services.AddTransient<IFeetToInchManager, ImpFeetToInchesManager>();
            services.AddTransient<IInchesToFeetManager, ImpInchesToFeetManager>();
            services.AddTransient<ICelciusToFahreniteManager, ImpCelciusToFahreniteManager>();
            services.AddTransient<IFahreniteToCelciusManager, ImpFahreniteToCelciusManager>();
            services.AddTransient<IKelogramToGramManager, ImpKelogramToGramManager>();
            services.AddTransient<IGramToKelogramManager, ImpGramToKelogramManager>();
            services.AddTransient<IFeetsToInches, ImpFeetsToInches>();
            services.AddTransient<IInchestoFeet, ImpInchesToFeet>();
            services.AddTransient<ICelciusToFahrenite, ImpCelciusToFahrenite>();
            services.AddTransient<IFahreniteToCelcius, ImpFahreniteToCelcius>();
            services.AddTransient<IKelogramsToGrams, ImpKelogramsToGrams>();
            services.AddTransient<IGramsToKelogram, ImpGramsToKelogram>();
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
                    //c.RoutePrefix = string.Empty;
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ValuesController}/{action=FeettoInch}/{id?}"
                    );
            });
        }
    }
}
