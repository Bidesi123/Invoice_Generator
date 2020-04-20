using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementConverter.TemperatureConverter
{
   public interface ITemperatureConverter
    {
        double CelciusToFahrenheit(double celcius);
        double FahrenheitToCelcius(double fahrenheit);
    }
}
