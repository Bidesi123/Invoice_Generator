using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementRepository.TemperatureRepository;

namespace QuantityMeasurementConverter.TemperatureConverter
{
    /// <summary>
    /// implementation class of ITemperatureConverter
    /// </summary>
    public class ImpTemperatureConverter : ITemperatureConverter
    {
        /// <summary>
        /// declaration of ITemperatureRepository interface type
        /// </summary>
        private readonly ITemperatureRepository temp;
        /// <summary>
        /// public constructor of class to initialize of ITemperatureRepository
        /// </summary>
        /// <param name="temp"></param>
        public ImpTemperatureConverter(ITemperatureRepository temp)
        {
            this.temp = temp;
        }
        /// <summary>
        /// implementation of CelciusToFahrenheit
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        public double CelciusToFahrenheit(double celcius)
        {
            return temp.CelciusToFahrenheit(celcius);
        }
        /// <summary>
        /// implementation of FahrenheitToCelcius
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>double</returns>
        public double FahrenheitToCelcius(double fahrenheit)
        {
           return temp.FahrenheitToCelcius(fahrenheit);
        }
    }
}
