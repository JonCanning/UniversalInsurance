namespace UniversalInsurance.RatingEngine
{
  public abstract class VehicleType
  {
    public decimal BasePremium { get; private set; }

    protected VehicleType(decimal basePremium)
    {
      BasePremium = basePremium;
    }
  }
}