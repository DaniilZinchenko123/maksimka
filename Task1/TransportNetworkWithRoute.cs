namespace Task1
{
    public class TransportNetworkWithRoute : TransportNetwork
    {
        public Route CalculateOptimalRoute(Vehicle vehicle, Route route)
        {
            Console.WriteLine($"Optimal route calculated for {vehicle.GetType().Name}: {route.StartPoint} to {route.EndPoint}");
            return route;
        }

        public void EmbarkPassengers(Vehicle vehicle, int numberOfPassengers)
        {
            Console.WriteLine($"Embarking {numberOfPassengers} passengers onto {vehicle.GetType().Name}.");
        }

        public void DisembarkPassengers(Vehicle vehicle, int numberOfPassengers)
        {
            Console.WriteLine($"Disembarking {numberOfPassengers} passengers from {vehicle.GetType().Name}.");
        }
    }
}