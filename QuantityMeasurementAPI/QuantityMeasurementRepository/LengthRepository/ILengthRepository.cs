using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.LengthRepository
{
   public interface ILengthRepository
    {
        double FeetToInche(double feet);
        double IncheToFeet(double inch);
    }
}
