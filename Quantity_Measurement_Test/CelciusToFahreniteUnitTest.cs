using NUnit.Framework;
using QuantityMeasurementForTemperature;

namespace Quantity_Measurement_Test
{
    class CelciusToFahreniteUnitTest
    {
        [Test]
        public void Given0Feet_And0Feet_ShouldReturnEqual()
        {
            Celcius celcius1 = new Celcius(0);
            Celcius celcius2 = new Celcius(0);
            var actual = celcius1.ConvertedCelciusValue(celcius2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void NullCelcius_ShouldReturn_False()
        {
            Celcius celcius1 = new Celcius(11);
            var actual = celcius1.Equals(null);
            Assert.IsFalse(actual);
        }
        [Test]
        public void RefCheck_ForCelcius_ShouldReturnFalse()
        {
            Celcius celcius1 = new Celcius(11);
            var actual = this.Equals(celcius1);
            Assert.IsFalse(actual);
        }
        [Test]
        public void TypeCheck_ForCelcius_ShouldReturnTrue()
        {
            Celcius celcius1 = new Celcius(11);
            Celcius celcius2 = new Celcius(13);
            var actual = celcius1.Equals(celcius1);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenSimilar_Celcius_WhileCheking_ShouldReturnTrue()
        {
            Celcius celcius1 = new Celcius(11);
            Celcius celcius2 = new Celcius(11);
            var actual = celcius1.ConvertedCelciusValue(celcius2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenOdd_Celcius_WhileCheking_ShouldReturnFalse()
        {
            Celcius celcius1 = new Celcius(11);
            Celcius celcius2 = new Celcius(110);
            var actual = celcius1.ConvertedCelciusValue(celcius2);
            Assert.IsFalse(actual);
        }
        [Test]
        public void Given0Fahrenite_And0Fahrenite_ShouldReturnEqual()
        {
            Fahrenite fahrenite1 = new Fahrenite(0);
            Fahrenite fahrenite2 = new Fahrenite(0);
            var actual = fahrenite1.ConvertedFahreniteValue(fahrenite2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void Given_nullFahrenite_ShouldReturnFalse()
        {
            Fahrenite fahrenite1 = new Fahrenite(11);
            var actual = fahrenite1.Equals(null);
            Assert.IsFalse(actual);
        }
        [Test]
        public void RefCheck_Fahrenite_ShouldReturnFalse()
        {
            Fahrenite fahrenite1 = new Fahrenite(11);
            var actual = this.Equals(fahrenite1);
            Assert.IsFalse(actual);
        }
        [Test]
        public void TypeCheck_ForFahrenite_ShouldReturnTrue()
        {
            Fahrenite fahrenite1 = new Fahrenite(11);
            Fahrenite fahrenite2 = new Fahrenite(13);
            var actual = fahrenite1.Equals(fahrenite2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenSimilar_Fahrenite_WhileCheking_ShouldReturnTrue()
        {
            Fahrenite fahrenite1 = new Fahrenite(11);
            Fahrenite fahrenite2 = new Fahrenite(11);
            var actual = fahrenite1.ConvertedFahreniteValue(fahrenite2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenOdd_Fahrenite_WhileCheking_ShouldReturnFalse()
        {
            Fahrenite fahrenite1 = new Fahrenite(11);
            Fahrenite fahrenite2 = new Fahrenite(110);
            var actual = fahrenite1.ConvertedFahreniteValue(fahrenite2);
            Assert.IsFalse(actual);
        }
        [Test]
        public void Given1Celcius_And_1Fahrenite_ShouldReturnEqual()
        {
            Celcius celcius = new Celcius(1);
            Fahrenite fahrenite = new Fahrenite(1);
            CelciusToFahrenite test = new CelciusToFahrenite(celcius, fahrenite);
            var actual = test.ComparedCelciusAndFahreniteValue(celcius, fahrenite);
            Assert.IsFalse(actual);
        }
        [Test]
        public void Given1Celcius_And_RespectedConvertedFahrenite_ShouldReturnEqual()
        {
            Fahrenite fahrenite = new Fahrenite(1);
            Celcius celcius = new Celcius(33.8*fahrenite.fahrenite);

            CelciusToFahrenite test = new CelciusToFahrenite(celcius, fahrenite);
            var actual = test.ComparedCelciusAndFahreniteValue(celcius, fahrenite);
            Assert.IsTrue(actual);
        }
    }
}
