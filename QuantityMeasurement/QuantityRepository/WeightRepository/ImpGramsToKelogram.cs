using QuantityMeasurementModel.WeightModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityRepository.WeightRepository
{
    public class ImpGramsToKelogram : IGramsToKelogram
    {
        
        public decimal GramToKelogram(Grams gram)
        {
            return gram.Gram/1000;
        }
    }
}
