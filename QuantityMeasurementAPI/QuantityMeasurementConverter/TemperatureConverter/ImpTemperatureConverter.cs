using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementRepository.TemperatureRepository;

namespace QuantityMeasurementConverter.TemperatureConverter
{
   public class ImpTemperatureConverter : ITemperatureConverter
    {
        private readonly ITemperatureRepository temp;
        public ImpTemperatureConverter(ITemperatureRepository temp)
        {
            this.temp = temp;
        }

        public double CelciusToFahrenheit(double celcius)
        {
            return temp.CelciusToFahrenheit(celcius);
        }

        public double FahrenheitToCelcius(double fahrenheit)
        {
           return temp.FahrenheitToCelcius(fahrenheit);
        }
    }
}
