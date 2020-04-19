using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;

namespace QuantityRepository.WeightRepository
{
    public class ImpKelogramsToGrams : IKelogramsToGrams
    {
        public decimal KelogramToGram(Kelograms kelogram)
        {
            return kelogram.Kelogram*1000;
        }
    }
}
