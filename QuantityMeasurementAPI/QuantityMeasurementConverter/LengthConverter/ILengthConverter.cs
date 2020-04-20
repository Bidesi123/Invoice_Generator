using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementConverter.LengthConverter
{
   public interface ILengthConverter
    {
        double FeetToInche(double feet);
        double IncheToFeet(double inch);
    }
}
