using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.TemperatureRepository
{
    /// <summary>
    /// Temperature repository interface
    /// </summary>
   public interface ITemperatureRepository
    {
        /// <summary>
        /// abstract method of conversion from Celcius to Fahrenite
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        double CelciusToFahrenheit(double celcius);
        /// <summary>
        /// abstract method of conversion from Fahrenite to Celcius
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        double FahrenheitToCelcius(double fahrenheit);
    }
}
