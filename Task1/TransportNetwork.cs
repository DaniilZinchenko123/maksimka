namespace Task1
{
    public class TransportNetwork
    {
        public List<Vehicle> Vehicles { get; set; }

        public TransportNetwork()
        {
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void ControlMovement()
        {
            foreach (var vehicle in Vehicles)
            {
                vehicle.Move();
            }
        }
    }
}