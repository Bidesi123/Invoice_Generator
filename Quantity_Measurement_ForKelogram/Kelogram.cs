using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement_ForKelogram
{
    /// <summary>
    /// class declaration
    /// </summary>
   public class Kelogram
    {
        public double kelogram;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="kelogram"></param>
        public Kelogram(double kelogram)
        {
            this.kelogram = kelogram;
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
        /// <param name="kelogram"></param>
        /// <returns>bool type</returns>
        public bool ConvertedKelogramValue(Kelogram kelogram)
        {
            if (this.kelogram.Equals(kelogram.kelogram))
                return true;
            return false;
        }
    }
}
