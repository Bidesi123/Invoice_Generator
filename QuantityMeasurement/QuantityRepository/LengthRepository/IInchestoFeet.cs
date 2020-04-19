using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.LengthModel;

namespace QuantityRepository.LengthRepository
{
   public interface IInchestoFeet
    {
        decimal InchesToFeet(Inches inch);
    }
}
