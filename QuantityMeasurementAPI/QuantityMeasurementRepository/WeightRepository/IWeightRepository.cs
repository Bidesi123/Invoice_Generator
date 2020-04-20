using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.WeightRepository
{
   public interface IWeightRepository
    {
        double GmToKg(double gm);
        double KgToGm(double kg);
    }
}
