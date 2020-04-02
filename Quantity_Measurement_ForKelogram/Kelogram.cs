using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement_ForKelogram
{
   public class Kelogram
    {
        public double kelogram;
        public Kelogram(double kelogram)
        {
            this.kelogram = kelogram;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        public bool ConvertedKelogramValue(Kelogram kelogram)
        {
            if (this.kelogram.Equals(kelogram.kelogram))
                return true;
            return false;
        }
    }
}
