using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement_ForKelogram
{
    /// <summary>
    /// class declARATION
    /// </summary>
   public class kelogramToGram
    {
        public double kelogram;
        public double gram;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="kelogram"></param>
        /// <param name="gram"></param>
        public kelogramToGram(Kelogram kelogram, Gram gram)
        {
            this.kelogram = kelogram.kelogram;
            this.gram = gram.gram;

        }
        /// <summary>
        /// method declaration
        /// </summary>
        /// <param name="kelogram"></param>
        /// <param name="gram"></param>
        /// <returns>bool type</returns>
        public bool ComparedKelogramAndGramValue(Kelogram kelogram, Gram gram)
        {
            if (this.kelogram == 0 && (this.kelogram.Equals(this.gram)))
                return true;
            if (this.kelogram == 1 && (this.kelogram.Equals(this.gram)))
                return false;
            if (this.gram == 1 && (this.kelogram.Equals(1000 * this.gram)))
                return true;
            return false;
        }
    }
}
