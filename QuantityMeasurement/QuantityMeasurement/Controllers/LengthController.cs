using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementModel.LengthModel;
using QuantityManager.LengthManager;

namespace QuantityMeasurement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        public readonly IFeetToInchManager feetToInchManager;
        public readonly IInchesToFeetManager inchesToFeetManager;

        public LengthController(IFeetToInchManager feetToInchManager)
        {
            this.feetToInchManager = feetToInchManager;
        }
        public LengthController(IInchesToFeetManager inchesToFeetManager)
        {
            this.inchesToFeetManager= inchesToFeetManager;
        }
        [Route("FeetToInches")]
        [HttpPost]
        public IActionResult FeetToInches(Feets feet)
        {
           var result=  this.feetToInchManager.FeetToInches(feet);
            if (result >= 0)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }

        }

        [Route("InchesToFeet")]
        [HttpPost]
        public IActionResult InchesToFeet(Inches inch)
        {
            var result = this.inchesToFeetManager.InchesToFeet(inch);
            if (result >= 0)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

    }
}