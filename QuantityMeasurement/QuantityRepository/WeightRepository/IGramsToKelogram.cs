using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;

namespace QuantityRepository.WeightRepository
{
   public interface IGramsToKelogram
    {
        decimal GramToKelogram(Grams gram);
    }
}
