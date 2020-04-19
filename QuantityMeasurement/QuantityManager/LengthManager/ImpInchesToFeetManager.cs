using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.LengthModel;
using QuantityRepository.LengthRepository;

namespace QuantityManager.LengthManager
{
   public class ImpInchesToFeetManager : IInchesToFeetManager
    {
        private readonly IInchestoFeet inchesToFeet;
        public ImpInchesToFeetManager(IInchestoFeet inchesToFeet)
        {
            this.inchesToFeet = inchesToFeet;
        }
        public decimal InchesToFeet(Inches inch)
        {
            return this.inchesToFeet.InchesToFeet(inch);
        }
    }
}
