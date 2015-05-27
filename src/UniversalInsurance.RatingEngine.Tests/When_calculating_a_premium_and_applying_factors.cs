﻿using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace UniversalInsurance.RatingEngine.Tests
{
    public class When_calculating_a_premium_and_applying_factors
    {
        [TestCaseSource("Vehicles")]
        public void Should_calculate_the_correct_premium_for_the_vehicle_type_and_manufacturer(Vehicle vehicle, decimal expectedPremium)
        {
            var calc = new RatingCalculator();

            var premium = calc.GetRating(vehicle);

            premium.Should().Be(expectedPremium);
        }

        private static IEnumerable<TestCaseData> Vehicles()
        {
            yield return new TestCaseData(AudiCar, 800m);
            yield return new TestCaseData(MercedesVan, 2000m);
        }

        private static Vehicle AudiCar
        {
            get
            {
                var vehicle = new Vehicle
                {
                    Manufacturer = Manufacturer.Audi,
                    Class = VehicleClass.Car
                };
                return vehicle;
            }
        }
        private static Vehicle MercedesVan
        {
            get
            {
                var vehicle = new Vehicle
                {
                    Manufacturer = Manufacturer.Mercedes,
                    Class = VehicleClass.Van
                };
                return vehicle;
            }
        }
    }
}