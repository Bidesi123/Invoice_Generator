using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementRepository.WeightRepository;

namespace QuantityMeasurementConverter.WeightConverter
{
   public class ImpWeightConverter : IWeightConverter
    {
        private readonly IWeightRepository weight;
        public ImpWeightConverter(IWeightRepository weight)
        {
            this.weight = weight;
        }

        public double GmToKg(double gm)
        {
           return weight.GmToKg(gm);
        }

        public double KgToGm(double kg)
        {
            return weight.KgToGm(kg);
        }
    }
}
