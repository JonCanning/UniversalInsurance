namespace UniversalInsurance.RatingEngine
{
  public abstract class Manufacturer
  {
    protected Manufacturer(decimal factor)
    {
      Factor = factor;
    }

    public decimal Factor { get; private set; }
  }
}