using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public class FeetToInches
    {
        public double feet;
        public double inch;
        public FeetToInches(Feet feet,Inches inch)
        {
            feet.feet = this.feet;
            inch.inches = this.inch;
        }

        public bool ComparedFeetAndinchesValue(Feet feet,Inches inch)
        {
            if (feet.feet == 0 && feet.feet == inch.inches)
                return true;
            if (feet.feet == 1 && feet.feet == inch.inches)
                return false;
            if (feet.feet == 1 && inch.inches == 12)
                return true;
            return false;
        }
    }
}
