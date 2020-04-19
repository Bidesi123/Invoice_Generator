using QuantityMeasurementModel.LengthModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityRepository.LengthRepository
{
    public class ImpInchesToFeet : IInchestoFeet
    {
        public decimal InchesToFeet(Inches inch)
        {
            return inch.Inch/12;
        }
    }
}
