using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementConverter.TemperatureConverter;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        private ITemperatureConverter temp;
        public TempController(ITemperatureConverter temp)
        {
            this.temp = temp;
        }
        [Route("api/CelciusToFahrenheit")]
        [HttpGet]
        public async Task<IActionResult> GetFahrenheit(double celcious)
        {
            var result = temp.CelciusToFahrenheit(celcious);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/FahrenheitToCelcius")]
        [HttpGet]
        public async Task<IActionResult> GetCelcius(double fahrenheit)
        {
            var result = temp.FahrenheitToCelcius(fahrenheit);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}