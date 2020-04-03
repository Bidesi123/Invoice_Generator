using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Feet class
    /// </summary>
   public class Feet
    {
        public double feet;
        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="feet"></param>
        public Feet(double feet)
        {
            this.feet = feet;
        }
        /// <summary>
        /// equal override method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool type</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        /// <summary>
        /// conversion method
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>boo; type</returns>
        public bool ConvertedFeetValue(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            return false;
        }
    }
}
