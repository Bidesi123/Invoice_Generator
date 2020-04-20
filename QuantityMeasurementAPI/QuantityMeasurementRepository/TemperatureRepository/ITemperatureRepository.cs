using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.TemperatureRepository
{
   public interface ITemperatureRepository
    {
        double CelciusToFahrenheit(double celcius);
        double FahrenheitToCelcius(double fahrenheit);
    }
}
