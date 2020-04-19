using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;

namespace QuantityRepository.WeightRepository
{
   public interface IKelogramsToGrams
    {
        decimal KelogramToGram(Kelograms kelogram);
    }
}
