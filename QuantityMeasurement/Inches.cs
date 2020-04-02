using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public class Inches
    {
        public double inches;
        public Inches(double inches)
        {
            this.inches = inches;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        public bool ConvertedInchesValue(Inches inches)
        {
            if (this.inches.Equals(inches.inches))
                return true;
            return false;
        }
    }
}
