using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.TemperatureRepository
{
    /// <summary>
    /// implementation class of ITemperatureRepository
    /// </summary>
    public class ImpTemperatureRepository : ITemperatureRepository
    {
        /// <summary>
        /// implementation method of CelciusToFahrenheit
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        public double CelciusToFahrenheit(double celcius)
        {
            return celcius * 33.8;
        }
        /// <summary>
        /// implementation method of FahrenheitToCelcius
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        public double FahrenheitToCelcius(double fahrenhite)
        {
            return ((fahrenhite - 32) * 5 / 9);
        }
    }
}
