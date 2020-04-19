using System;
using System.Collections.Generic;
using System.Text;
using QuantityMeasurementModel.WeightModel;
using QuantityRepository.WeightRepository;

namespace QuantityManager.WeightManager
{
   public class ImpGramToKelogramManager : IGramToKelogramManager
    {
        private readonly IGramsToKelogram gramToKelogram;
        public ImpGramToKelogramManager(IGramsToKelogram gramToKelogram)
        {
            this.gramToKelogram = gramToKelogram;
        }

        public decimal GramToKelogram(Grams gram)
        {
            return this.gramToKelogram.GramToKelogram(gram);
        }
    }
}
