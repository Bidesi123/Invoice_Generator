using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.TemperatureModel;

namespace QuantityManager.TemperatureManager
{
   public interface IFahreniteToCelciusManager
    {
        double FahreniteToCelcius(Fahrenite fahrenite);
    }
}
