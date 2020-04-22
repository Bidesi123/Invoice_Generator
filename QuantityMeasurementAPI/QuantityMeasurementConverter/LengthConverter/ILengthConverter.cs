using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementConverter.LengthConverter
{
    /// <summary>
    /// converter interface of length
    /// </summary>
   public interface ILengthConverter
    {
        /// <summary>
        /// abstract method of conversion from Feet to inches
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        double FeetToInche(double feet);
        /// <summary>
        /// abstract method of conversion from inch to feet
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        double IncheToFeet(double inch);
    }
}
