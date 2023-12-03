namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            TransportNetworkWithRoute transportNetwork = new TransportNetworkWithRoute();
            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            Route route = new Route("City A", "City B");

            foreach (var vehicle in transportNetwork.Vehicles)
            {
                route = transportNetwork.CalculateOptimalRoute(vehicle, route);
                transportNetwork.EmbarkPassengers(vehicle, 50);
                vehicle.Move();
                transportNetwork.DisembarkPassengers(vehicle, 50);
            }
        }
    }
}