using Quantity_Measurement_ForKelogram;
using NUnit.Framework;
namespace Quantity_Measurement_Test
{
    public class KelogramToGramUnitTest
    {
        /// <summary>
        /// test case for kelogram
        /// </summary>
        [Test]
        public void Given0Kelogram_And0Kelogram_ShouldReturnEqual()
        {
            Kelogram kelogram1 = new Kelogram(0);
            Kelogram kelogram2 = new Kelogram(0);
            var actual = kelogram1.ConvertedKelogramValue(kelogram2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for kelogram
        /// </summary>
        [Test]
        public void NullKelogram_ShouldReturn_False()
        {
            Kelogram kelogram = new Kelogram(11);
            var actual = kelogram.Equals(null);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for kelogram
        /// </summary>
        [Test]
        public void RefCheck_ForKelogram_ShouldReturnFalse()
        {
            Kelogram kelogram = new Kelogram(11);
            var actual = this.Equals(kelogram);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for kelogram
        /// </summary>
        [Test]
        public void TypeCheck_Forkelogram_ShouldReturnTrue()
        {
            Kelogram kelogram1 = new Kelogram(11);
            Kelogram kelogram2 = new Kelogram(13);
            var actual = kelogram1.Equals(kelogram2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for kelogram
        /// </summary>
        [Test]
        public void GivenSimilar_Kelogram_WhileCheking_ShouldReturnTrue()
        {
            Kelogram kelogram1 = new Kelogram(11);
            Kelogram kelogram2 = new Kelogram(11);
            var actual = kelogram1.ConvertedKelogramValue(kelogram2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for kelogram
        /// </summary>
        [Test]
        public void GivenOdd_Kelogram_WhileCheking_ShouldReturnFalse()
        {
            Kelogram kelogram1 = new Kelogram(11);
            Kelogram kelogram2 = new Kelogram(110);
            var actual = kelogram1.ConvertedKelogramValue(kelogram2);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for gram
        /// </summary>
        [Test]
        public void Given0Gram_And0Gram_ShouldReturnEqual()
        {
            Gram gram1 = new Gram(0);
            Gram gram2 = new Gram(0);
            var actual = gram1.ConvertedGramalue(gram2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for gram
        /// </summary>
        [Test]
        public void Given_nullGram_ShouldReturnFalse()
        {
            Gram gram1 = new Gram(0);
            var actual = gram1.Equals(null);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for gram
        /// </summary>
        [Test]
        public void RefCheck_ForGram_ShouldReturnFalse()
        {
            Gram gram1 = new Gram(0);
            var actual = this.Equals(gram1);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for gram
        /// </summary>
        [Test]
        public void TypeCheck_ForGram_ShouldReturnTrue()
        {
            Gram gram1 = new Gram(11);
            Gram gram2 = new Gram(13);
            var actual = gram1.Equals(gram2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for gram
        /// </summary>
        [Test]
        public void GivenSimilar_Gram_WhileCheking_ShouldReturnTrue()
        {
            Gram gram1 = new Gram(11);
            Gram gram2 = new Gram(11);
            var actual = gram1.ConvertedGramalue(gram2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for gram
        /// </summary>
        [Test]
        public void GivenOdd_Gram_WhileCheking_ShouldReturnFalse()
        {
            Gram gram1 = new Gram(11);
            Gram gram2 = new Gram(110);
            var actual = gram1.ConvertedGramalue(gram2);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for kelogram and gram conversion
        /// </summary>
        [Test]
        public void Given0Kelogram_And_0Gram_ShouldReturnEqual()
        {
            Kelogram kelogram = new Kelogram(0);
            Gram gram = new Gram(0);
            kelogramToGram test = new kelogramToGram(kelogram, gram);
            var actual = test.ComparedKelogramAndGramValue(kelogram, gram);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for kelogram and gram conversion
        /// </summary>
        [Test]
        public void Given1Kelogram_And_1Gram_ShouldReturnEqual()
        {
            Kelogram kelogram = new Kelogram(1);
            Gram gram = new Gram(1);
            kelogramToGram test = new kelogramToGram(kelogram, gram);
            var actual = test.ComparedKelogramAndGramValue(kelogram, gram);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for kelogram and gram conversion
        /// </summary>
        [Test]
        public void Given1Kelogram_And_1000Gram_ShouldReturnEqual()
        {
            Gram gram = new Gram(1);
            Kelogram kelogram = new Kelogram(1000*gram.gram);
            kelogramToGram test = new kelogramToGram(kelogram, gram);
            var actual = test.ComparedKelogramAndGramValue(kelogram, gram);
            Assert.IsTrue(actual);
        }
    }
}
