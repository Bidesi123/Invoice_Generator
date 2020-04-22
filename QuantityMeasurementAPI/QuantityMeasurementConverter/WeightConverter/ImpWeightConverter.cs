using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementRepository.WeightRepository;

namespace QuantityMeasurementConverter.WeightConverter
{
    /// <summary>
    /// implementation class of IWeightConverter
    /// </summary>
    public class ImpWeightConverter : IWeightConverter
    {
        /// <summary>
        /// declaration of IWeightRepository
        /// </summary>
        private readonly IWeightRepository weight;
        /// <summary>
        /// public constructor of class to initialize IWeightRepository
        /// </summary>
        /// <param name="weight"></param>
        public ImpWeightConverter(IWeightRepository weight)
        {
            this.weight = weight;
        }
        /// <summary>
        /// implemementation of GmToKg
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>double</returns>
        public double GmToKg(double gm)
        {
           return weight.GmToKg(gm);
        }
        /// <summary>
        /// implemementation of KgToGm
        /// </summary>
        /// <param name="gm"></param>
        /// <returns>double</returns>
        public double KgToGm(double kg)
        {
            return weight.KgToGm(kg);
        }
    }
}
