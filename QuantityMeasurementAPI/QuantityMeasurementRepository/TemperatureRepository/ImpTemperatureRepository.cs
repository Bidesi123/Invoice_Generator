using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.TemperatureRepository
{
   public class ImpTemperatureRepository : ITemperatureRepository
    {
        public double CelciusToFahrenheit(double celcius)
        {
            return celcius * 33.8;
        }
        public double FahrenheitToCelcius(double fahrenhite)
        {
            return ((fahrenhite - 32) * 5 / 9);
        }
    }
}
