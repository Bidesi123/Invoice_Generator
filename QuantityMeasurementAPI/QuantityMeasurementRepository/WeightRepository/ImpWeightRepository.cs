using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.WeightRepository
{
    /// <summary>
    /// implementation class of IWeightRepository
    /// </summary>
    public class ImpWeightRepository : IWeightRepository
    {
        /// <summary>
        /// implementaion of GmToKg
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>double</returns>
        public double GmToKg(double gm)
        {
            return gm / 1000;
        }
        /// <summary>
        /// implementaion of KgToGm
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>double</returns>
        public double KgToGm(double kg)
        {
            return kg * 1000;
        }
    }
}
