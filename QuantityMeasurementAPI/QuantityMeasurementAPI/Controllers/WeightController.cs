using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementConverter.WeightConverter;


namespace QuantityMeasurementAPI.Controllers
{
    /// <summary>
    /// WeightController class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        /// <summary>
        /// declasation of IWeightConverter interface
        /// </summary>
        private IWeightConverter weight;
        /// <summary>
        /// public constructor of class to initialize IWeightConverter
        /// </summary>
        /// <param name="weight"></param>
        public WeightController(IWeightConverter weight)
        {
            this.weight = weight;
        }
        /// <summary>
        /// conversion method from kelogram to gram
        /// </summary>
        /// <param name="kg"></param>
        /// <returns>Task<IActionResult></returns>
        [Route("api/KgToGm")]
        [HttpGet]
        public async Task<IActionResult> Getgram(double kg)
        {
            var result = weight.KgToGm(kg);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
        /// <summary>
        /// conversion method from gram to kelogram
        /// </summary>
        /// <param name="kg"></param>
        /// <returns>Task<IActionResult></returns>
        [Route("api/GmToKg")]
        [HttpGet]
        public async Task<IActionResult> Getkelogram(double gm)
        {
            var result = weight.GmToKg(gm);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}