using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.LengthModel;

namespace QuantityManager.LengthManager
{
   public interface IInchesToFeetManager
    {
        decimal InchesToFeet(Inches inch);
    }
}
