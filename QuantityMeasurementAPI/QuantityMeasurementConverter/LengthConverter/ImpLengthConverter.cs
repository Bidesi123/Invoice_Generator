using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementRepository.LengthRepository;

namespace QuantityMeasurementConverter.LengthConverter
{
   public class ImpLengthConverter : ILengthConverter
    {
        private readonly ILengthRepository length;
        public ImpLengthConverter(ILengthRepository length)
        {
            this.length = length;
        }

        public double FeetToInche(double feet)
        {
            return length.FeetToInche(feet);
        }

        public double IncheToFeet(double inch)
        {
            return length.IncheToFeet(inch);
        }
    }
}
