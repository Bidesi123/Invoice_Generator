using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// class declaration
    /// </summary>
   public class Yard
    {
        public double yard;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="yard"></param>
        public Yard(double yard)
        {
            this.yard = yard;
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
        /// <param name="yard"></param>
        /// <returns>bool type</returns>
        public bool ConvertedYardValue(Yard yard)
        {
            if (this.yard.Equals(yard.yard))
                return true;
            return false;
        }
    }
}
