using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityManager.WeightManager;
using QuantityMeasurementModel.WeightModel;


namespace QuantityMeasurement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        public readonly IKelogramToGramManager kelogramToGramManager;
        public readonly IGramToKelogramManager gramToKelogramManager;

        public WeightController(IKelogramToGramManager kelogramToGramManager)
        {
            this.kelogramToGramManager = kelogramToGramManager;
        }

        public WeightController(IGramToKelogramManager gramToKelogramManager)
        {
            this.gramToKelogramManager = gramToKelogramManager;
        }

        [Route("KelogramToGram")]
        [HttpPost]
        public IActionResult KelogramToGram(Kelograms kelograms)
        {
            var result = this.kelogramToGramManager.KelogramToGram(kelograms);
            if (result >= 0)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        [Route("GramToKelogram")]
        [HttpPost]
        public IActionResult GramToKelogram(Grams grams)
        {
            var result = this.gramToKelogramManager.GramToKelogram(grams);
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