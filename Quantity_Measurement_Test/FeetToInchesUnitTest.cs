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
    }
}