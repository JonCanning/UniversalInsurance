using FluentAssertions;
using NUnit.Framework;

namespace UniversalInsurance.RatingEngine.Tests
{
  public class When_calculating_a_premium_and_applying_factors
  {
    [Test]
    public void Price_for_Audi_car_is_1200()
    {
      var vehicle = new Vehicle(new Audi(), new Car());
      RatingCalculator.CalculatePremium(vehicle).Should().Be(1200m);
    }

    [Test]
    public void Price_for_Audi_van_is_1500()
    {
      var vehicle = new Vehicle(new Audi(), new Van());
      RatingCalculator.CalculatePremium(vehicle).Should().Be(1500m);
    }
  }
}