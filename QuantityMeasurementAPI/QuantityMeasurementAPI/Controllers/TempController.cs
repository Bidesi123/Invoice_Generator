using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementConverter.TemperatureConverter;

namespace QuantityMeasurementAPI.Controllers
{
    /// <summary>
    /// Temperature controler
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        /// <summary>
        /// declaration of ITemperatureConverter interface
        /// </summary>
        private ITemperatureConverter temp;
        /// <summary>
        /// public constructor of class to initialize ITemperatureConverter
        /// </summary>
        /// <param name="temp"></param>
        public TempController(ITemperatureConverter temp)
        {
            this.temp = temp;
        }
        /// <summary>
        /// conversion mthod from Celcius to fahrenite
        /// </summary>
        /// <param name="celcious"></param>
        /// <returns>Task<IActionResult></returns>
        [Route("api/CelciusToFahrenheit")]
        [HttpGet]
        public async Task<IActionResult> GetFahrenheit(double celcious)
        {
            var result = temp.CelciusToFahrenheit(celcious);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
        /// <summary>
        /// conversion method from Fahrenite to celcius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns>Task<IActionResult></returns>
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