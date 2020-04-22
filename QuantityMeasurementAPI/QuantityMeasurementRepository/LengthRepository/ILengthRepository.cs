using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.LengthRepository
{
    /// <summary>
    /// ILength repository interface
    /// </summary>
   public interface ILengthRepository
    {
        /// <summary>
        ///abstract method of conversion from feet to inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        double FeetToInche(double feet);
        /// <summary>
        /// abstract method of conversion from inch to feet
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>double</returns>
        double IncheToFeet(double inch);
    }
}
