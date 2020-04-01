using NUnit.Framework;
using NUnit;
using CabInvoiceCalculation;
using System.Collections.Generic;
using System;

namespace CabInvoiceTest
{
    public class Tests
    {

        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare1()
        {
            double distance = 0.2;
            int time = 3;
            CabInvoice obj = new CabInvoice("Premium");
            double actual = obj.CalculateFare(distance, time);
            double expected = 20;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare2()
        {
            double distance = 0.2;
            int time = 3;
            CabInvoice obj = new CabInvoice("Normal");
            double actual = obj.CalculateFare(distance, time);
            double expected = 5;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnTotalFare1()
        {
            Rides[] rides =
                {
                new Rides(5,15),
                new Rides(12,35),
                new Rides(7,23)
            };

            CabInvoice obj = new CabInvoice("Premium");
            double Actual = obj.totalFare(rides, "Premium");
            double expect = obj.CalculateFare(5, 15) + obj.CalculateFare(12, 35) + obj.CalculateFare(7,23);
            Assert.AreEqual(Actual,expect);
        }
        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnTotalFare2()
        {
            Rides[] rides =
                {
                new Rides(5,15),
                new Rides(12,35),
                new Rides(7,23)
            };

            CabInvoice obj = new CabInvoice("Normal");
            double Actual = obj.totalFare(rides,"Normal");
            Assert.AreEqual(Actual, 313);
        }

        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnTotalNoOfRides()
        {
            Rides[] rides =
                {
                new Rides(5,15),
                new Rides(12,35),
                new Rides(7,23)
            };

            CabInvoice obj = new CabInvoice();
            double Actual = obj.TotalRides(rides);
            Assert.AreEqual(Actual, 3);
        }

        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnAverageFarePerRide()
        {
            Rides[] rides =
                {
                new Rides(5,15),
                new Rides(12,35),
                new Rides(7,23)
            };

            CabInvoice obj = new CabInvoice("Normal");
            double Actual = obj.AverageFareForEachRides(rides,"Normal");
            Assert.AreEqual(Actual, 104.33333333333333d);
        }
        [Test]
        public void Given_User_Id_AndGet_Total_Fare_User()
        {
            RideReposetory rideRepository = new RideReposetory();
            List<Rides> rides = new List<Rides>();
            rides.Add(new Rides(0.5, 5));
            rides.Add(new Rides(1.0, 8));
            CabInvoice obj = new CabInvoice("Normal");
            Customer New_Custmor = new Customer("Bdec123");
            rideRepository.AddRide(rides, New_Custmor);
            double actual = obj.GetInvoiceSummary(New_Custmor,"Normal");
            double expected = obj.totalFare(rides.ToArray(),"Normal");
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Given_User_Id_AndGet_Total_Number_Rides()
        {
            RideReposetory rideRepository = new RideReposetory();
            List<Rides> rides = new List<Rides>();
            rides.Add(new Rides(0.5, 45));
            rides.Add(new Rides(1.0, 8));
           
            Customer custmor = new Customer("Bdec123");
            rideRepository.AddRide(rides, custmor);
            double actual = Invoice_Summery.GetRides(custmor);
            CabInvoice obj = new CabInvoice();
            double expected = obj.TotalRides(rides.ToArray());
            Assert.AreEqual(actual, expected);
        }
    }
}