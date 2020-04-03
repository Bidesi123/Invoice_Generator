using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementForTemperature
{
    /// <summary>
    /// class declaration
    /// </summary>
   public class Celcius
    {
        public double celcius;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="celcius"></param>
        public Celcius(double celcius)
        {
            this.celcius = celcius;
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
        /// nethod implementation
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>bool type</returns>
        public bool ConvertedCelciusValue(Celcius celcius)
        {
            if (this.celcius.Equals(celcius.celcius))
                return true;
            return false;
        }
    }
}
