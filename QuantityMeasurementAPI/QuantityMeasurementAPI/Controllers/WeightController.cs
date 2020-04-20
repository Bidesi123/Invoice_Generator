using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementConverter.WeightConverter;


namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        private IWeightConverter weight;
        public WeightController(IWeightConverter weight)
        {
            this.weight = weight;
        }

        [Route("api/KgToGm")]
        [HttpGet]
        public async Task<IActionResult> GetFeet(double kg)
        {
            var result = weight.KgToGm(kg);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/GmToKg")]
        [HttpGet]
        public async Task<IActionResult> GetInch(double gm)
        {
            var result = weight.GmToKg(gm);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}