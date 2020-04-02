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
            this.feet = feet.feet;
            this.inch = inch.inches;
            
        }

        public bool ComparedFeetAndinchesValue(Feet feet,Inches inch)
        {
           /* this.feet = 12 * this.inch;*/
            if (this.feet == 0 && (this.feet.Equals(this.inch)))
                return true;
            if (this.feet == 1 && (this.feet.Equals(this.inch)))
                return false;
            if (this.inch == 1 && (this.feet.Equals(12*this.inch)))
                return true;
            return false;
        }
    }
}
