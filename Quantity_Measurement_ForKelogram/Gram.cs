using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement_ForKelogram
{
    /// <summary>
    /// class declaration
    /// </summary>
   public class Gram
    {
        public double gram;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="gram"></param>
        public Gram(double gram)
        {
            this.gram = gram;
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
        /// <param name="gram"></param>
        /// <returns>bool type</returns>
        public bool ConvertedGramalue(Gram gram)
        {
            if (this.gram.Equals(gram.gram))
                return true;
            return false;
        }
    }
}
