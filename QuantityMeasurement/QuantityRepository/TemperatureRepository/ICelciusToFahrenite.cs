using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.TemperatureModel;

namespace QuantityRepository.TemperatureRepository
{
   public interface ICelciusToFahrenite
    {
        double CelciusToFahrenite(Celcius celcius);
    }
}
