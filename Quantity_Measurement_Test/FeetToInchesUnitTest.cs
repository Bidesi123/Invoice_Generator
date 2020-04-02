using NUnit.Framework;
using NUnit;
using QuantityMeasurement;

namespace Quantity_Measurement_Test
{
    public class TesFeetToInchesUnitTestts
    {   
        [Test]
        public void Given0Feet_And0Feet_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0);
            Feet feet2 = new Feet(0);
            var actual = feet1.ConvertedFeetValue(feet2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void NullFeet_ShouldReturn_False()
        {
            Feet ft1 = new Feet(11);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }

        [Test]
        public void RefCheck_ForFeet_ShouldReturnFalse()
        {
            Feet ft1 = new Feet(11);
            var actual = this.Equals(ft1);
            Assert.IsFalse(actual);
        }
        [Test]
        public void TypeCheck_ForFeet_ShouldReturnTrue()
        {
            Feet ft1 = new Feet(11);
            Feet ft2 = new Feet(13);
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenSimilar_FeetValues_WhileCheking_ShouldReturnTrue()
        {
            Feet ft1 = new Feet(11);
            Feet ft2 = new Feet(11);
            var actual = ft1.ConvertedFeetValue(ft2);
            Assert.IsTrue(actual);
        }
    }
}