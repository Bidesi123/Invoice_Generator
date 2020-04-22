using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.LengthRepository
{
    /// <summary>
    /// implementation class of LengthRepository
    /// </summary>
    public class ImpLengthRepository : ILengthRepository
    {
        /// <summary>
        /// implementation of feet to inch conversion method
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        public double FeetToInche(double feet)
        {
            return feet * 12;
        }
        /// <summary>
        /// implementation of inch to feet conversion method
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        public double IncheToFeet(double inch)
        {
            return inch / 12;
        }
    }
}
