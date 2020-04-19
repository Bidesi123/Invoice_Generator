using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.LengthModel;

namespace QuantityRepository.LengthRepository
{
    public class ImpFeetsToInches : IFeetsToInches
    {
        /*public double ft;
        public ImpFeetsToInches(Feets feet)
        {
            this.ft = feet.Feet;
        }*/
        /* public ImpFeetsToInches(Feets feet)
         {
             this.ft = feet;
         }*/
        public double FeetToInches(Feets feet)
        {
           
            return feet.Feet * 12;
        }
    }
}
