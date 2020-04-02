using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementForTemperature
{
   public class CelciusToFahrenite
    {
        public double celcius;
        public double fahrenite;
        public CelciusToFahrenite(Celcius celcius, Fahrenite fahrenite)
        {
            this.celcius = celcius.celcius;
            this.fahrenite = fahrenite.fahrenite;

        }
        public bool ComparedCelciusAndFahreniteValue(Celcius celcius, Fahrenite fahrenite)
        {
            if (this.celcius == 1 && (this.celcius.Equals(this.fahrenite)))
                return false;           
            if (this.fahrenite == 1 && (this.celcius.Equals(33.8 * this.fahrenite)))
                return true;
            return false;
        }
    }
}
