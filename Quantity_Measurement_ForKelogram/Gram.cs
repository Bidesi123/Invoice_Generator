using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement_ForKelogram
{
   public class Gram
    {
        public double gram;
        public Gram(double gram)
        {
            this.gram = gram;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        public bool ConvertedGramalue(Gram gram)
        {
            if (this.gram.Equals(gram.gram))
                return true;
            return false;
        }
    }
}
