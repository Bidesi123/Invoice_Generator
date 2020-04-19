using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.LengthModel;
using QuantityRepository.LengthRepository;

namespace QuantityManager.LengthManager
{
   public interface IFeetToInchManager
    {
        double FeetToInches(Feets feet);
    }
}
