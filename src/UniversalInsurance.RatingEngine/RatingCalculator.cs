namespace UniversalInsurance.RatingEngine
{
  public static class RatingCalculator
  {
    public static decimal CalculatePremium(Vehicle vehicle)
    {
      return vehicle.Manufacturer.Factor*vehicle.VehicleType.BasePremium;
    }
  }
}