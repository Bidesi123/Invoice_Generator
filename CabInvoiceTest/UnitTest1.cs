using NUnit.Framework;
using NUnit;
using CabInvoiceCalculation;
using System.Collections.Generic;
using System;

namespace CabInvoiceTest
{
    public class Tests
    {
        static string userid = "12345";
       
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalCulate_Fare()
        {
            double result = CabInvoice.Calculate_Fare(0.7,5);
            double expect = Math.Max(5, ((0.7 * 10) + 5));
            Assert.AreEqual(expect, result);
        }

       
    }
}