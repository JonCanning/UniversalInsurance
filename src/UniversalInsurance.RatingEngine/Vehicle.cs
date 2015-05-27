namespace UniversalInsurance.RatingEngine
{
  public class Vehicle
  {
    public Vehicle(Manufacturer manufacturer, VehicleType vehicleType)
    {
      Manufacturer = manufacturer;
      VehicleType = vehicleType;
    }

    public Manufacturer Manufacturer { get; private set; }
    public VehicleType VehicleType { get; private set; }
  }
}