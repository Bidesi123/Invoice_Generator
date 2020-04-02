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
        [Test]
        public void GivenOdd_FeetValues_WhileCheking_ShouldReturnFalse()
        {
            Feet ft1 = new Feet(11);
            Feet ft2 = new Feet(110);
            var actual = ft1.ConvertedFeetValue(ft2);
            Assert.IsFalse(actual);
        }

        [Test]
        public void Given0Inch_And0Inch_ShouldReturnEqual()
        {
            Inches inch1 = new Inches(0);
            Inches inch2 = new Inches(0);
            var actual = inch1.ConvertedInchesValue(inch2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void Given_nullInch_ShouldReturnFalse()
        {
            Inches inch = new Inches(11);
            var actual = inch.Equals(null);
            Assert.IsFalse(actual);
        }

        [Test]
        public void RefCheck_ForInches_ShouldReturnFalse()
        {
            Inches inches = new Inches(11);
            var actual = this.Equals(inches);
            Assert.IsFalse(actual);
        }

        [Test]
        public void TypeCheck_ForInches_ShouldReturnTrue()
        {
            Inches inch1 = new Inches(11);
            Inches inch2 = new Inches(13);
            var actual = inch1.Equals(inch2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenSimilar_InchValues_WhileCheking_ShouldReturnTrue()
        {
            Inches inch1 = new Inches(11);
            Inches inch2 = new Inches(11);
            var actual = inch1.ConvertedInchesValue(inch2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenOdd_InchValues_WhileCheking_ShouldReturnFalse()
        {
            Inches inch1 = new Inches(11);
            Inches inch2 = new Inches(110);
            var actual = inch1.ConvertedInchesValue(inch2);
            Assert.IsFalse(actual);
        }

        [Test]
        public void Given0Feet_And_0Inch_ShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            Inches inch = new Inches(0);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet,inch);
            Assert.IsTrue(actual);
        }
        [Test]
        public void Given1Feet_And_1Inch_ShouldReturnEqual()
        {
            Feet feet = new Feet(1);
            Inches inch = new Inches(1);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet, inch);
            Assert.IsFalse(actual);
        }
        [Test]
        public void Given1Feet_And_12Inch_ShouldReturnEqual()
        {
            Inches inch = new Inches(1);
            Feet feet = new Feet(12*inch.inches);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet, inch);
            Assert.IsTrue(actual);
        }
    }
}