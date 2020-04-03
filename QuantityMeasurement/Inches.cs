using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// class declaratioon
    /// </summary>
   public class Inches
    {
        public double inches;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="inches"></param>
        public Inches(double inches)
        {
            this.inches = inches;
        }
        /// <summary>
        /// override method
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
        /// method declaration
        /// </summary>
        /// <param name="inches"></param>
        /// <returns>bool type</returns>
        public bool ConvertedInchesValue(Inches inches)
        {
            if (this.inches.Equals(inches.inches))
                return true;
            return false;
        }
    }
}
