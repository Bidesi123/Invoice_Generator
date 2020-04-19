using QuantityMeasurementModel.TemperatureModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityRepository.TemperatureRepository
{
    public class ImpFahreniteToCelcius : IFahreniteToCelcius
    {
        public double FahreniteToCelcius(Fahrenite fahrenite)
        {
            return fahrenite.Fahrenitee / 33.8;
        }
    }
}
