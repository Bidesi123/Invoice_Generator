using QuantityMeasurementModel.TemperatureModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace QuantityRepository.TemperatureRepository
{
    public class ImpCelciusToFahrenite : ICelciusToFahrenite
    {
        
        public double CelciusToFahrenite(Celcius celcius)
        {
            return 33.8 * celcius.Celciuss;
        }
    }
}
