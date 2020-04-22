using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementConverter.WeightConverter
{
    /// <summary>
    /// interface of weight converter
    /// </summary>
   public interface IWeightConverter
    {
        /// <summary>
        /// abstract method of conversion from gram to kelogram
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>double</returns>
        double GmToKg(double gm);
        /// <summary>
        /// abstract method of conversion from kelogram to gram
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>double</returns>
        double KgToGm(double kg);
    }
}
