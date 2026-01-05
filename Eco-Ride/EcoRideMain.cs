
using System;
public class EcoRideMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eco-Ride Urban Mobility System");
        ElectricCar electricCar = new ElectricCar("EC1001", "Tesla Model 3", 5);
        ElectricScooter electricScooter = new ElectricScooter("ES2001", "Xiaomi Mi Electric Scooter", 25);
        double carTripCost = electricCar.calculate_trip_cost(10); // Calculate trip cost for 10 km
        double scooterTripCost = electricScooter.calculate_trip_cost(10); // Calculate trip cost for 10 km
        Console.WriteLine($"Trip cost for Electric Car: ${carTripCost}");
        Console.WriteLine($"Trip cost for Electric Scooter: ${scooterTripCost}");

    }
}
