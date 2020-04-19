using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.TemperatureModel;
using QuantityRepository.TemperatureRepository;

namespace QuantityManager.TemperatureManager
{
   public class ImpCelciusToFahreniteManager : ICelciusToFahreniteManager
    {
        readonly private ICelciusToFahrenite celciustoFahrebite;
        public ImpCelciusToFahreniteManager(ICelciusToFahrenite celciustoFahrebite)
        {
            this.celciustoFahrebite = celciustoFahrebite;
        }

        public double CelciusToFahrenite(Celcius celcius)
        {
            return this.celciustoFahrebite.CelciusToFahrenite(celcius);
        }
    }
}
