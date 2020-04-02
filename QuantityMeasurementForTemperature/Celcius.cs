using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementForTemperature
{
   public class Celcius
    {
        public double celcius;
        public Celcius(double celcius)
        {
            this.celcius = celcius;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || (!this.GetType().Equals(obj.GetType())))
                return false;
            return true;
        }
        public bool ConvertedCelciusValue(Celcius celcius)
        {
            if (this.celcius.Equals(celcius.celcius))
                return true;
            return false;
        }
    }
}
