using NUnit.Framework;
using NUnit;
using QuantityMeasurement;

namespace Quantity_Measurement_Test
{
    class FeetToYardUnitTest
    {
        /// <summary>
        /// test case for feet
        /// </summary>
        [Test]
        public void Given0Yard_And0Yard_ShouldReturnEqual()
        {
            Yard yard1 = new Yard(0);
            Yard yard2 = new Yard(0);
            var actual = yard1.ConvertedYardValue(yard2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for feet
        /// </summary>
        [Test]
        public void NullYard_ShouldReturn_False()
        {
            Yard yard1 = new Yard(11);
            var actual = yard1.Equals(null);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for feet
        /// </summary>
        [Test]
        public void RefCheck_ForYard_ShouldReturnFalse()
        {
            Yard yard1 = new Yard(11);
            var actual = this.Equals(yard1);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for feet
        /// </summary>
        [Test]
        public void TypeCheck_ForYard_ShouldReturnTrue()
        {
            Yard yard1 = new Yard(11);
            Yard yard2 = new Yard(13);
            var actual = yard1.Equals(yard2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for feet
        /// </summary>
        [Test]
        public void GivenSimilar_YardValues_WhileCheking_ShouldReturnTrue()
        {
            Yard yard1 = new Yard(11);
            Yard yard2 = new Yard(11);
            var actual = yard1.ConvertedYardValue(yard2);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for feet
        /// </summary>
        [Test]
        public void GivenOdd_YardValues_WhileCheking_ShouldReturnFalse()
        {
            Yard yard1 = new Yard(11);
            Yard yard2 = new Yard(110);
            var actual = yard1.ConvertedYardValue(yard2);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for feet to yard comparision
        /// </summary>
        [Test]
        public void Given0Yard_And_0Feet_ShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            Yard yard = new Yard(0);
            FeetToYard test = new FeetToYard(feet, yard);
            var actual = test.ComparedFeetAndYardValue(feet, yard);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for feet to yard comparision
        /// </summary>
        [Test]
        public void Given1Feet_And_1Yard_ShouldReturnEqual()
        {
            Feet feet = new Feet(1);
            Yard yard = new Yard(1);
            FeetToYard test = new FeetToYard(feet, yard);
            var actual = test.ComparedFeetAndYardValue(feet, yard);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for feet to yard comparision
        /// </summary>
        [Test]
        public void Given3Feet_And_1Yard_ShouldReturnEqual()
        {
            Feet feet = new Feet(1);
            Yard yard = new Yard(3*feet.feet);
            FeetToYard test = new FeetToYard(feet, yard);
            var actual = test.ComparedFeetAndYardValue(feet, yard);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// test case for feet to yard comparision
        /// </summary>
        [Test]
        public void Given1Yard_And_1Inches_ShouldReturnFalse()
        {
            Inches inch = new Inches(1);
            Yard yard = new Yard(1);
            FeetToYard test = new FeetToYard(inch, yard);
            var actual = test.ComparedInchesAndYardValue(inch, yard);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// test case for feet to yard comparision
        /// </summary>
        [Test]
        public void Given1Yard_And_36Inches_ShouldReturnTrue()
        {
            Inches inch = new Inches(1);
            Yard yard = new Yard(36*inch.inches);
            FeetToYard test = new FeetToYard(inch, yard);
            var actual = test.ComparedInchesAndYardValue(inch, yard);
            Assert.IsTrue(actual);
        }
    }
}
