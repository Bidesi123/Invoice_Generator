using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementForTemperature
{
    /// <summary>
    /// class declaration
    /// </summary>
   public class Fahrenite
    {
        public double fahrenite;
        /// <summary>
        /// comstructor
        /// </summary>
        /// <param name="fahrenite"></param>
        public Fahrenite(double fahrenite)
        {
            this.fahrenite = fahrenite;
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
        /// method implementation
        /// </summary>
        /// <param name="fahrenite"></param>
        /// <returns>bool type</returns>
        public bool ConvertedFahreniteValue(Fahrenite fahrenite)
        {
            if (this.fahrenite.Equals(fahrenite.fahrenite))
                return true;
            return false;
        }
    }
}
