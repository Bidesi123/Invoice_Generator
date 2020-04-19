using System;
using System.Collections.Generic;
using System.Text;
using QuantityRepository.LengthRepository;
using QuantityMeasurementModel.LengthModel;

namespace QuantityManager.LengthManager
{
   public class ImpFeetToInchesManager : IFeetToInchManager
    {
        private readonly IFeetsToInches feetsToInches;
        public ImpFeetToInchesManager(IFeetsToInches feetsToInches)
        {
            this.feetsToInches = feetsToInches;
        }

        public double FeetToInches(Feets feet)
        {
            return this.feetsToInches.FeetToInches(feet);
        }
    }
}
