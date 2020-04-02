using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementForTemperature
{
   public class Fahrenite
    {
        public double fahrenite;
        public Fahrenite(double fahrenite)
        {
            this.fahrenite = fahrenite;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        public bool ConvertedFahreniteValue(Fahrenite fahrenite)
        {
            if (this.fahrenite.Equals(fahrenite.fahrenite))
                return true;
            return false;
        }
    }
}
