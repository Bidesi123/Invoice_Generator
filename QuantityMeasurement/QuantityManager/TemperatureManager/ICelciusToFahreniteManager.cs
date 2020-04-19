using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.TemperatureModel;

namespace QuantityManager.TemperatureManager
{
   public interface ICelciusToFahreniteManager
    {
        double CelciusToFahrenite(Celcius celcius);
    }
}
