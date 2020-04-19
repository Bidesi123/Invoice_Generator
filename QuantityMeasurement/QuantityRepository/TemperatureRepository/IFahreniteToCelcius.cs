using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.TemperatureModel;

namespace QuantityRepository.TemperatureRepository
{
   public interface IFahreniteToCelcius
    {
        double FahreniteToCelcius(Fahrenite fahrenite);
    }
}
