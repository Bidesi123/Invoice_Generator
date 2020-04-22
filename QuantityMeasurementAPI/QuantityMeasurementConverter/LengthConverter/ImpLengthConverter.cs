using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementRepository.LengthRepository;

namespace QuantityMeasurementConverter.LengthConverter
{
    /// <summary>
    /// implementation class of ILengthConverter
    /// </summary>
    public class ImpLengthConverter : ILengthConverter
    {
        /// <summary>
        /// declaraton of length repository interface type
        /// </summary>
        private readonly ILengthRepository length;
        /// <summary>
        /// class type public constructor to initialize repository interface
        /// </summary>
        /// <param name="length"></param>
        public ImpLengthConverter(ILengthRepository length)
        {
            this.length = length;
        }
        /// <summary>
        /// implementation of FeetToInche
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        public double FeetToInche(double feet)
        {
            return length.FeetToInche(feet);
        }
        /// <summary>
        /// implementation of IncheToFeet
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double</returns>
        public double IncheToFeet(double inch)
        {
            return length.IncheToFeet(inch);
        }
    }
}
