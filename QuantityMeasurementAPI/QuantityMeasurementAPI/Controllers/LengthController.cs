using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementConverter.LengthConverter;

namespace QuantityMeasurementAPI.Controllers
{
    /// <summary>
    /// Length conroler class extends to ControllerBase
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        /// <summary>
        /// declaration of ILengthConverter
        /// </summary>
        private ILengthConverter length;
        /// <summary>
        /// public counstructor of class to initialize ILengthConverter 
        /// </summary>
        /// <param name="length"></param>
        public LengthController(ILengthConverter length)
        {
            this.length = length;
        }
        /// <summary>
        /// implementation of conversion from feet o inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>Task<IActionResult></returns>
        [Route("api/FeetToInche")]
        [HttpGet]
        public async Task<IActionResult> GetInch(double feet)
        {
            var result = length.FeetToInche(feet);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
        /// <summary>
        /// implementation of conversion from inch o feet
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>Task<IActionResult></returns>
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