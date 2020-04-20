using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementConverter.LengthConverter;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        private ILengthConverter length;
        public LengthController(ILengthConverter length)
        {
            this.length = length;
        }
        [Route("api/FeetToInche")]
        [HttpGet]
        public async Task<IActionResult> GetInch(double feet)
        {
            var result = length.FeetToInche(feet);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
        [Route("api/IncheToFeet")]
        [HttpGet]
        public async Task<IActionResult> GetFeet(double inch)
        {
            var result = length.IncheToFeet(inch);
            if (result != 0.0)
                return Ok(result);
            return this.BadRequest();
        }
    }
}