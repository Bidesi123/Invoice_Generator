using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// class declaration
    /// </summary>
   public class FeetToInches
    {
        public double feet;
        public double inch;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inch"></param>
        public FeetToInches(Feet feet,Inches inch)
        {
            this.feet = feet.feet;
            this.inch = inch.inches;
            
        }
        /// <summary>
        /// method implementation
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inch"></param>
        /// <returns>bool type</returns>
        public bool ComparedFeetAndinchesValue(Feet feet,Inches inch)
        {          
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
