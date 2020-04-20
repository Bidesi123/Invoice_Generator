using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.LengthRepository
{
   public class ImpLengthRepository : ILengthRepository
    {
        public double FeetToInche(double feet)
        {
            return feet * 12;
        }

        public double IncheToFeet(double inch)
        {
            return inch / 12;
        }
    }
}
