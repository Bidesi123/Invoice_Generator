using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public class Yard
    {
        public double yard;
        public Yard(double yard)
        {
            this.yard = yard;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        public bool ConvertedYardValue(Yard yard)
        {
            if (this.yard.Equals(yard.yard))
                return true;
            return false;
        }
    }
}
