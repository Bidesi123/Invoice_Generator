using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;

namespace QuantityManager.WeightManager
{
   public interface IGramToKelogramManager
    {
        decimal GramToKelogram(Grams gram);
    }
}
