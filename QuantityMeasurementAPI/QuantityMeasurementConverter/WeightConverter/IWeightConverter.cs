using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementConverter.WeightConverter
{
   public interface IWeightConverter
    {
        double GmToKg(double gm);
        double KgToGm(double kg);
    }
}
