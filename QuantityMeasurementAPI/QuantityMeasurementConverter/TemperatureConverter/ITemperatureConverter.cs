using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementConverter.TemperatureConverter
{
    /// <summary>
    /// converter interface of tenperature
    /// </summary>
   public interface ITemperatureConverter
    {
        /// <summary>
        /// abstarct method of conversion from Celcius to fahrenite
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        double CelciusToFahrenheit(double celcius);
        /// <summary>
        /// abstarct method of conversion from fahrenite to celcius
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        double FahrenheitToCelcius(double fahrenheit);
    }
}
