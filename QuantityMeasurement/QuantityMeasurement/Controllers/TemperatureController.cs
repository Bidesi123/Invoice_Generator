using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementModel.TemperatureModel;
using QuantityManager.TemperatureManager;

namespace QuantityMeasurement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        public readonly ICelciusToFahreniteManager celciusToFahreniteManager;
        public readonly IFahreniteToCelciusManager fahreniteToCelciusManager;
        public TemperatureController(ICelciusToFahreniteManager celciusToFahreniteManager)
        {
            this.celciusToFahreniteManager = celciusToFahreniteManager;
        }
        public TemperatureController(IFahreniteToCelciusManager fahreniteToCelciusManager)
        {
            this.fahreniteToCelciusManager = fahreniteToCelciusManager;
        }

        [Route("CelciusToFahrenite")]
        [HttpPost]
        public IActionResult CelciusToFahrenite(Celcius celcius)
        {
            var result = this.celciusToFahreniteManager.CelciusToFahrenite(celcius);
            if(result>=0)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("FahreniteToCelcius")]
        [HttpPost]
        public IActionResult FahreniteToCelcius(Fahrenite fahrenite)
        {
            var result = this.fahreniteToCelciusManager.FahreniteToCelcius(fahrenite);
            if (result >= 0)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
}