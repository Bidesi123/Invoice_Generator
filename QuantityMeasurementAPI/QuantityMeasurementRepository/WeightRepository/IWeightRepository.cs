using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.WeightRepository
{
    /// <summary>
    /// Weight repository intrerface
    /// </summary>
   public interface IWeightRepository
    {
        /// <summary>
        /// abstraction method of conversion from Gram to kelogram
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>doubl</returns>
        double GmToKg(double gm);
        /// <summary>
        /// abstraction method of conversion from kelogram to gram
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>doubl</returns>
        double KgToGm(double kg);
    }
}
