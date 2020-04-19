using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;

namespace QuantityManager.WeightManager
{
   public interface IKelogramToGramManager
    {
        decimal KelogramToGram(Kelograms kelogram);
    }
}
