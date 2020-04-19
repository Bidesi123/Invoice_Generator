using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;
using QuantityRepository.WeightRepository;

namespace QuantityManager.WeightManager
{
   public class ImpKelogramToGramManager : IKelogramToGramManager
    {
        private readonly IKelogramsToGrams kelogramToGram;
        public ImpKelogramToGramManager(IKelogramsToGrams kelogramToGram)
        {
            this.kelogramToGram = kelogramToGram;
        }

        public decimal KelogramToGram(Kelograms kelogram)
        {
            return this.kelogramToGram.KelogramToGram(kelogram);
        }
    }
}
