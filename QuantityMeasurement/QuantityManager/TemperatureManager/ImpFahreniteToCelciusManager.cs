using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.TemperatureModel;
using QuantityRepository.TemperatureRepository;

namespace QuantityManager.TemperatureManager
{
    public class ImpFahreniteToCelciusManager : IFahreniteToCelciusManager
    {
        private readonly IFahreniteToCelcius fahreniteTocelcius;
        public ImpFahreniteToCelciusManager(IFahreniteToCelcius fahreniteTocelcius)
        {
            this.fahreniteTocelcius = fahreniteTocelcius;
        }

        public double FahreniteToCelcius(Fahrenite fahrenite)
        {
            return this.fahreniteTocelcius.FahreniteToCelcius(fahrenite);
        }
    }
}
